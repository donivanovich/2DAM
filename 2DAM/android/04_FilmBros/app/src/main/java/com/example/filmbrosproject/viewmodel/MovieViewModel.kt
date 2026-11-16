package com.example.filmbrosproject.viewmodel

import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.setValue
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.filmbrosproject.data.Movie
import com.example.filmbrosproject.data.MovieApiClient
import com.example.filmbrosproject.data.RemoteReview
import com.example.filmbrosproject.data.ReviewDao
import com.example.filmbrosproject.data.ReviewEntity
import com.example.filmbrosproject.data.WatchlistDao
import com.example.filmbrosproject.data.WatchlistEntity
import com.example.filmbrosproject.data.WatchlistItemEntity
import kotlinx.coroutines.launch
import kotlin.collections.emptyList

class MovieViewModel : ViewModel() {
    var movies by mutableStateOf<List<Movie>>(emptyList())
    var selectedMovie by mutableStateOf<Movie?>(null) //Para la ficha de detalle
    var isLoading by mutableStateOf(false)
    // Reviews que vienen de la api
    var apiReviews by mutableStateOf<List<RemoteReview>>(emptyList())
    // Reviews desde el movil
    var localReviews by mutableStateOf<List<ReviewEntity>>(emptyList())
    var isLoadingReviews by mutableStateOf(false)
    var userAllReviews by mutableStateOf<List<ReviewEntity>>(emptyList())
    //Variables para la pantalla de PELÍCULAS
    var allMovies by mutableStateOf<List<Movie>>(emptyList())
    var currentPage by mutableStateOf(1)
    var isPaginating by mutableStateOf(false)
    // Variables de estado para los filtros
    var selectedGenreId by mutableStateOf<String?>(null)
    var selectedSortBy by mutableStateOf<String?>(null)

    // Watchlist data
    var userWatchlists by mutableStateOf<List<WatchlistEntity>>(emptyList())
    var watchlistMovies by mutableStateOf<List<Movie>>(emptyList())
    var isLoadingWatchlistMovies by mutableStateOf(false)

    private val API_KEY = "b9d5203fdab3db4d4ee4bbcf448e4b8f"

    init {
        fetchMovies()
    }

