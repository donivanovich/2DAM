nombre = input("Cual es tu nombre? ")                                                               # Pide al usuario su nombre
edad = int(input("Cual es tu edad? "))                                                              # Pide al usuario su edad y la convierte a entero             

numero1:int = 20                                                                                    # Declara una variable de tipo entero
numero = 10 + numero1                                                                               # Suma dos enteros y asigna el resultado a 'numero'                       

print("(" + str(numero) + ") Buenos dias, " + nombre + " tienes", edad, "años.")                    # Si pones sep="-", cambia los espacios que genera la concatenacion con , de " "

print(f"Hola {nombre}! Tienes {edad} años")                                                         # Con el f del principio convierte todas las variables a string

print(type(numero))                                                                                 # Imprime el tipo de dato de la variable deseada