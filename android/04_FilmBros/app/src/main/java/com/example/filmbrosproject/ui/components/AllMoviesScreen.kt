package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.grid.GridCells
import androidx.compose.foundation.lazy.grid.LazyVerticalGrid
import androidx.compose.foundation.lazy.grid.items
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import coil.compose.AsyncImage
import com.example.filmbrosproject.data.Movie
import com.example.filmbrosproject.viewmodel.MovieViewModel

@Composable
fun AllMoviesScreen(
    viewModel: MovieViewModel,
    onMovieClick: (Movie) -> Unit,
    onBack: () -> Unit
) {
    // Cuando la pantalla se abre, cargamos la página 1 si está vacía
    LaunchedEffect(Unit) {
        if (viewModel.allMovies.isEmpty()) {
            viewModel.fetchAllMovies(1)
        }
    }

    Column(
        modifier = Modifier
            .fillMaxSize()
            .background(Color(0xFF14181C))
            .padding(16.dp)
    ) {
        // --- CABECERA Y FILTRO BÁSICO ---
        Row(
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceBetween,
            verticalAlignment = Alignment.CenterVertically
        ) {
            Button(onClick = onBack, colors = ButtonDefaults.buttonColors(containerColor = Color.White)) {
                Text("VOLVER", color = Color.Black, fontWeight = FontWeight.Bold)
            }
            Text("PELÍCULAS", color = Color.White, fontSize = 20.sp, fontWeight = FontWeight.Bold)

            var showFilters by remember { mutableStateOf(false) }

            Box {
                OutlinedButton(onClick = { showFilters = true }) {
                    Text("FILTRAR", color = Color.Yellow)
                }

                DropdownMenu(
                    expanded = showFilters,
                    onDismissRequest = { showFilters = false },
                    modifier = Modifier.background(Color(0xFF2C3440))
                ) {
                    DropdownMenuItem(
                        text = { Text("Más Valoradas", color = Color.White) },
                        onClick = {
                            viewModel.selectedSortBy = "vote_average.desc"
                            viewModel.selectedGenreId = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )
                    // Ejemplo para Acción
                    DropdownMenuItem(
                        text = { Text("Acción", color = Color.White) },
                        onClick = {
                            viewModel.selectedGenreId = "28"
                            viewModel.selectedSortBy = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )
                    DropdownMenuItem(
                        text = { Text("Comedia 😂", color = Color.White) },
                        onClick = {
                            viewModel.selectedGenreId = "35"
                            viewModel.selectedSortBy = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )
                    // 4. DRAMA (ID 18)
                    DropdownMenuItem(
                        text = { Text("Drama 🎭", color = Color.White) },
                        onClick = {
                            viewModel.selectedGenreId = "18"
                            viewModel.selectedSortBy = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )

                    // 5. CIENCIA FICCIÓN (ID 878)
                    DropdownMenuItem(
                        text = { Text("Ciencia Ficción 🚀", color = Color.White) },
                        onClick = {
                            viewModel.selectedGenreId = "878"
                            viewModel.selectedSortBy = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )

                    Divider(color = Color.Gray, thickness = 0.5.dp)

                    // 6. LIMPIAR FILTROS (Vuelve a populares)
                    DropdownMenuItem(
                        text = { Text("Limpiar Filtros 🧹", color = Color.Red) },
                        onClick = {
                            viewModel.selectedGenreId = null
                            viewModel.selectedSortBy = null
                            viewModel.fetchAllMovies(1)
                            showFilters = false
                        }
                    )
                }
            }
        }

        Spacer(modifier = Modifier.height(16.dp))

        // --- GRID DE PELÍCULAS ---
        if (viewModel.isPaginating) {
            Box(modifier = Modifier.weight(1f).fillMaxWidth(), contentAlignment = Alignment.Center) {
                CircularProgressIndicator(color = Color.Yellow)
            }
        } else {
            LazyVerticalGrid(
                columns = GridCells.Fixed(3), // 3 columnas tipo Letterboxd
                modifier = Modifier.weight(1f),
                horizontalArrangement = Arrangement.spacedBy(8.dp),
                verticalArrangement = Arrangement.spacedBy(8.dp)
            ) {
                items(viewModel.allMovies) { movie ->
                    Card(
                        modifier = Modifier
                            .aspectRatio(0.7f)
                            .clickable { onMovieClick(movie) },
                        elevation = CardDefaults.cardElevation(4.dp)
                    ) {
                        AsyncImage(
                            model = "https://image.tmdb.org/t/p/w500${movie.poster_path}",
                            contentDescription = movie.title,
                            modifier = Modifier.fillMaxSize(),
                            contentScale = ContentScale.Crop
                        )
                    }
                }
            }
        }

        Spacer(modifier = Modifier.height(16.dp))

        // --- CONTROLES DE PAGINACIÓN ---
        Row(
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceEvenly,
            verticalAlignment = Alignment.CenterVertically
        ) {
            Button(
                onClick = { if (viewModel.currentPage > 1) viewModel.fetchAllMovies(viewModel.currentPage - 1) },
                enabled = viewModel.currentPage > 1,
                colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF678392))
            ) {
                Text("ANTERIOR")
            }

            Text("Pág ${viewModel.currentPage}", color = Color.White, fontWeight = FontWeight.Bold)

            Button(
                onClick = { viewModel.fetchAllMovies(viewModel.currentPage + 1) },
                colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF678392))
            ) {
                Text("SIGUIENTE")
            }
        }
    }
}

