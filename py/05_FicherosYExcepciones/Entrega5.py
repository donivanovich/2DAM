import os
from datetime import datetime
# ==============================================================
# Ejercicios de Python: Operaciones con Ficheros Locales (2º DAM)
# ================================================================

# --- EJERCICIO 1: ESCRITURA BÁSICA Y CREACIÓN ---
# Crea un programa que solicite al usuario tres (3) líneas de texto.
# Estas líneas deben ser escritas en un nuevo fichero llamado 'datos_iniciales.txt'.
# El fichero debe crearse si no existe. Si ya existe, debe ser sobrescrito.
# Al finalizar, el programa debe confirmar la creación y la ruta del fichero.

linea1:str = input("Frase 1: ")
linea2:str = input("Frase 2: ")
linea3:str = input("Frase 3: ")

fd = open("datos_iniciales.txt", 'w', encoding='utf8')
fd.write(linea1 + '\n' + linea2 + '\n' + linea3)
fd.close


path_base:str = os.path.dirname(os.path.abspath(__file__))

print('Fichero creado, ruta del fichero: ' + path_base)

# --- EJERCICIO 2: LECTURA COMPLETA E IMPRESIÓN ---
# Escribe un programa que lea el contenido completo del fichero 'datos_iniciales.txt' (creado en el Ejercicio 1) 
# y muestre todo su contenido por consola, asegurando que se preservan los saltos de línea originales.
# Si el fichero no existe, debe capturar la excepción y mostrar un mensaje de error.

try:
    with open("datos_iniciales.txt", 'r', encoding='utf8') as archivo:
        for linea in archivo:
            print(linea, end='')
except FileNotFoundError:
    print("Error: El fichero no existe.")

# --- EJERCICIO 3: AÑADIR CONTENIDO (APPEND) ---
# Diseña un programa que añada al final del fichero 'datos_iniciales.txt':
# 1. Una nueva línea con el texto: "--- Fin de la cabecera ---"
# 2. La fecha y hora actual en la siguiente línea (utiliza el módulo 'datetime').
# El contenido original del fichero NO debe modificarse.

ahora:str = str(datetime.now())
fd = open('datos_iniciales.txt', 'a', encoding='utf8')
fd.write('\n--- Fin de la cabecera ---\n')
fd.write(ahora + "\n")
fd.close()

# --- EJERCICIO 4: LECTURA LÍNEA POR LÍNEA Y PROCESAMIENTO ---
# Desarrolla un programa que lea el fichero 'datos_iniciales.txt' línea por línea.
# Por cada línea leída:
# 1. Muestra la línea en consola, precedida por su número (empezando en 1).
# 2. Cuenta el número de caracteres (incluyendo espacios) de esa línea.
# 3. Muestra el conteo de caracteres.

with open("datos_iniciales.txt", 'r', encoding='utf8') as archivo:
    for linea in archivo:
        print(linea, linea.count('') - 2)

# --- EJERCICIO 5: COPIA DE FICHERO Y MODIFICACIÓN EN MEMORIA ---
# Crea un programa que realice las siguientes acciones:
# 1. Lee todas las líneas del fichero 'datos_iniciales.txt' en una lista en memoria.
# 2. Modifica la TERCERA línea de la lista para que diga: "Esta línea ha sido modificada por el programa."
# 3. Escribe el contenido COMPLETO de la lista (con la línea modificada) en un NUEVO fichero llamado 'datos_modificados.txt'.

with open("datos_iniciales.txt", "r", encoding="utf8") as archivo:
    lineas = archivo.readlines()

if len(lineas) >= 3:
    lineas[2] = "Esta línea ha sido modificada por el programa.\n"

with open("datos_modificados.txt", "w", encoding="utf8") as archivo_modificado:
    archivo_modificado.writelines(lineas)

# --- EJERCICIO 6: ALMACENAMIENTO DE OBJETOS (LISTA DE DICCIONARIOS) ---
# Crea un programa que:
# 1. Defina una lista con 3 diccionarios, donde cada diccionario representa un alumno y contenga las claves: 'nombre', 'apellido' y 'nota'.
# 2. Escriba esta lista de diccionarios en un fichero llamado 'alumnos.txt'.

