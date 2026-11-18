package com.example.filmbrosproject

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.SystemBarStyle
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.ui.graphics.toArgb
import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import com.example.filmbrosproject.data.AppDatabase
import com.example.filmbrosproject.data.UserRepository
import com.example.filmbrosproject.ui.theme.FilmBrosProjectTheme
import com.example.filmbrosproject.viewmodel.LoginViewModel
import com.example.filmbrosproject.viewmodel.MovieViewModel

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        enableEdgeToEdge(
            statusBarStyle = SystemBarStyle.dark(
                android.graphics.Color.TRANSPARENT,
            ),
            navigationBarStyle = SystemBarStyle.dark(
                android.graphics.Color.TRANSPARENT,
            )
        )
        super.onCreate(savedInstanceState)

        // 1. Inicializamos la base de datos de Room y el repositorio
        val database = AppDatabase.getDatabase(this)
        val repository = UserRepository(database.userDao())

        // 2. Fabricamos el LoginViewModel inyectándole el repositorio
        val loginViewModel = ViewModelProvider(this, object : ViewModelProvider.Factory {
            @Suppress("UNCHECKED_CAST")
            override fun <T : ViewModel> create(modelClass: Class<T>): T {
                return LoginViewModel(repository) as T
            }
        })[LoginViewModel::class.java]

        val movieViewModel = ViewModelProvider(this)[MovieViewModel::class.java]

        setContent {
            FilmBrosProjectTheme {
                // 3. Iniciamos la navegación pasándole el ViewModel ya configurado
                AppNavigation(loginViewModel = loginViewModel, movieViewModel = movieViewModel)
            }
        }
    }
}