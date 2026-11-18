package com.example.filmbrosproject.data

import androidx.room.Dao
import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.PrimaryKey
import androidx.room.Query
import kotlinx.coroutines.flow.Flow

@Entity(
    tableName = "watchlists",
    foreignKeys = [
        ForeignKey(
            entity = User::class,
            parentColumns = ["username"],
            childColumns = ["username"],
            onDelete = ForeignKey.CASCADE
        )
    ]
)
data class WatchlistEntity(
    @PrimaryKey(autoGenerate = true) val id: Int = 0,
    val username: String,
    val name: String
)

@Entity(
    tableName = "watchlist_items",
    primaryKeys = ["watchlistId", "movieId"],
    foreignKeys = [
        ForeignKey(
            entity = WatchlistEntity::class,
            parentColumns = ["id"],
            childColumns = ["watchlistId"],
            onDelete = ForeignKey.CASCADE
        )
    ]
)
data class WatchlistItemEntity(
    val watchlistId: Int,
    val movieId: Int
)

@Dao
interface WatchlistDao {
    @Query("SELECT * FROM watchlists WHERE username = :username")
    fun getWatchlistsForUser(username: String): Flow<List<WatchlistEntity>>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertWatchlist(watchlist: WatchlistEntity): Long

    @Query("UPDATE watchlists SET name = :newName WHERE id = :watchlistId")
    suspend fun renameWatchlist(watchlistId: Int, newName: String)

    @Insert(onConflict = OnConflictStrategy.IGNORE)
    suspend fun addMovieToWatchlist(item: WatchlistItemEntity)

    @Query("SELECT * FROM watchlists WHERE username = :username LIMIT 1")
    suspend fun getFirstWatchlist(username: String): WatchlistEntity?

    @Query("SELECT movieId FROM watchlist_items WHERE watchlistId = :watchlistId")
    fun getMoviesInWatchlist(watchlistId: Int): Flow<List<Int>>

    @Query("DELETE FROM watchlists WHERE id = :watchlistId")
    suspend fun deleteWatchlist(watchlistId: Int)

    @Query("DELETE FROM watchlist_items WHERE watchlistId = :watchlistId AND movieId = :movieId")
    suspend fun removeMovieFromWatchlist(watchlistId: Int, movieId: Int)
}
