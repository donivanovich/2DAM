package com.mrh.listarcontactos.ui.components

import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import com.mrh.listarcontactos.Contacto
import com.mrh.listarcontactos.R
import java.math.BigInteger


@Composable
fun MainView(modifier: Modifier = Modifier) {

    val listaContactos = remember {
        mutableStateListOf(
            Contacto(
                nombre = "Vinicius",
                apellido = "Rios",
                mail = "mario.rios@iepgroup.es",
                telefono = BigInteger("1234567"),
                imagenId = R.drawable.vini
            ),
            Contacto(
                nombre = "Ana",
                apellido = "García",
                mail = "ana.garcia@email.com",
                telefono = BigInteger("9876543")
            ),
            Contacto(
                nombre = "Pedro",
                apellido = "López",
                mail = "pedro.lopez@email.com",
                telefono = BigInteger("5556667")
            )
        )
    }

    ContactosList(listaContactos, modifier)


}

@Composable
fun ContactosList(contactos: List<Contacto>, modifier: Modifier = Modifier){
    LazyColumn(modifier = modifier) {

        items(contactos){ contacto ->
            ContactoRowCard(contacto)
        }
    }
}