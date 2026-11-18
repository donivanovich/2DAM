package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.grid.GridCells
import androidx.compose.foundation.lazy.grid.LazyVerticalGrid
import androidx.compose.foundation.lazy.grid.items
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.filled.Search
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Card
import androidx.compose.material3.DropdownMenu
import androidx.compose.material3.DropdownMenuItem
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.OutlinedTextFieldDefaults
import androidx.compose.material3.Text
import androidx.compose.material3.TextButton
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import coil.compose.AsyncImage
import com.example.filmbrosproject.R
import com.example.filmbrosproject.data.Movie

@Composable
fun HomeScreen(
    movies: List<Movie>,
    username: String,
    viewModel: com.example.filmbrosproject.viewmodel.MovieViewModel,
    onNavigateToAllMovies: () -> Unit,
    onMovieClick: (Movie) -> Unit,
    onLogout: () -> Unit,
    onNavigateToUserReviews: () -> Unit,
    onNavigateToWatchlists: () -> Unit,
    onEditProfile: (String) -> Unit
) {
    // Estado para controlar si el menú desplegable está abierto
    var showMenu by remember { mutableStateOf(false) }
    var searchText by remember { mutableStateOf("") }
    
    var showEditProfileDialog by remember { mutableStateOf(false) }
    var newPassword by remember { mutableStateOf("") }

    if (showEditProfileDialog) {
        androidx.compose.material3.AlertDialog(
            onDismissRequest = { showEditProfileDialog = false },
            containerColor = Color(0xFF1B2228),
            title = { Text("Editar Perfil", color = Color.White, fontWeight = FontWeight.Bold) },
            text = {
                Column {
                    Text("Usuario: $username", color = Color(0xFF678392), fontWeight = FontWeight.Bold)
                    Spacer(modifier = Modifier.height(16.dp))
                    OutlinedTextField(
                        value = newPassword,
                        onValueChange = { newPassword = it },
                        label = { Text("Nueva Contraseña", color = Color.Gray) },
                        visualTransformation = androidx.compose.ui.text.input.PasswordVisualTransformation(),
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
                        if (newPassword.isNotBlank()) {
                            onEditProfile(newPassword)
                            showEditProfileDialog = false
                            newPassword = ""
                        }
                    },
                    colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D))
                ) {
                    Text("GUARDAR", color = Color.White, fontWeight = FontWeight.Bold)
                }
            },
            dismissButton = {
                TextButton(onClick = { showEditProfileDialog = false }) {
                    Text("CANCELAR", color = Color(0xFF678392))
                }
            }
        )
    }

    Box(modifier = Modifier.fillMaxSize().background(Color(0xFF14181C))) {
        Image(
            painter = painterResource(id = R.drawable.background),
            contentDescription = null,
            modifier = Modifier.fillMaxSize(),
            contentScale = ContentScale.Crop,
            alpha = 0.2f
        )

        Column(modifier = Modifier.fillMaxSize()) {
            // --- FILA 1: Logo, Usuario y Sección ---
            Row(
                modifier = Modifier.fillMaxWidth().padding(horizontal = 16.dp, vertical = 8.dp),
                verticalAlignment = Alignment.CenterVertically,
                horizontalArrangement = Arrangement.SpaceBetween
            ) {
                Image(
                    painter = painterResource(id = R.drawable.logoproyecto),
                    contentDescription = "Logo",
                    modifier = Modifier.height(25.dp)
                )

                // Nombre de usuario con Menú Desplegable
                Box {
                    Text(
                        text = username, // Aquí aparecerá tu "Modo Bypass" o nombre real
                        color = Color(0xFF678392), // Color azulado de tu WPF
                        modifier = Modifier.clickable { showMenu = true },
                        fontWeight = FontWeight.Bold
                    )

                    DropdownMenu(
                        expanded = showMenu,
                        onDismissRequest = { showMenu = false },
                        modifier = Modifier.background(Color(0xFF2C3440))
                    ) {
                        DropdownMenuItem(
                            text = { Text("Mis Reviews", color = Color.White) },
                            onClick = {
                                showMenu = false
                                onNavigateToUserReviews() // <--- LLAMADA A LA NAVEGACIÓN
                            }
                        )
                        DropdownMenuItem(
                            text = { Text("Mis Watchlists", color = Color.White) },
                            onClick = {
                                showMenu = false
                                onNavigateToWatchlists()
                            }
                        )
                        DropdownMenuItem(
                            text = { Text("Editar Perfil", color = Color.White) },
                            onClick = {
                                showMenu = false
                                showEditProfileDialog = true
                            }
                        )
                        DropdownMenuItem(
                            text = { Text("Cerrar Sesión", color = Color.Red) },
                            onClick = {
                                showMenu = false
                                onLogout() // <--- LLAMADA AL LOGOUT
                            }
                        )
                    }
                }

                Text("PELÍCULAS",
                    color = Color.White,
                    fontWeight = FontWeight.Bold,
                    modifier = Modifier.clickable { onNavigateToAllMovies() }
                )
            }

            // --- FILA 2: Barra de Búsqueda ---
            OutlinedTextField(
                value = searchText,
                onValueChange = { searchText = it },
                modifier = Modifier
                    .fillMaxWidth()
                    .padding(horizontal = 16.dp, vertical = 8.dp)
                    .height(50.dp),
                placeholder = { Text("Buscar...", color = Color.Gray, fontSize = 14.sp) },
                shape = RoundedCornerShape(8.dp),
                colors = TextFieldDefaults.colors(
                    unfocusedContainerColor = Color(0xFF2C3440),
                    focusedContainerColor = Color(0xFF2C3440),
                    focusedTextColor = Color.White,
                    unfocusedTextColor = Color.White,
                    unfocusedIndicatorColor = Color.Transparent,
                    focusedIndicatorColor = Color(0xFF678392)
                ),
                singleLine = true,
                trailingIcon = {
                    IconButton(onClick = {
                        // Llamamos a la búsqueda del ViewModel
                        viewModel.searchMovies(searchText)
                    }) {
                        Icon(
                            imageVector = androidx.compose.material.icons.Icons.Default.Search,
                            contentDescription = "Buscar",
                            tint = Color(0xFF678392)
                        )
                    }
                },
            )

            Text(
                "PELÍCULAS RECOMENDADAS",
                color = Color.White,
                modifier = Modifier.padding(16.dp),
                fontWeight = FontWeight.Bold,
                fontSize = 12.sp
            )

            // Cuadrícula de películas
            LazyVerticalGrid(
                columns = GridCells.Adaptive(110.dp),
                contentPadding = PaddingValues(8.dp),
                modifier = Modifier.weight(1f)
            ) {
                items(movies) { movie ->
                    MovieItem(movie = movie, onClick = {onMovieClick(movie)})
                }
            }
        }
    }
}

@Composable
fun MovieItem(movie: Movie, onClick: () -> Unit) {
    Card(
        modifier = Modifier
            .padding(8.dp)
            .fillMaxWidth()
            .aspectRatio(0.7f)
            .clickable{onClick()},//Hace clickable las caratulas
        shape = RoundedCornerShape(8.dp)
    ) {
        AsyncImage(
            // CON ESTO NOS SALTAMOS EL ERROR DEL IDE
            model = "https://image.tmdb.org/t/p/w500${movie.poster_path}",
            contentDescription = movie.title,
            modifier = Modifier.fillMaxSize(),
            contentScale = ContentScale.Crop
        )
    }
}