package com.example.filmbrosproject.ui.components

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.filmbrosproject.R
import com.example.filmbrosproject.viewmodel.LoginViewModel
import androidx.compose.animation.core.animateFloatAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.graphics.graphicsLayer

@Composable
fun LoginScreen(viewModel: LoginViewModel, onLoginSuccess: () -> Unit) {
    val isLoaderLogIn = viewModel.isLoadingLogIn
    val isLoaderRegister = viewModel.isLoadingRegister


    //TODO
    // Configuración de escala para el efecto de "hacerse más grande"
    val scaleLogin by animateFloatAsState(if (isLoaderLogIn) 0.95f else 1f)

    Box(modifier = Modifier.fillMaxSize()) {
        Image(
            painter = painterResource(R.drawable.background),
            contentDescription = null,
            modifier = Modifier.fillMaxSize(),
            contentScale = ContentScale.Crop
        )

        Column(
            modifier = Modifier.fillMaxSize().padding(horizontal = 40.dp),
            horizontalAlignment = Alignment.CenterHorizontally,
            verticalArrangement = Arrangement.Center
        ) {
            Image(
                painter = painterResource(R.drawable.logoproyecto),
                contentDescription = "Logo",
                modifier = Modifier.height(80.dp).padding(bottom = 40.dp)
            )

            // Campos de texto (Usuario y Contraseña) igual que los tenías...
            Text("Usuario:", color = Color.White, fontSize = 18.sp, modifier = Modifier.align(Alignment.Start))
            OutlinedTextField(
                value = viewModel.email,
                onValueChange = { newValue ->
                    if (!newValue.contains("\n")) viewModel.email = newValue 
                },
                modifier = Modifier.fillMaxWidth().height(56.dp),
                shape = RoundedCornerShape(15.dp),
                singleLine = true,
                colors = OutlinedTextFieldDefaults.colors(focusedTextColor = Color.White, unfocusedTextColor = Color.White)
            )

            Spacer(modifier = Modifier.height(20.dp))

            Text("Contraseña:", color = Color.White, fontSize = 18.sp, modifier = Modifier.align(Alignment.Start))
            OutlinedTextField(
                value = viewModel.password,
                onValueChange = { newValue ->
                    if (!newValue.contains("\n")) viewModel.password = newValue
                },
                modifier = Modifier.fillMaxWidth().height(56.dp),
                visualTransformation = PasswordVisualTransformation(),
                shape = RoundedCornerShape(15.dp),
                singleLine = true,
                colors = OutlinedTextFieldDefaults.colors(focusedTextColor = Color.White, unfocusedTextColor = Color.White)
            )

            // Mostramos el error solo si existe
            if (viewModel.errorMessage != null) {
                Text(
                    text = viewModel.errorMessage!!,
                    color = Color(0xFFE00000), // Un rojo que resalte sobre el oscuro
                    fontSize = 14.sp,
                    fontWeight = FontWeight.Medium,
                    modifier = Modifier.padding(bottom = 10.dp)
                )
            }else if(viewModel.registroMessage != null){
                Text(
                    text = viewModel.registroMessage!!,
                    color = Color.White,
                    fontSize = 14.sp,
                    fontWeight = FontWeight.Medium,
                    modifier = Modifier.padding(bottom = 10.dp)
                )
            }

            Spacer(modifier = Modifier.height(60.dp))

            // FILA DE BOTONES CORREGIDA
            Row(
                modifier = Modifier.fillMaxWidth(),
                horizontalArrangement = Arrangement.SpaceEvenly,
                verticalAlignment = Alignment.CenterVertically
            ) {
                // Botón Iniciar Sesión
                Button(
                    onClick = {
                        viewModel.onLoginClick { success ->
                            if (success) onLoginSuccess()
                        }
                    },
                    enabled = !isLoaderLogIn,
                    shape = RoundedCornerShape(25.dp),
                    colors = ButtonDefaults.buttonColors(
                        containerColor = Color.White,
                        disabledContainerColor = Color.Gray
                    ),
                    modifier = Modifier
                        .weight(1f)
                        .height(55.dp) // Altura fija igualada
                        .padding(end = 8.dp)
                        .graphicsLayer(scaleX = scaleLogin, scaleY = scaleLogin) // Efecto de escala
                ) {
                    if (isLoaderLogIn) {
                        CircularProgressIndicator(modifier = Modifier.size(20.dp), color = Color.Black, strokeWidth = 2.dp)
                    } else {
                        Text("Entrar", color = Color.Black, fontWeight = FontWeight.Bold)
                    }
                }

                // Botón Registrarse
                Button(
                    onClick = {
                        viewModel.onRegisterClick { mensaje ->
                            // Aquí podrías mostrar un aviso de éxito si quisieras
                            println(">>> $mensaje")
                        }
                    },
                    enabled = !isLoaderRegister, // Se bloquea si el otro está cargando
                    shape = RoundedCornerShape(25.dp),
                    colors = ButtonDefaults.buttonColors(
                        containerColor = Color.White,
                        disabledContainerColor = Color.Gray
                    ),
                    modifier = Modifier
                        .weight(1f)
                        .height(55.dp)
                        .padding(start = 8.dp)
                ) {
                    if (isLoaderRegister) {
                        CircularProgressIndicator(modifier = Modifier.size(20.dp), color = Color.Black, strokeWidth = 2.dp)
                    } else {
                        Text("Registrarse", color = Color.Black, fontWeight = FontWeight.Bold)
                    }
                }
            }
        }
    }
}