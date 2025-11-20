# Ejercicio 1: Contar la frecuencia de caracteres en una cadena
# Pide al usuario que introduzca una cadena de texto y crea un diccionario
# donde las claves sean los caracteres de la cadena y los valores sean
# la frecuencia con la que aparece cada carácter.
# Ejemplo: Si la entrada es "hola", el diccionario debería ser {'h': 1, 'o': 1, 'l': 1, 'a': 1}.
# Ignora espacios y considera mayúsculas y minúsculas como diferentes.
# Imprime el diccionario resultante.

numeros:dict = {
}

cadena:str = input("Introduce una cadena de texto: ")

for i in cadena:
    numeros[i] = cadena.count(i)

print(numeros)

# Ejercicio 2: Combinar dos diccionarios
# Define dos diccionarios con claves y valores.
# Crea un nuevo diccionario que contenga todos los pares clave-valor de ambos
# diccionarios. Si hay claves duplicadas, el valor del segundo diccionario
# debe sobrescribir el valor del primero.
# Imprime el diccionario combinado.

dict1:dict = {
    'nombre' : 'Ivan',
    'apellido' : 'Kosolovskyy'
}

dict2:dict = {
    'nombre' : 'Juan',
    'edad' : '19'
}

for i in dict2:
    dict1[i] = dict2[i]

print(dict1)

# Ejercicio 3: Invertir un diccionario
# Define un diccionario donde las claves son únicas y los valores también son únicos.
# Crea un nuevo diccionario donde las claves sean los valores del diccionario original
# y los valores sean las claves del diccionario original.
# Imprime el diccionario invertido.

dict1:dict = {
    'nombre' : 'Ivan',
    'apellido' : 'Kosolovskyy'
}
dict2:dict = {
}

for i in dict1:
    dict2[dict1[i]] = i

print(dict2)

# Ejercicio 4: Filtrar un diccionario por valor
# Define un diccionario con diferentes tipos de valores (números, strings, booleanos).
# Pide al usuario un tipo de dato (por ejemplo, "int", "str", "bool").
# Crea un nuevo diccionario que contenga solo los pares clave-valor del diccionario
# original donde el valor coincida con el tipo de dato introducido por el usuario.
# Imprime el diccionario filtrado.

datos = {
    "nombre": "Ivan",
    "edad": 19,
    "aprovado": True,
    "altura": 1.85,
    "ciudad": "Madrid",
}

tipo_usuario = input("Introduce un tipo de dato (int, str, bool, float): ")

tipos = {
    "int": int,
    "str": str,
    "bool": bool,
    "float": float
}

if tipo_usuario in tipos:
    tipo_seleccionado = tipos[tipo_usuario]
    
    filtrado = {k: v for k, v in datos.items() if isinstance(v, tipo_seleccionado)}
    
    print("Diccionario:", filtrado)
else:
    print("Tipo no valido, usa: int, str, bool o float")

# Ejercicio 5: Actualizar el valor de una clave
# Define un diccionario con algunas claves y valores iniciales.
# Pide al usuario una clave existente en el diccionario y un nuevo valor.
# Actualiza el valor de la clave especificada con el nuevo valor proporcionado.
# Si la clave no existe, muestra un mensaje indicándolo.
# Imprime el diccionario actualizado.

dicc:dict = {
    'nombre' : 'Ivan',
    'apellido' : 'Kosolovskyy',
    'edad' : 19,
    'aprovado' : True
}

clave:str = input('Dime clave para cambiar su valor: ')
valor = input('Dame valor: ')

if clave in dicc:
    dicc[clave] = valor
    print(dicc)
else:
    print('No existe esa clave.')


# Ejercicio 6: Eliminar una clave de un diccionario
# Define un diccionario con algunas claves y valores.
# Pide al usuario una clave que desea eliminar del diccionario.
# Intenta eliminar la clave del diccionario. Si la clave existe, elimínala
# y muestra el diccionario resultante. Si la clave no existe, muestra un mensaje.

dicc:dict = {
    'nombre' : 'Ivan',
    'apellido' : 'Kosolovskyy',
    'edad' : 19,
    'aprovado' : True
}

clave = input('Dime clave a eliminar: ')

if clave in dicc:
    dicc.pop(clave)
    print(dicc)
else:
    print('No existe esa clave.')

# Ejercicio 7: Verificar la existencia de una clave
# Define un diccionario.
# Pide al usuario una clave para verificar si existe en el diccionario.
# Imprime un mensaje indicando si la clave existe o no en el diccionario.

dicc:dict = {
    'nombre' : 'Ivan',
    'apellido' : 'Kosolovskyy',
    'edad' : 19,
    'aprovado' : True
}

clave = input('Dime clave a verificar: ')

if clave in dicc:
    print('Existe esa clave.')
else:
    print('No existe esa clave.')


# Ejercicio 8: Sumar los valores de un diccionario
# Define un diccionario donde todos los valores son numéricos.
# Calcula la suma de todos los valores del diccionario utilizando un bucle.
# Imprime la suma total.

dictNum:dict = {
    'n1' : 3,
    'n2' : 2,
    'n3' : 1,
    'n4' : 23,
    'n5' : 31,
    'n6' : 22
}

total = 0

for i in dictNum:
    total += dictNum[i]

print(total)

# Ejercicio 9: Encontrar el valor máximo y su clave
# Define un diccionario con valores numéricos.
# Encuentra el valor máximo en el diccionario y la clave asociada a ese valor.
# Si hay múltiples claves con el mismo valor máximo, puedes mostrar cualquiera de ellas.
# Imprime el valor máximo y su clave.

dictNum:dict = {
    'n1' : 3,
    'n2' : 2,
    'n3' : 1,
    'n4' : 23,
    'n5' : 31,
    'n6' : 31
}

mayor = 0
clave:str

for i in dictNum:
    if dictNum[i] > mayor:
        mayor = dictNum[i]
        clave = i

print(clave, mayor)

# Ejercicio 10: Crear un diccionario a partir de dos listas
# Define dos listas: una con nombres de alumnos y otra con sus respectivas calificaciones.
# Crea un diccionario donde las claves sean los nombres de los alumnos y los valores
# sean sus calificaciones correspondientes. Asegúrate de que las listas tengan la misma longitud.
# Imprime el diccionario creado.

diccNombre:dict = {
    'nombre1' : 'Ivan',
    'nombre2' : 'Javier',
    'nombre3' : 'Mario',
    'nombre4' : 'Jorge',
    'nombre5' : 'Sergio'
}

diccNota:dict = {
    'nota1' : 7,
    'nota2' : 5,
    'nota3' : 6,
    'nota4' : 3,
    'nota5' : 10
}

dicc:dict = {
}

for nombre, nota in zip(diccNombre, diccNota):
    dicc[diccNombre[nombre]] = diccNota[nota]

print(dicc)