# 1- Pide al usuario que introduzca tres números. 
#  Utiliza condicionales para determinar cuál de los tres es el mayor y muéstralo por pantalla. 

n1:int = int(input("Dame el numero 1: "))
n2:int = int(input("Dame el numero 2: "))
n3:int = int(input("Dame el numero 3: "))

mayor:int = n1

if n2 > mayor:
    mayor = n2
if n3 > mayor:
    mayor = n3

print("El mayor numero es: ", mayor)

# 2- Solicita al usuario un número entero. 
#  Utiliza un bucle for para imprimir la tabla de multiplicar de ese número del 1 al 10.

multiplo:int = int(input("Dame un numero para multiplicar: "))

for i in range(1, 11):
    print(multiplo * i, end= ", ")

# 3- Crea una lista vacía llamada lista_compra. 
# Pide al usuario que introduzca artículos para añadir a la lista. 
# Permite al usuario añadir elementos hasta que escriba "fin". Finalmente, imprime la lista de la compra.

lista_compra:list = []

while True:
    articulo = input("Añadir un articulo: ")
    if articulo == "fin":
        break
    else:
        lista_compra.append(articulo)

print(lista_compra)

# 4- Define una palabra secreta. 
# Pide al usuario que intente adivinar la palabra. 
# Dale pistas (por ejemplo, la primera letra) si falla. 
# Permite un número limitado de intentos. Usa un bucle while y condicionales para controlar el juego.

palabra_secreta:str = "paloma"
veces:int = 1

while True:
    palabra:str = input("Introduce una palabra para adivinar: ")

    if palabra_secreta == palabra:
        print("Enhorabuena la palabra era", palabra_secreta)
        break

    if veces == 1:
        print("p-----")
    elif veces == 2:
        print("p----a")
    elif veces == 3:
        print("p-l--a")
    elif veces == 4:
        print("Has perdido. La palabra era paloma")
        break
    veces+=1

# 5- Pide al usuario que introduzca una serie de números separados por espacios. 
# Convierte la entrada en una lista de números. 
# Utiliza un bucle for y un condicional para calcular la suma de todos los números pares en la lista. 
# Imprime la suma.

numeros:list = []
suma:int = 0

while len(numeros) < 5:
    numeros.append(int(input("Dame un numero: ")))

for i in range(5):
    suma += numeros[i]

print("El total es:", suma)

# 6- Pide al usuario que introduzca una frase. 
# Utiliza un bucle for para recorrer la frase y cuenta cuántas vocales (a, e, i, o, u) contiene. 
# Imprime el número total de vocales.

frase:str = input("Dame frase: ").lower()
vocales:int = 0

for i in range(len(frase)):
    if frase[i] in "aeiou":
        vocales += 1

print("Vocales:", vocales)

# 7- Pide al usuario un número entero positivo. 
# Utiliza un bucle for y condicionales para determinar si el número es primo o no. 
# Imprime el resultado. (Un número primo solo es divisible por 1 y por sí mismo).

numero:int = int(input("Dame numero positivo: "))
es_primo:bool = True

if numero > 0:
    for i in range(2, numero - 1):
        if numero % i == 0:
            print("El numero no es primo")
            es_primo = False
            break
    if es_primo == True:
        print("El numero es primo")
else:
    print("Numero negativo")

# 8- Crea una lista vacía llamada tareas. Permite al usuario realizar las siguientes acciones:
# Añadir una tarea (usando input y .append()).
# Mostrar todas las tareas (usando un bucle for).
# Salir del programa.
# Utiliza un bucle while para mantener el programa en funcionamiento hasta que el usuario decida salir

tareas:list = []
modo:int = 1

while True:
    print("1. Añadir una tarea")
    print("2. Mostrar todas las tareas")
    print(">=3. Salir del programa")

    modo = int(input(""))

    if modo == 1:
        tarea:str = input("Cual tarea deseas añadir? ")
        tareas.append(tarea)
    elif modo == 2:
        if len(tareas) == 0:
            print("No hay tareas todavia")
        else:
            for i in range(len(tareas)):
                print("Tarea", i + 1, ":", tareas[i])
    else:
        print("Saliendo del programa")
        break

# 9- Genera un número aleatorio entre 1 y 100 (puedes usar el módulo random). 
# Pide al usuario que adivine el número. Dale pistas si el número es mayor o menor. 
# Cuenta el número de intentos que necesita el usuario hasta acertar. Usa un bucle while y condicionales.

import random

rng:int = 0
intento:int = 0
veces:int = 0
rng = random.randint(1, 100)

while True:
    veces+=1
    intento = int(input("Numero: "))

    if rng == intento:
        print("Enhorabuena has adivinado el numero")
        break
    else:
        if intento > rng:
            print("El numero es menor a", intento)
        elif intento < rng:
            print("El numero es mayor a", intento)
print("Numero de intentos:", veces)

# 10- Pide al usuario que introduzca una cadena de texto. 
# Utiliza un bucle for para recorrer la cadena e imprimirla en orden inverso.

cadena:str = input("Dame cadena de texto: ")

for i in range(len(cadena) - 1 , -1, -1):
    print(cadena[i], end="")