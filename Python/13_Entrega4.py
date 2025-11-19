# Ejercicio 1: Hacer una función que reciba un parámetro 
# de tipo str, solicite al usuario que introduzca un texto 
# usando como prompt el parámetro recibido y devuelva el texto 
# leído

cadena:str = 'Dame texto: '

def leido(s:str): 
    return input(cadena)

print(leido(cadena))

# Ejercicio 2: Hacer otra función similar a la anterior pero 
# el usuario debe introducir un número. Se pedirá al usuario 
# introducir el número constantemente hasta que escriba un
# número valido. 

def leer_numero(cadena: str) -> float:
    while True:
        entrada = input(cadena)
        try:
            numero = float(entrada)
            return numero
        except ValueError:
            print("Debes introducir un numero valido")

print(leer_numero("Introduce un numero: "))

# Ejercicio 3: Hacer una función que reciba 2 números y 
# devuelva el primer número elevado al segundo. El segundo
# es opcional, si no se pasa se debe elevar al cuadrado

def elevado(num, pot:int = 2) -> float:
    return num ** pot

print(elevado(3, 3))

# Ejercicio 4: Escribe una función que tome una lista de números como entrada
# y devuelva la suma de todos los elementos de la lista.

numeros:list = [2, 3, 4, 2, 8, 43, 57]

def sumarLista(n:list) -> int:
    return sum(n)

print(sumarLista(numeros))

# Ejercicio 5: Hacer una función que tome una lista de números como entrada
# y devuelva el número mayor por defecto o el menor si se indica
# en un parámetro de la función

numeros:list = [211, 3, 4, 2, 8, 43, 57]

def mayorMenor(n:list, tipo:bool) -> int:
    if tipo == True:
        mayor = max(n)
        return mayor
    menor = min(n)
    return menor    

print(mayorMenor(numeros, True))

# Ejercicio 6: Hacer una función que tome una lista de palabras
# como entrada y devuelva la(s) palabra(s) más larga(s).
# Nota: puede haber varias palabras con la misma longitud.

palabras:list = ["pala", "pala", "dw", "dw"]

def palabraLarga(p:list) -> str:
    max_len = max(len(palabra) for palabra in p)
    return str([palabra for palabra in p if len(palabra) == max_len])

print(palabraLarga(palabras))

# Ejercicio 7: Hacer una función que tome un número entero como
# entrada y devuelva una lista que contenga los cuadrados
# de todos los números enteros desde 1 hasta el número dado.

def listaCuadrados(n:int) -> list:
    lista:list = []

    for i in range (1, n):
        lista.insert(i, n ** i) 
    return lista

print(listaCuadrados(5))

# Ejercicio 8: Hacer una función que tome un lista de números y
# devuelva otra lista con los números pares de la primera.
# O los impares si se indica por parámetro.

numeros:list = [211, 3, 4, 2, 8, 43, 57]

def listaPares(n:list, tipo:bool) -> list:
    if tipo:
        # Devolver solo los pares
        return [num for num in n if num % 2 == 0]
    else:
        # Devolver solo los impares
        return [num for num in n if num % 2 != 0]

print(listaPares(numeros, False))

# Ejercicio 9: Hacer una función que reciba un entero y devuelva su factorial.
def factorial(n: int) -> int:
    if n < 0:
        return 0
    
    resultado = 1
    for i in range(1, n + 1):
        resultado *= i
    return resultado

print(factorial(5))

# Ejercicio 10: Hacer una función que reciba un entero y devuelva su factorial de forma recursiva.
def factorialR(n: int) -> int:
    if n < 0:
        return 0
    elif n == 0 or n == 1:
        return 1
    else:
        return n * factorialR(n - 1)

print(factorialR(5))