    // --- WATCHLIST LOGIC ---
    fun fetchWatchlists(username: String, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            watchlistDao.getWatchlistsForUser(username).collect {
                userWatchlists = it
            }
        }
    }

    fun addToWatchlist(movieId: Int, username: String, watchlistDao: WatchlistDao, onResult: (Boolean) -> Unit) {
        viewModelScope.launch {
            try {
                var watchlist = watchlistDao.getFirstWatchlist(username)
                if (watchlist == null) {
                    val newId = watchlistDao.insertWatchlist(
                        WatchlistEntity(username = username, name = "Nueva Lista")
                    )
                    watchlist = WatchlistEntity(id = newId.toInt(), username = username, name = "Nueva Lista")
                }
                watchlistDao.addMovieToWatchlist(WatchlistItemEntity(watchlistId = watchlist.id, movieId = movieId))
                onResult(true)
            } catch (e: Exception) {
                onResult(false)
            }
        }
    }

    fun fetchMoviesInWatchlist(watchlistId: Int, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            isLoadingWatchlistMovies = true
            watchlistDao.getMoviesInWatchlist(watchlistId).collect { ids ->
                val moviesList = mutableListOf<Movie>()
                ids.forEach { id ->
                    try {
                        val movie = MovieApiClient.service.getMovieDetails(id, API_KEY)
                        moviesList.add(movie)
                    } catch (e: Exception) {
                        // Ignorar fallos de una peli individual
                    }
                }
                watchlistMovies = moviesList
                isLoadingWatchlistMovies = false
            }
        }
    }

    fun createWatchlist(username: String, baseName: String, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            val existingNames = userWatchlists.map { it.name }
            var finalName = baseName
            var counter = 1
            
            while (existingNames.contains(finalName)) {
                finalName = "$baseName ($counter)"
                counter++
            }
            
            watchlistDao.insertWatchlist(WatchlistEntity(username = username, name = finalName))
        }
    }

    fun renameWatchlist(watchlistId: Int, newName: String, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            watchlistDao.renameWatchlist(watchlistId, newName)
        }
    }

    fun deleteWatchlist(watchlistId: Int, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            watchlistDao.deleteWatchlist(watchlistId)
        }
    }

    fun removeFromWatchlist(watchlistId: Int, movieId: Int, watchlistDao: WatchlistDao) {
        viewModelScope.launch {
            watchlistDao.removeMovieFromWatchlist(watchlistId, movieId)
        }
    }

    fun deleteReview(reviewId: Int, reviewDao: ReviewDao) {
        viewModelScope.launch {
            reviewDao.deleteReview(reviewId)
        }
    }

    fun updateReview(reviewId: Int, text: String, rating: Double, reviewDao: ReviewDao) {
        viewModelScope.launch {
            reviewDao.updateReview(reviewId, text, rating)
        }
    }

    private fun fetchMovies() {
        viewModelScope.launch {
            isLoading = true
            try {
                // Elegimos una página aleatoria entre 1 y 50 para variar los resultados
                val randomPage = (1..50).random()
                val response = MovieApiClient.service.getPopularMovies(API_KEY, page = randomPage)
                
                // Mezclamos la lista de resultados y cogemos 15
                movies = response.results.shuffled().take(15)
            } catch (e: Exception) {
                // Manejar error de conexión
            } finally {
                isLoading = false
            }
        }
    }

    fun fetchAllMovies(page: Int) {
        viewModelScope.launch {
            isPaginating = true
            try {
                // Pasamos el número de página a la API
                val response = MovieApiClient.service.discoverMovies(
                    apiKey = API_KEY,
                    page = page,
                    sortBy = selectedSortBy,
                    genreId = selectedGenreId
                )
                // TMDB devuelve 20 por defecto, cortamos a 15 como pide tu proyecto
                allMovies = response.results.take(15)
                currentPage = page
            } catch (e: Exception) {
                // Manejar error
            } finally {
                isPaginating = false
            }
        }
    }

    fun fetchMovieReviews(movieId: Int) {
        viewModelScope.launch {
            isLoadingReviews = true
            try {
                val response = MovieApiClient.service.getMovieReviews(movieId, API_KEY)
                apiReviews = response.results
            } catch (e: Exception) {
                apiReviews = emptyList()
            } finally {
                isLoadingReviews = false
            }
        }
    }

    fun fetchAllReviewsByUser(username: String, reviewDao: ReviewDao) {
        viewModelScope.launch {
            // Consultamos todas las reviews donde el autor sea el usuario logueado
            reviewDao.getAllReviewsByUser(username).collect { reviews ->
                userAllReviews = reviews
            }
        }
    }

    //Funcion para el boton enviar reseñas, las guarda.
    fun saveReview(movieId: Int,movieTitle: String , username: String, text: String, rating: Double, reviewDao: ReviewDao) {
        viewModelScope.launch {
            val newReview = ReviewEntity(
                movieId = movieId,
                movieTitle = movieTitle,
                username = username,
                comment = text,
                rating = rating
            )
            reviewDao.insertReview(newReview)
            // Después de guardar, refrescamos la lista local
            //fetchLocalReviews(movieId, reviewDao)
        }
    }

    fun fetchLocalReviews(movieId: Int, reviewDao: ReviewDao) {
        viewModelScope.launch {
            reviewDao.getReviewsForMovie(movieId).collect { reviews ->
                localReviews = reviews
            }
        }
    }

    fun searchMovies(query: String) {
        if (query.isBlank()) return // Si está vacío, no buscamos

        viewModelScope.launch {
            try {
                val response = MovieApiClient.service.searchMovies(API_KEY, query)
                movies = response.results // Actualizamos la lista de la Home con los resultados
            } catch (e: Exception) {
                // Manejar error si no hay internet o falla la API
            }
        }
    }
}
