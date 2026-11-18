package com.example.filmbrosproject

import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.safeDrawingPadding
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.lifecycle.viewmodel.compose.viewModel
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.example.filmbrosproject.data.AppDatabase
import com.example.filmbrosproject.ui.components.AllMoviesScreen
import com.example.filmbrosproject.ui.components.HomeScreen
import com.example.filmbrosproject.ui.components.LoginScreen
import com.example.filmbrosproject.ui.components.MovieDetailScreen
import com.example.filmbrosproject.ui.components.UserReviewsScreen
import com.example.filmbrosproject.ui.components.WatchlistMoviesScreen
import com.example.filmbrosproject.ui.components.WatchlistScreen
import com.example.filmbrosproject.viewmodel.LoginViewModel
import com.example.filmbrosproject.viewmodel.MovieViewModel

// 1. Definimos las rutas (los nombres de nuestras pantallas)
sealed class Screen(val route: String) {
    object Login : Screen("login")
    object Home : Screen("home")
    object Details : Screen("details/{movieId}")
    object AllMovies : Screen("all_movies")
    object UserReviews : Screen("user_reviews")
    object Watchlists : Screen("watchlists")
    object WatchlistDetail : Screen("watchlist_detail/{id}/{name}")
}

@Composable
fun AppNavigation(loginViewModel: LoginViewModel, movieViewModel: MovieViewModel) {
    val navController = rememberNavController()

    // El NavHost es el "intercambiador" de pantallas
    // Envolvemos todo en un Box con el color de la app para que el safeDrawingPadding tenga ese fondo
    Box(modifier = Modifier.fillMaxSize().background(Color(0xFF14181C))) {
        NavHost(
            navController = navController,
            startDestination = Screen.Login.route,
            modifier = Modifier.safeDrawingPadding()
        ) {
            //Pantalla Login
            composable(Screen.Login.route){
                LoginScreen(
                    viewModel = loginViewModel,
                    onLoginSuccess = {
                        navController.navigate(Screen.Home.route) {
                            popUpTo(Screen.Login.route) { inclusive = true }
                        }
                    }
                )
            }
            // Pantalla Principal
            composable(Screen.Home.route) {
                val context = androidx.compose.ui.platform.LocalContext.current
                HomeScreen(
                    movies = movieViewModel.movies,
                    username = loginViewModel.loggedUser,
                    viewModel = movieViewModel,
                    onNavigateToAllMovies = {
                        navController.navigate(Screen.AllMovies.route)
                    },
                    onMovieClick = { movie ->
                        movieViewModel.selectedMovie = movie
                        movieViewModel.fetchMovieReviews(movie.id)
                        val database = AppDatabase.getDatabase(context)
                        movieViewModel.fetchLocalReviews(movie.id, database.reviewDao())
                        navController.navigate(Screen.Details.route)
                    },
                    onLogout = {
                        navController.navigate(Screen.Login.route) {
                            popUpTo(Screen.Home.route) { inclusive = true }
                        }
                    },
                    onNavigateToUserReviews = {
                        val database = AppDatabase.getDatabase(context)
                        movieViewModel.fetchAllReviewsByUser(loginViewModel.loggedUser, database.reviewDao())
                        navController.navigate(Screen.UserReviews.route)
                    },
                    onNavigateToWatchlists = {
                        navController.navigate(Screen.Watchlists.route)
                    },
                onEditProfile = { newPassword ->
                    loginViewModel.updatePassword(newPassword) { success ->
                        if (success) {
                            android.widget.Toast.makeText(context, "Contraseña actualizada", android.widget.Toast.LENGTH_SHORT).show()
                        }
                    }
                }
            )
            }

            composable(Screen.AllMovies.route) {
                val context = androidx.compose.ui.platform.LocalContext.current
                AllMoviesScreen(
                    viewModel = movieViewModel,
                    onMovieClick = { movie ->
                        movieViewModel.selectedMovie = movie
                        movieViewModel.fetchMovieReviews(movie.id)
                        val database = AppDatabase.getDatabase(context)
                        movieViewModel.fetchLocalReviews(movie.id, database.reviewDao())
                        navController.navigate(Screen.Details.route)
                    },
                    onBack = { navController.popBackStack() }
                )
            }

            composable(Screen.Details.route) {
                val context = androidx.compose.ui.platform.LocalContext.current
                val database = AppDatabase.getDatabase(context)
                MovieDetailScreen(
                    movie = movieViewModel.selectedMovie,
                    apiReviews = movieViewModel.apiReviews,
                    localReviews = movieViewModel.localReviews,
                    username = loginViewModel.loggedUser,
                    viewModel = movieViewModel,
                    database = database,
                    onBack = { navController.popBackStack() }
                )
            }

            composable(Screen.UserReviews.route) {
                val context = androidx.compose.ui.platform.LocalContext.current
                UserReviewsScreen(
                    reviews = movieViewModel.userAllReviews,
                    onDeleteReview = { reviewId ->
                        val database = AppDatabase.getDatabase(context)
                        movieViewModel.deleteReview(reviewId, database.reviewDao())
                    },
                    onUpdateReview = { reviewId, text, rating ->
                        val database = AppDatabase.getDatabase(context)
                        movieViewModel.updateReview(reviewId, text, rating, database.reviewDao())
                    },
                    onBack = { navController.popBackStack() }
                )
            }

            composable(Screen.Watchlists.route) {
                val context = androidx.compose.ui.platform.LocalContext.current
                val database = AppDatabase.getDatabase(context)
                WatchlistScreen(
                    viewModel = movieViewModel,
                    username = loginViewModel.loggedUser,
                    watchlistDao = database.watchlistDao(),
                    onWatchlistClick = { id, name ->
                        navController.navigate("watchlist_detail/$id/$name")
                    },
                    onBack = { navController.popBackStack() }
                )
            }

            composable(
                route = Screen.WatchlistDetail.route,
                arguments = listOf(
                    androidx.navigation.navArgument("id") { type = androidx.navigation.NavType.IntType },
                    androidx.navigation.navArgument("name") { type = androidx.navigation.NavType.StringType }
                )
            ) { backStackEntry ->
                val watchlistId = backStackEntry.arguments?.getInt("id") ?: 0
                val watchlistName = backStackEntry.arguments?.getString("name") ?: ""
                val context = androidx.compose.ui.platform.LocalContext.current
                val database = AppDatabase.getDatabase(context)

                WatchlistMoviesScreen(
                    viewModel = movieViewModel,
                    watchlistId = watchlistId,
                    watchlistName = watchlistName,
                    watchlistDao = database.watchlistDao(),
                    onMovieClick = { movie ->
                        movieViewModel.selectedMovie = movie
                        movieViewModel.fetchMovieReviews(movie.id)
                        movieViewModel.fetchLocalReviews(movie.id, database.reviewDao())
                        navController.navigate(Screen.Details.route)
                    },
                    onBack = { navController.popBackStack() }
                )
            }
        }
    }
}
