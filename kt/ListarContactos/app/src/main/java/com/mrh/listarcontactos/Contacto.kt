package com.mrh.listarcontactos

import java.math.BigInteger

data class Contacto (
    var nombre: String,
    var apellidos: String,
    var email: String,
    var telefono: BigInteger
)