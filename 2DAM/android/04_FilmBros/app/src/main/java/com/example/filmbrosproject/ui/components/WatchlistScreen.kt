package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Delete
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.filmbrosproject.data.WatchlistEntity
import com.example.filmbrosproject.viewmodel.MovieViewModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun WatchlistScreen(
    viewModel: MovieViewModel,
    username: String,
    watchlistDao: com.example.filmbrosproject.data.WatchlistDao,
    onWatchlistClick: (Int, String) -> Unit,
    onBack: () -> Unit
) {
    // Al entrar, cargamos las listas del usuario
    LaunchedEffect(Unit) {
        viewModel.fetchWatchlists(username, watchlistDao)
    }

    var showRenameDialog by remember { mutableStateOf(false) }
    var showDeleteDialog by remember { mutableStateOf(false) }
    var watchlistToRename by remember { mutableStateOf<WatchlistEntity?>(null) }
    var watchlistToDelete by remember { mutableStateOf<WatchlistEntity?>(null) }
    var newName by remember { mutableStateOf("") }

    Scaffold(
        topBar = {
            TopAppBar(
                title = { Text("MIS WATCHLISTS", color = Color.White, fontWeight = FontWeight.Bold) },
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
        Column(modifier = Modifier.padding(padding).fillMaxSize().padding(16.dp)) {
            
            Button(
                onClick = { viewModel.createWatchlist(username, "Nueva Lista", watchlistDao) },
                modifier = Modifier.fillMaxWidth(),
                colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF678392))
            ) {
                Text("CREAR NUEVA WATCHLIST")
            }

            Spacer(modifier = Modifier.height(16.dp))

            LazyColumn(verticalArrangement = Arrangement.spacedBy(8.dp)) {
                items(viewModel.userWatchlists) { watchlist ->
                    Card(
                        modifier = Modifier.fillMaxWidth().clickable { 
                            onWatchlistClick(watchlist.id, watchlist.name) 
                        },
                        colors = CardDefaults.cardColors(containerColor = Color(0xFF2C3440))
                    ) {
                        Row(
                            modifier = Modifier.padding(16.dp).fillMaxWidth(),
                            verticalAlignment = Alignment.CenterVertically,
                            horizontalArrangement = Arrangement.SpaceBetween
                        ) {
                            Text(watchlist.name, color = Color.White, fontWeight = FontWeight.Bold, modifier = Modifier.weight(1f))
                            
                            Row {
                                IconButton(onClick = {
                                    watchlistToRename = watchlist
                                    newName = watchlist.name
                                    showRenameDialog = true
                                }) {
                                    Icon(Icons.Default.Edit, contentDescription = "Renombrar", tint = Color.Gray)
                                }
                                IconButton(onClick = {
                                    watchlistToDelete = watchlist
                                    showDeleteDialog = true
                                }) {
                                    Icon(Icons.Default.Delete, contentDescription = "Eliminar", tint = Color.Red)
                                }
                            }
                        }
                    }
                }
            }
        }

        if (showRenameDialog) {
            AlertDialog(
                onDismissRequest = { showRenameDialog = false },
                containerColor = Color(0xFF1B2228),
                title = { Text("Renombrar Watchlist", color = Color.White, fontWeight = FontWeight.Bold) },
                text = {
                    OutlinedTextField(
                        value = newName,
                        onValueChange = { newName = it },
                        label = { Text("Nuevo nombre", color = Color.Gray) },
                        colors = OutlinedTextFieldDefaults.colors(
                            focusedTextColor = Color.White,
                            unfocusedTextColor = Color.White,
                            focusedBorderColor = Color(0xFF678392),
                            unfocusedBorderColor = Color.Gray
                        )
                    )
                },
                confirmButton = {
                    Button(
                        onClick = {
                            watchlistToRename?.let {
                                viewModel.renameWatchlist(it.id, newName, watchlistDao)
                            }
                            showRenameDialog = false
                        },
                        colors = ButtonDefaults.buttonColors(containerColor = Color(0xFF00C02D))
                    ) {
                        Text("GUARDAR", color = Color.White, fontWeight = FontWeight.Bold)
                    }
                },
                dismissButton = {
                    TextButton(onClick = { showRenameDialog = false }) {
                        Text("CANCELAR", color = Color(0xFF678392))
                    }
                }
            )
        }

        if (showDeleteDialog) {
            AlertDialog(
                onDismissRequest = { showDeleteDialog = false },
                containerColor = Color(0xFF1B2228),
                title = { Text("Eliminar Watchlist", color = Color.White, fontWeight = FontWeight.Bold) },
                text = {
                    Text("¿Estás seguro de que quieres eliminar \"${watchlistToDelete?.name}\"? Esta acción no se puede deshacer.", color = Color.White)
                },
                confirmButton = {
                    Button(
                        onClick = {
                            watchlistToDelete?.let {
                                viewModel.deleteWatchlist(it.id, watchlistDao)
                            }
                            showDeleteDialog = false
                        },
                        colors = ButtonDefaults.buttonColors(containerColor = Color.Red)
                    ) {
                        Text("ELIMINAR", color = Color.White, fontWeight = FontWeight.Bold)
                    }
                },
                dismissButton = {
                    TextButton(onClick = { showDeleteDialog = false }) {
                        Text("CANCELAR", color = Color(0xFF678392))
                    }
                }
            )
        }
    }
}
