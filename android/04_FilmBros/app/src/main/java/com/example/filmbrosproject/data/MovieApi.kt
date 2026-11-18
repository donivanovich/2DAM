package com.example.filmbrosproject.data

import com.jakewharton.retrofit2.converter.kotlinx.serialization.asConverterFactory
import kotlinx.serialization.Serializable
import kotlinx.serialization.json.Json
import okhttp3.MediaType.Companion.toMediaType
import retrofit2.Retrofit
import retrofit2.http.GET
import retrofit2.http.Path
import retrofit2.http.Query

@Serializable
data class MovieResponse(
    val results: List<Movie>
)
@Serializable
data class Movie(
    val id: Int,
    val title: String,
    val overview: String,
    val poster_path: String?, // Código de la carátula
    val vote_average: Double,
    val release_date: String? = null
)

@Serializable
data class ReviewResponse(
    val results: List<RemoteReview>
)

@Serializable
data class RemoteReview(
    val author: String,
    val content: String
)

interface MovieApiService {
    @GET("3/movie/popular")
    suspend fun getPopularMovies(
        @Query("api_key") apiKey: String,
        @Query("language") language: String = "es-ES",
        @Query("page") page: Int = 1
    ): MovieResponse

    @GET("3/discover/movie") // Usamos discover para filtros avanzados
    suspend fun discoverMovies(
        @Query("api_key") apiKey: String,
        @Query("language") language: String = "es-ES",
        @Query("page") page: Int = 1,
        @Query("sort_by") sortBy: String? = null,
        @Query("with_genres") genreId: String? = null
    ): MovieResponse

    @GET("3/search/movie")
    suspend fun searchMovies(
        @Query("api_key") apiKey: String,
        @Query("query") query: String, // Lo que escribe el usuario
        @Query("language") language: String = "es-ES"
    ): MovieResponse

    @GET("3/movie/{movie_id}/reviews")
    suspend fun getMovieReviews(
        @Path("movie_id") movieId: Int,
        @Query("api_key") apiKey: String,
        @Query("language") language: String = "en-US" // La mayoría están en inglés
    ): ReviewResponse

    @GET("3/movie/{movie_id}")
    suspend fun getMovieDetails(
        @Path("movie_id") movieId: Int,
        @Query("api_key") apiKey: String,
        @Query("language") language: String = "es-ES"
    ): Movie
}

object MovieApiClient {
    private const val BASE_URL = "https://api.themoviedb.org/"

    private val json = Json {
        ignoreUnknownKeys = true // Ignora datos del JSON que no usemos
        coerceInputValues = true
    }

    private val retrofit = Retrofit.Builder()
        .baseUrl(BASE_URL)
        .addConverterFactory(json.asConverterFactory("application/json".toMediaType()))
        .build()

    val service: MovieApiService by lazy {
        retrofit.create(MovieApiService::class.java)
    }
}