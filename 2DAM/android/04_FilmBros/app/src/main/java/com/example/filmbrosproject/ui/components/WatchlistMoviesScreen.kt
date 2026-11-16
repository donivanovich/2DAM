package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.grid.GridCells
import androidx.compose.foundation.lazy.grid.LazyVerticalGrid
import androidx.compose.foundation.lazy.grid.items
import androidx.compose.foundation.shape.CircleShape
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Delete
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
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.filmbrosproject.data.Movie
import com.example.filmbrosproject.viewmodel.MovieViewModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun WatchlistMoviesScreen(
    viewModel: MovieViewModel,
    watchlistId: Int,
    watchlistName: String,
    watchlistDao: com.example.filmbrosproject.data.WatchlistDao,
    onMovieClick: (Movie) -> Unit,
    onBack: () -> Unit
) {
    LaunchedEffect(watchlistId) {
        viewModel.fetchMoviesInWatchlist(watchlistId, watchlistDao)
    }

    var movieToRemove by remember { mutableStateOf<Movie?>(null) }
    var showRemoveDialog by remember { mutableStateOf(false) }

    Scaffold(
        topBar = {
            TopAppBar(
                title = { Text(watchlistName.uppercase(), color = Color.White, fontWeight = FontWeight.Bold) },
                navigationIcon = {
                    IconButton(onClick = onBack) {
                        Text("←", color = Color.White, fontSize = 24.sp)
                    }
                },
                colors = TopAppBarDefaults.topAppBarColors(containerColor = Color(0xFF1B2228))
            )
        },
        containerColor = Color(0xFF14181C)
    ) { padding ->
        Box(modifier = Modifier.padding(padding).fillMaxSize()) {
            if (viewModel.isLoadingWatchlistMovies) {
                CircularProgressIndicator(modifier = Modifier.align(Alignment.Center), color = Color(0xFF678392))
            } else if (viewModel.watchlistMovies.isEmpty()) {
                Text(
                    "Esta lista está vacía",
                    color = Color.Gray,
                    modifier = Modifier.align(Alignment.Center)
                )
            } else {
                LazyVerticalGrid(
                    columns = GridCells.Adaptive(110.dp),
                    contentPadding = PaddingValues(8.dp),
                    modifier = Modifier.fillMaxSize()
                ) {
                    items(viewModel.watchlistMovies) { movie ->
                        Box {
                            MovieItem(movie = movie, onClick = { onMovieClick(movie) })
                            
                            // Botón para eliminar de la lista (esquina superior derecha)
                            Surface(
                                onClick = {
                                    movieToRemove = movie
                                    showRemoveDialog = true
                                },
                                modifier = Modifier.align(Alignment.TopEnd).padding(4.dp).size(28.dp),
                                shape = CircleShape,
                                color = Color.Black.copy(alpha = 0.7f)
                            ) {
                                Icon(
                                    Icons.Default.Delete,
                                    contentDescription = "Eliminar",
                                    tint = Color.Red,
                                    modifier = Modifier.padding(4.dp)
                                )
                            }
                        }
                    }
                }
            }
        }

        if (showRemoveDialog) {
            AlertDialog(
                onDismissRequest = { showRemoveDialog = false },
                containerColor = Color(0xFF1B2228),
                title = { Text("Quitar película", color = Color.White, fontWeight = FontWeight.Bold) },
                text = {
                    Text("¿Quieres quitar \"${movieToRemove?.title}\" de esta lista?", color = Color.White)
                },
                confirmButton = {
                    Button(
                        onClick = {
                            movieToRemove?.let {
                                viewModel.removeFromWatchlist(watchlistId, it.id, watchlistDao)
                            }
                            showRemoveDialog = false
                        },
                        colors = ButtonDefaults.buttonColors(containerColor = Color.Red)
                    ) {
                        Text("QUITAR", color = Color.White, fontWeight = FontWeight.Bold)
                    }
                },
                dismissButton = {
                    TextButton(onClick = { showRemoveDialog = false }) {
                        Text("CANCELAR", color = Color(0xFF678392))
                    }
                }
            )
        }
    }
}
