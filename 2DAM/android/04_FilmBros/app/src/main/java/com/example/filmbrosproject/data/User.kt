package com.example.filmbrosproject.data

import androidx.room.Entity
import androidx.room.PrimaryKey

//Tabla para que haya usuarios
@Entity(tableName = "users")
data class User(
    @PrimaryKey val username: String,
    val password: String
)