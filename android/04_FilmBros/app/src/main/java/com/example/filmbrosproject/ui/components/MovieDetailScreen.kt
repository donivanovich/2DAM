package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.rememberScrollState
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.foundation.verticalScroll
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Delete
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material.icons.filled.Star
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.platform.LocalContext
import android.widget.Toast
import androidx.compose.runtime.rememberCoroutineScope
import kotlinx.coroutines.launch
import androidx.lifecycle.viewmodel.compose.viewModel
import coil.compose.AsyncImage
import com.example.filmbrosproject.R
import com.example.filmbrosproject.data.Movie
import com.example.filmbrosproject.data.RemoteReview
import com.example.filmbrosproject.viewmodel.MovieViewModel


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun MovieDetailScreen(
    movie: Movie?,
    apiReviews: List<RemoteReview>,
    localReviews: List<com.example.filmbrosproject.data.ReviewEntity>,
    username: String,
    viewModel: MovieViewModel ,
    database: com.example.filmbrosproject.data.AppDatabase,
    onBack: () -> Unit
) {
    // Si no hay película seleccionada, no mostramos nada
    if (movie == null) return

    val context = LocalContext.current
    // Estado para el texto de la reseña
    var reviewText by remember { mutableStateOf("") }
    var showWatchlistDialog by remember { mutableStateOf(false) }
    var newWatchlistName by remember { mutableStateOf("") }
    
    var showEditReviewDialog by remember { mutableStateOf(false) }
    var editingReviewId by remember { mutableIntStateOf(0) }
    var editReviewText by remember { mutableStateOf("") }
    var editReviewRating by remember { mutableDoubleStateOf(0.0) }

    val scope = rememberCoroutineScope()

    // Diálogo para editar reseña
    if (showEditReviewDialog) {
        AlertDialog(
            onDismissRequest = { showEditReviewDialog = false },
            title = { Text("Editar reseña", fontWeight = FontWeight.Bold, color = Color.White) },
            containerColor = Color(0xFF1B2228),
            text = {
                Column {
                    OutlinedTextField(
                        value = editReviewText,
                        onValueChange = { editReviewText = it },
                        modifier = Modifier.fillMaxWidth().height(150.dp),
                        colors = OutlinedTextFieldDefaults.colors(
                            focusedTextColor = Color.White,
                            unfocusedTextColor = Color.White,
                            focusedBorderColor = Color(0xFF678392),
                            unfocusedBorderColor = Color.Gray
                        )
                    )
                    Spacer(modifier = Modifier.height(16.dp))
                    Text("Calificación", color = Color(0xFF678392), fontWeight = FontWeight.Bold)
                    Row(
                        modifier = Modifier.padding(vertical = 8.dp),
                        horizontalArrangement = Arrangement.spacedBy(8.dp)
                    ) {
                        repeat(5) { index ->
                            val starRating = (index + 1) * 2.0
                            Icon(
                                imageVector = Icons.Filled.Star,
                                contentDescription = null,
                                tint = if (starRating <= editReviewRating) Color.Yellow else Color.DarkGray,
                                modifier = Modifier
                                    .size(32.dp)
                                    .clickable { editReviewRating = starRating }
                            )
                        }
                    }
                }
            },
            confirmButton = {
                Button(
                    onClick = {
                        viewModel.updateReview(editingReviewId, editReviewText, editReviewRating, database.reviewDao())
                        showEditReviewDialog = false
                    },
                    colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D))
                ) {
                    Text("GUARDAR", color = Color.White, fontWeight = FontWeight.Bold)
                }
            },
            dismissButton = {
                TextButton(onClick = { showEditReviewDialog = false }) {
                    Text("CANCELAR", color = Color(0xFF678392))
                }
            }
        )
    }

    // Diálogo para elegir Watchlist
    if (showWatchlistDialog) {
        AlertDialog(
            onDismissRequest = { showWatchlistDialog = false },
            title = { Text("Añadir a una lista", fontWeight = FontWeight.Bold, color = Color.White) },
            containerColor = Color(0xFF1B2228),
            text = {
                Column {
                    if (viewModel.userWatchlists.isEmpty()) {
                        Text("No tienes listas todavía.", color = Color.Gray)
                    } else {
                        Text("Tus listas:", fontWeight = FontWeight.Bold, color = Color(0xFF678392))
                        Spacer(modifier = Modifier.height(8.dp))
                        viewModel.userWatchlists.forEach { watchlist ->
                            Button(
                                onClick = {
                                    scope.launch {
                                        try {
                                            database.watchlistDao().addMovieToWatchlist(
                                                com.example.filmbrosproject.data.WatchlistItemEntity(
                                                    watchlistId = watchlist.id,
                                                    movieId = movie.id
                                                )
                                            )
                                            Toast.makeText(context, "Añadida a ${watchlist.name}", Toast.LENGTH_SHORT).show()
                                        } catch (e: Exception) {
                                            Toast.makeText(context, "Ya está en esta lista", Toast.LENGTH_SHORT).show()
                                        }
                                        showWatchlistDialog = false
                                    }
                                },
                                modifier = Modifier.fillMaxWidth().padding(vertical = 4.dp),
                                colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF2C3440))
                            ) {
                                Text(watchlist.name, color = Color.White)
                            }
                        }
                    }
                    Spacer(modifier = Modifier.height(16.dp))
                    Text("Crear nueva lista:", fontWeight = FontWeight.Bold, color = Color(0xFF678392))
                    OutlinedTextField(
                        value = newWatchlistName,
                        onValueChange = { newWatchlistName = it },
                        placeholder = { Text("Nombre de la lista", color = Color.Gray) },
                        modifier = Modifier.fillMaxWidth(),
                        colors = OutlinedTextFieldDefaults.colors(
                            focusedTextColor = Color.White,
                            unfocusedTextColor = Color.White,
                            focusedBorderColor = Color(0xFF678392),
                            unfocusedBorderColor = Color.Gray
                        )
                    )
                }
            },
            confirmButton = {
                Button(
                    onClick = {
                        if (newWatchlistName.isNotBlank()) {
                            viewModel.createWatchlist(username, newWatchlistName, database.watchlistDao())
                            newWatchlistName = ""
                            // Refrescamos las listas para que aparezca la nueva
                            viewModel.fetchWatchlists(username, database.watchlistDao())
                        }
                    },
                    colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D))
                ) {
                    Text("CREAR", color = Color.White, fontWeight = FontWeight.Bold)
                }
            },
            dismissButton = {
                TextButton(onClick = { showWatchlistDialog = false }) {
                    Text("CANCELAR", color = Color(0xFF678392))
                }
            }
        )
    }

    Box(modifier = Modifier.fillMaxSize().background(Color(0xFF14181C))) {
        // Fondo temático (Claquetas)
        Image(
            painter = painterResource(id = R.drawable.background),
            contentDescription = null,
            modifier = Modifier.fillMaxSize(),
            contentScale = ContentScale.Crop,
            alpha = 0.15f
        )

        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(16.dp)
                .verticalScroll(rememberScrollState())
        ) {
            // Botón Volver
            Button(
                onClick = onBack,
                colors = ButtonDefaults.buttonColors(containerColor = Color.White),
                shape = MaterialTheme.shapes.small
            ) {
                Text("VOLVER", color = Color.Black, fontWeight = FontWeight.Bold)
            }

            Spacer(modifier = Modifier.height(20.dp))

            // Cabecera: Póster e Info básica
            Row(modifier = Modifier.fillMaxWidth()) {
                // Póster Izquierda
                Card(
                    modifier = Modifier
                        .width(150.dp)
                        .aspectRatio(0.7f),
                    elevation = CardDefaults.cardElevation(8.dp)
                ) {
                    AsyncImage(
                        model = "https://image.tmdb.org/t/p/w500${movie.poster_path}",
                        contentDescription = movie.title,
                        modifier = Modifier.fillMaxSize(),
                        contentScale = ContentScale.Crop
                    )
                }

                Spacer(modifier = Modifier.width(16.dp))

                // Info Derecha
                Column(modifier = Modifier.weight(1f)) {
                    Text(
                        text = movie.title,
                        color = Color.White,
                        fontSize = 22.sp,
                        fontWeight = FontWeight.Bold,
                        lineHeight = 28.sp
                    )
                    Spacer(modifier = Modifier.height(12.dp))
                    Text("SINOPSIS", color = Color(0xFF678392), fontSize = 12.sp, fontWeight = FontWeight.Bold)
                    Text(
                        text = movie.overview,
                        color = Color.White,
                        fontSize = 14.sp,
                        lineHeight = 20.sp
                    )
                    Spacer(modifier = Modifier.height(12.dp))
                    Text("PUNTUACIÓN", color = Color(0xFF678392), fontSize = 12.sp, fontWeight = FontWeight.Bold)
                    Text("⭐ ${movie.vote_average}", color = Color.Yellow, fontSize = 16.sp)

                    Spacer(modifier = Modifier.height(16.dp))

                    Button(
                        onClick = {
                            viewModel.fetchWatchlists(username, database.watchlistDao())
                            showWatchlistDialog = true
                        },
                        colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D)),
                        shape = RoundedCornerShape(4.dp),
                        modifier = Modifier.height(36.dp),
                        contentPadding = PaddingValues(horizontal = 12.dp, vertical = 0.dp)
                    ) {
                        Text("AÑADIR A WATCHLIST", color = Color.White, fontWeight = FontWeight.Bold, fontSize = 12.sp)
                    }
                }
            }

            Spacer(modifier = Modifier.height(32.dp))

            // Sección de Reseña
            Text(
                "DEJA TU RESEÑA",
                color = Color.White,
                fontWeight = FontWeight.Bold,
                fontSize = 16.sp
            )

            OutlinedTextField(
                value = reviewText,
                onValueChange = { reviewText = it },
                modifier = Modifier
                    .fillMaxWidth()
                    .height(150.dp)
                    .padding(vertical = 8.dp),
                placeholder = { Text("¿Qué te ha parecido la película?", color = Color.Gray) },
                colors = OutlinedTextFieldDefaults.colors(
                    focusedBorderColor = Color(0xFF678392),
                    unfocusedBorderColor = Color.Gray,
                    cursorColor = Color.White,
                    focusedTextColor = Color.White,
                    unfocusedTextColor = Color.White,
                    focusedContainerColor = Color.Transparent,
                    unfocusedContainerColor = Color.Transparent
                )
            )

            var userRating by remember { mutableFloatStateOf(10f) }

            Text(
                "TU CALIFICACIÓN",
                color = Color(0xFF678392),
                fontSize = 12.sp,
                fontWeight = FontWeight.Bold
            )

            Row(
                modifier = Modifier.padding(vertical = 8.dp),
                horizontalArrangement = Arrangement.spacedBy(8.dp)
            ) {
                repeat(5) { index ->
                    val starRating = (index + 1) * 2.0 // Cada estrella vale 2 puntos (2, 4, 6, 8, 10)
                    Icon(
                        imageVector = Icons.Filled.Star,
                        contentDescription = null,
                        // Si la estrella es menor o igual a la nota elegida, se pinta amarilla
                        tint = if (starRating <= userRating) Color.Yellow else Color.DarkGray,
                        modifier = Modifier
                            .size(32.dp)
                            .clickable {
                                userRating = starRating.toFloat()
                            } // Al pulsar, actualizamos la nota
                    )
                }
            }

            Button(
                onClick = {
                    if (reviewText.isNotBlank()) {
                        // Llamamos a la función de guardado
                        viewModel.saveReview(
                            movieId = movie.id,
                            movieTitle = movie.title,
                            username = username, // El nombre de usuario que inició sesión
                            text = reviewText,
                            rating = userRating.toDouble(),
                            reviewDao = database.reviewDao()
                        )
                        reviewText = "" // Limpiamos el cuadro de texto
                    }
                },
                modifier = Modifier.align(Alignment.End),
                colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF678392))
            ) {
                Text("ENVIAR RESEÑA", color = Color.White, fontWeight = FontWeight.Bold)
            }

            // Espacio extra al final para que el scroll respire
            Spacer(modifier = Modifier.height(50.dp))

            if (localReviews.isNotEmpty()) {
                val myReviews = localReviews.filter { it.username == username }
                val communityReviews = localReviews.filter { it.username != username }

                if (myReviews.isNotEmpty()) {
                    Text("MIS RESEÑAS", color = Color.Yellow, fontWeight = FontWeight.Bold, fontSize = 18.sp)
                    Spacer(modifier = Modifier.height(8.dp))
                    myReviews.forEach { review ->
                        ReviewItem(
                            author = review.username, 
                            content = review.comment, 
                            rating = review.rating, 
                            isLocal = true,
                            onDelete = {
                                viewModel.deleteReview(review.id, database.reviewDao())
                            },
                            onEdit = {
                                editingReviewId = review.id
                                editReviewText = review.comment
                                editReviewRating = review.rating
                                showEditReviewDialog = true
                            }
                        )
                    }
                    Spacer(modifier = Modifier.height(24.dp))
                }

                if (communityReviews.isNotEmpty()) {
                    Text("RESEÑAS DE FILMBROS", color = Color.White, fontWeight = FontWeight.Bold, fontSize = 18.sp)
                    Spacer(modifier = Modifier.height(8.dp))
                    communityReviews.forEach { review ->
                        ReviewItem(author = review.username, content = review.comment, rating = review.rating, isLocal = false)
                    }
                    Spacer(modifier = Modifier.height(24.dp))
                }
            }

            // --- SECCIÓN 2: RESEÑAS DE LA COMUNIDAD (API) ---
            Text("RESEÑAS DE LA COMUNIDAD", color = Color.White, fontWeight = FontWeight.Bold, fontSize = 18.sp)
            Spacer(modifier = Modifier.height(16.dp))
            apiReviews.forEach { review ->
                ReviewItem(author = review.author, content = review.content,rating = movie.vote_average, isLocal = false)
            }

            Spacer(modifier = Modifier.height(50.dp))
        }
    }
}

