package com.example.filmbrosproject.viewmodel

import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.setValue
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.filmbrosproject.data.User
import com.example.filmbrosproject.data.UserRepository
import kotlinx.coroutines.delay
import kotlinx.coroutines.launch

class LoginViewModel(private val repository : UserRepository) : ViewModel() {

    // 1. Variables para guardar lo que el usuario escribe
    var email by mutableStateOf("")
    var password by mutableStateOf("")
    
    // Función para limpiar caracteres no deseados (espacios, saltos de línea)
    private fun cleanInput(input: String): String {
        return input.trim().replace("\n", "").replace("\r", "")
    }

    // 2. Variable para controlar si el login es correcto
    var loginSuccess by mutableStateOf(false)
    var errorMessage by mutableStateOf<String?>(null) // Para avisar si el login falla
    var registroMessage by mutableStateOf<String?>(null)
    var isLoadingLogIn by mutableStateOf(false)
    var isLoadingRegister by mutableStateOf(false)
    // En LoginViewModel.kt
    var loggedUser by mutableStateOf("") // Para guardar el nombre del que entra

    // 3. Función que se ejecuta al pulsar el botón "ENTRAR"
    fun onLoginClick(onFinished: (Boolean) -> Unit) {
        viewModelScope.launch {
            val cleanEmail = cleanInput(email)
            val cleanPassword = cleanInput(password)
            
            if (cleanEmail.isBlank() || cleanPassword.isBlank()) {
                errorMessage = "No se permiten campos vacíos o solo espacios"
                onFinished(false)
                return@launch
            }

            // Limpiamos errores previos antes de empezar
            errorMessage = null
            isLoadingLogIn = true

            delay(1500) // La espera de 1.5s que querías

            val user = repository.getUser(cleanEmail)

            if (user != null && user.password == cleanPassword) {
                // LOGIN CORRECTO
                loggedUser = user.username // <-- AQUÍ guardamos el nombre para AppNavigation
                loginSuccess = true
                isLoadingLogIn = false
                onFinished(true)
            } else {
                // LOGIN INCORRECTO
                isLoadingLogIn = false
                loginSuccess = false
                errorMessage = "Usuario o contraseña incorrectos"
                onFinished(false)
            }
        }
    }

    fun onRegisterClick(onFinished: (String) -> Unit) {
        viewModelScope.launch {
            val cleanEmail = cleanInput(email)
            val cleanPassword = cleanInput(password)

            if (cleanEmail.isBlank() || cleanPassword.isBlank()) {
                registroMessage = "Rellena todos los campos"
                return@launch
            }

            isLoadingRegister = true
            delay(1500) // Mantenemos el efecto visual

            // Un truco más limpio: intentar buscarlo directamente
            val userInDb = repository.getUser(cleanEmail) 

            if (userInDb != null) {
                registroMessage = "El usuario ya existe"
                isLoadingRegister = false
            } else {
                repository.register(cleanEmail, cleanPassword)
                registroMessage = "¡Usuario registrado con éxito!"
                isLoadingRegister = false
                onFinished("Registro OK")
            }
        }
    }

    fun updatePassword(newPassword: String, onFinished: (Boolean) -> Unit) {
        viewModelScope.launch {
            val cleanPass = cleanInput(newPassword)
            if (cleanPass.isBlank()) {
                onFinished(false)
                return@launch
            }
            repository.updateUser(User(username = loggedUser, password = cleanPass))
            onFinished(true)
        }
    }
}