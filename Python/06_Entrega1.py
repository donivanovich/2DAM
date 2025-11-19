# Ejercicio 1: Solicitar al usuario que introduzca un texto e imprimir por pantalla la cantidad total de caracteres que han sido introducidos
cantidad:int

texto = input("Introduce un texto para hacer el recuento: ")
cantidad = texto.count("")

print("Has introducido", cantidad - 1, "caracteres")

# Ejercicio 2: Solicitar al usuario que introduzca un texto e imprimir por pantalla el mismo texto pero empezando por mayúscula
texto = input("Introduce un texto para imprimir el primer caracter en mayuscula: ")
print(texto.capitalize())

# Ejercicio 3: Solicitar al usuario que introduzca un email e imprimir si tiene el caracter '@' o no 
email = input("Introduce un email para saber si tiene @: ")

try:
    email.index("@")
    print("El email contiene @:")
except Exception:
    print("El email NO contiene @")

# Ejercicio 4: Solicitar al usuario que introduzca un email e imprimir si termina por '@gmail.com' o no
email = input("Introduce un email para saber si termina en '@gmail.com': ")

if email.endswith("@gmail.com"):
    print("El email termina en @gmail.com")
else:
    print("El email NO termina en @gmail.com")

# Ejercicio 5: Solicitar al usuario que introduzca un email e imprimir el email reemplazando '@gmail.com' por '@iepgroup.es'
email = input("Introduce un email para reemplazar '@gmail.com' por '@iepgroup.es': ")

if email.endswith("@gmail.com"):
    print(email.replace("@gmail.com", "@iepgroup.es"))
else:
    print("El email NO termina en @gmail.com")

# Ejercicio 6: Solicitar al usuario que introduzca un nombre y una contraseña. Imprimir 'Administrador' si ha introducido 'admin' - '1234', 
# 'Usuario básico' si ha introducido 'bob' - 'qwerty' o 'Usuario no existe' si no es ninguno de los dos casos anteriores
nombre = input("Introduce un nombre: ")
contraseña = input("Introduce una contraseña: ")

if nombre == "admin" and contraseña == "1234":
    print("Administrador")
elif nombre == "bob" and contraseña == "qwerty":
    print("Usuario básico")
else:
    print("Usuario no existe")