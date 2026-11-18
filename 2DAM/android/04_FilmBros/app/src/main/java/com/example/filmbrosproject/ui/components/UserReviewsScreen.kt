package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Delete
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material.icons.filled.Star
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.filmbrosproject.data.ReviewEntity

@Composable
fun UserReviewsScreen(
    reviews: List<ReviewEntity>,
    onDeleteReview: (Int) -> Unit,
    onUpdateReview: (Int, String, Double) -> Unit,
    onBack: () -> Unit
) {
    var showEditDialog by remember { mutableStateOf(false) }
    var reviewToEdit by remember { mutableStateOf<ReviewEntity?>(null) }
    var editComment by remember { mutableStateOf("") }
    var editRating by remember { mutableDoubleStateOf(0.0) }

    Column(
        modifier = Modifier
            .fillMaxSize()
            .background(Color(0xFF14181C))
            .padding(16.dp)
    ) {
        // Botón Volver
        Button(
            onClick = onBack,
            colors = ButtonDefaults.buttonColors(containerColor = Color.White),
            shape = MaterialTheme.shapes.small
        ) {
            Text("VOLVER", color = Color.Black, fontWeight = FontWeight.Bold)
        }

        Spacer(modifier = Modifier.height(24.dp))

        Text(
            text = "MIS RESEÑAS HISTÓRICAS",
            color = Color.Yellow,
            fontSize = 20.sp,
            fontWeight = FontWeight.Bold
        )

        Spacer(modifier = Modifier.height(8.dp))

        Text(
            text = "Has escrito ${reviews.size} reseñas en total",
            color = Color.Gray,
            fontSize = 14.sp
        )

        Spacer(modifier = Modifier.height(16.dp))

        if (reviews.isEmpty()) {
            Box(modifier = Modifier.fillMaxSize(), contentAlignment = Alignment.Center) {
                Text("Aún no has escrito ninguna reseña.", color = Color.Gray)
            }
        } else {
            LazyColumn(
                verticalArrangement = Arrangement.spacedBy(12.dp),
                modifier = Modifier.fillMaxSize()
            ) {
                items(reviews) { review ->
                    UserReviewItem(
                        review = review, 
                        onDelete = { onDeleteReview(review.id) },
                        onEdit = {
                            reviewToEdit = review
                            editComment = review.comment
                            editRating = review.rating
                            showEditDialog = true
                        }
                    )
                }
            }
        }

        if (showEditDialog) {
            AlertDialog(
                onDismissRequest = { showEditDialog = false },
                containerColor = Color(0xFF1B2228),
                title = { Text("Editar reseña", color = Color.White, fontWeight = FontWeight.Bold) },
                text = {
                    Column {
                        OutlinedTextField(
                            value = editComment,
                            onValueChange = { editComment = it },
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
                                    tint = if (starRating <= editRating) Color.Yellow else Color.DarkGray,
                                    modifier = Modifier
                                        .size(32.dp)
                                        .clickable { editRating = starRating }
                                )
                            }
                        }
                    }
                },
                confirmButton = {
                    Button(
                        onClick = {
                            reviewToEdit?.let {
                                onUpdateReview(it.id, editComment, editRating)
                            }
                            showEditDialog = false
                        },
                        colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D))
                    ) {
                        Text("GUARDAR", color = Color.White, fontWeight = FontWeight.Bold)
                    }
                },
                dismissButton = {
                    TextButton(onClick = { showEditDialog = false }) {
                        Text("CANCELAR", color = Color(0xFF678392))
                    }
                }
            )
        }
    }
}

@Composable
fun UserReviewItem(review: ReviewEntity, onDelete: () -> Unit, onEdit: () -> Unit) {
    Card(
        modifier = Modifier.fillMaxWidth(),
        colors = CardDefaults.cardColors(containerColor = Color(0xFF2C3440)),
        shape = RoundedCornerShape(8.dp)
    ) {
        Column(modifier = Modifier.padding(16.dp)) {
            Row(
                modifier = Modifier.fillMaxWidth(),
                horizontalArrangement = Arrangement.SpaceBetween,
                verticalAlignment = Alignment.CenterVertically
            ) {
                Column(modifier = Modifier.weight(1f)) {
                    Text(
                        text = review.movieTitle.uppercase(),
                        color = Color(0xFF678392),
                        fontWeight = FontWeight.Bold,
                        fontSize = 14.sp
                    )

                    // Sistema de estrellas usando solo Icons.Filled.Star y colores
                    Row {
                        val filledStars = (review.rating / 2).toInt()
                        repeat(5) { index ->
                            Icon(
                                imageVector = Icons.Filled.Star,
                                contentDescription = null,
                                // Si el índice es menor a las estrellas calculadas, Amarillo; si no, Gris oscuro
                                tint = if (index < filledStars) Color.Yellow else Color.DarkGray,
                                modifier = Modifier.size(16.dp)
                            )
                        }
                    }
                }

                Row {
                    IconButton(onClick = onEdit) {
                        Icon(Icons.Default.Edit, contentDescription = "Editar", tint = Color.Gray)
                    }
                    IconButton(onClick = onDelete) {
                        Icon(Icons.Default.Delete, contentDescription = "Eliminar", tint = Color.Gray)
                    }
                }
            }

            Spacer(modifier = Modifier.height(8.dp))

            Text(
                text = review.comment,
                color = Color.White,
                fontSize = 15.sp,
                lineHeight = 20.sp
            )
        }
    }
}