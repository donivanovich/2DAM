package com.mrh.listarcontactos.ui.components

import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.mrh.listarcontactos.Contacto
import com.mrh.listarcontactos.R
import java.math.BigInteger

@Composable
fun AppNavigation(modifier: Modifier = Modifier) {
    val navController = rememberNavController()

    val contactos = remember {
        mutableStateListOf(
            Contacto(
                "Vinicius",
                "Rios",
                "mario.rios@iepgroup.es",
                BigInteger("1234567"),
                R.drawable.vini
            ),
            Contacto("Ana", "García", "ana.garcia@email.com", BigInteger("9876543")),
            Contacto("Marta", "", "marta@mail.com", BigInteger("6000000000"))
        )
    }

    NavHost(navController, startDestination = "lista", modifier) {
        composable("lista") {
            ContactosList(
                contactos,
                onItemClick = { contacto ->
                    navController.navigate("detalle/${contacto.nombre}")
                },
                modifier = Modifier.fillMaxSize()
            )
        }

        composable("detalle/{nombre}") { backStackEntry ->
            val nombre = backStackEntry.arguments?.getString("nombre") ?: ""
            val contacto = contactos.find { it.nombre == nombre } ?: contactos[0]
            DetalleContacto(contacto)
        }
    }
}