// --- COMPONENTE PARA CADA RESEÑA (Ponlo fuera de la función anterior) ---
@Composable
fun ReviewItem(author: String, content: String, rating: Double, isLocal: Boolean, onDelete: (() -> Unit)? = null, onEdit: (() -> Unit)? = null) {
    Card(
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 4.dp),
        colors = CardDefaults.cardColors(
            containerColor = if (isLocal) Color(0xFF333B45) else Color(0xFF2C3440)
        ),
        shape = RoundedCornerShape(8.dp)
    ) {
        Column(modifier = Modifier.padding(12.dp)) {
            Row(verticalAlignment = Alignment.CenterVertically, horizontalArrangement = Arrangement.SpaceBetween, modifier = Modifier.fillMaxWidth()) {
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Text(
                        text = author,
                        color = if (isLocal) Color.Yellow else Color(0xFF678392),
                        fontWeight = FontWeight.Bold,
                        fontSize = 14.sp
                    )
                    Spacer(modifier = Modifier.width(8.dp))
                    RatingStars(rating = rating)
                }

                Row {
                    if (onEdit != null) {
                        IconButton(onClick = onEdit, modifier = Modifier.size(24.dp)) {
                            Icon(Icons.Default.Edit, contentDescription = "Editar", tint = Color.Gray, modifier = Modifier.size(16.dp))
                        }
                    }
                    if (onDelete != null) {
                        IconButton(onClick = onDelete, modifier = Modifier.size(24.dp)) {
                            Icon(Icons.Default.Delete, contentDescription = "Eliminar", tint = Color.Gray, modifier = Modifier.size(16.dp))
                        }
                    }
                }
            }
            Spacer(modifier = Modifier.height(4.dp))
            Text(
                text = content,
                color = Color.White,
                fontSize = 13.sp
            )
        }
    }
}

@Composable
fun RatingStars(rating: Double, maxStars: Int = 5) {
    Row {
        val filledStars = (rating / 2).toInt() // Convertimos de 10 a 5
        repeat(maxStars) { index ->
            Icon(
                imageVector = Icons.Filled.Star,
                contentDescription = null,
                tint = if (index < filledStars) Color.Yellow else Color.Gray,
                modifier = Modifier.size(16.dp)
            )
        }
    }
}