diccionarios:list = [
    {"nombre": "Raul", "apellido": "Alvarez", "nota": 9},
    {"nombre": "Luis", "apellido": "Nogales", "nota": 7},
    {"nombre": "Marta", "apellido": "Diaz", "nota": 5}
]

with open("alumnos.txt", "w", encoding="utf8") as fd:
    for alumno in diccionarios:
        fd.write(f"{alumno['nombre']}, {alumno['apellido']}, {alumno['nota']}\n")

# --- EJERCICIO 7: LECTURA Y DESERIALIZACIÓN DE OBJETOS ---
# Crea un programa que:
# 1. Lea el contenido del fichero 'alumnos.txt' (creado en el Ejercicio 6).
# 2. Deserialice el contenido para obtener la lista de diccionarios original.
# 3. Itere sobre la lista e imprima el nombre y la nota de cada alumno en un formato legible.

alumnos = []

with open("alumnos.txt", "r", encoding="utf8") as fd:
    for linea in fd:
        nombre, apellido, nota = linea.strip().split(", ")
        alumnos.append({
            "nombre": nombre,
            "apellido": apellido,
            "nota": int(nota)
        })

for alumno in alumnos:
    print(f"Nombre: {alumno['nombre']} | Nota: {alumno['nota']}")

# --- EJERCICIO 8: REEMPLAZO DE CONTENIDO CON SOBREESCRITURA CONDICIONAL ---
# Crea un programa que pida al usuario una palabra antigua y una palabra nueva.
# El programa debe:
# 1. Leer el contenido completo del fichero 'datos_modificados.txt' en una variable.
# 2. Reemplazar TODAS las ocurrencias de la 'palabra antigua' por la 'palabra nueva' en la variable.
# 3. Preguntar al usuario: "¿Desea guardar los cambios? (s/n)".
# 4. Si la respuesta es 's', sobrescribe el fichero 'datos_modificados.txt' con el nuevo contenido. Si es 'n', no hace nada.

antigua = input("Dame palabra antigua: ")
nueva = input("Dame palabra nueva: ")

with open("datos_modificados.txt", "r", encoding="utf8") as archivo:
    contenido = archivo.read()

contenido_modificado = contenido.replace(antigua, nueva)

respuesta = input("Desea guardar los cambios? (s/n): ")

if respuesta.lower() == 's':
    with open("datos_modificados.txt", "w", encoding="utf8") as archivo:
        archivo.write(contenido_modificado)
    print("Cambios guardados")
else:
    print("No se realizaron cambios")

# --- EJERCICIO 9: GESTIÓN DE ERRORES Y LIMPIEZA DE FICHEROS ---
# Escribe una función llamada 'limpiar_fichero' que acepte un nombre de fichero.
# La función debe:
# 1. Intentar abrir y escribir una única línea: "Fichero limpiado en: [Fecha y Hora Actual]".
# 2. Si el fichero existe, lo sobrescribe.
# 3. Si ocurre un error (ej. permisos), debe capturar el error, imprimir un mensaje de error y devolver 'False'.
# 4. Si la operación es exitosa, debe devolver 'True'.

def limpiar_fichero(nombre_fichero):
    try:
        with open(nombre_fichero, "w", encoding="utf8") as archivo:
            fecha_hora = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
            archivo.write(f"Fichero limpiado en: {fecha_hora}\n")
        return True
    except Exception as e:
        print(f"Error al limpiar el fichero: {e}")
        return False

# --- EJERCICIO 10: CONTADOR DE PALABRAS EN UN FICHERO GRANDE ---
# Desarrolla un programa que:
# 1. Escriba un texto de al menos 5 líneas y 20 palabras en un fichero llamado 'texto_grande.txt'.
# 2. Luego, lea ese fichero y cuente el número total de palabras (separadas por espacios) que contiene.
# 3. Muestre el conteo final de palabras.

texto = """Este es un archivo de ejemplo
que contiene varias líneas de texto
para demostrar el conteo de palabras.
Cada línea añade más palabras aquí,
asegurando que hay al menos veinte"""

with open("texto_grande.txt", "w", encoding="utf8") as archivo:
    archivo.write(texto)

with open("texto_grande.txt", "r", encoding="utf8") as archivo:
    contenido = archivo.read()
    palabras = contenido.split()
    total_palabras = len(palabras)

print(f"El número total de palabras en el fichero es: {total_palabras}")