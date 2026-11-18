package com.example.filmbrosproject.data

import androidx.room.Dao
import androidx.room.Entity
import androidx.room.Insert
import androidx.room.PrimaryKey
import androidx.room.Query
import kotlinx.coroutines.flow.Flow

@Entity(tableName = "reviews")
data class ReviewEntity(
    @PrimaryKey(autoGenerate = true) val id: Int = 0,
    val movieId: Int,
    val movieTitle: String,
    val username: String,
    val comment: String,
    val rating: Double
)

// Las instrucciones
@Dao
interface ReviewDao {
    @Query("SELECT * FROM reviews WHERE movieId = :movieId ORDER BY id DESC")
    fun getReviewsForMovie(movieId: Int): Flow<List<ReviewEntity>>

    @Query("SELECT * FROM reviews WHERE username = :username ORDER BY id DESC")
    fun getAllReviewsByUser(username: String): Flow<List<ReviewEntity>>
    @Insert
    suspend fun insertReview(review: ReviewEntity)

    @Query("UPDATE reviews SET comment = :text, rating = :rating WHERE id = :reviewId")
    suspend fun updateReview(reviewId: Int, text: String, rating: Double)

    @Query("DELETE FROM reviews WHERE id = :reviewId")
    suspend fun deleteReview(reviewId: Int)
}