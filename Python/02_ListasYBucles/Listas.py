# letras:list = ['a', 'b', 'c', 1, 2, 3, True, 0.1] 
# Se puede mezclar tipos de datos pero no es recomendable

letras:list = ['a', [1, 2, 3], 'b', 'c', 'a', 'a']              # Lista de strings
letras[1] = 'z'                                                 # Cambia el valor de la posición 1

print(letras[1])                                                # Imprime el valor de la posición 1

letras.append('y')                                              # Esta función añade un elemento al final de la lista
letras.insert(0, 'q')                                           # Esta función añade un elemento en la posición que le digamos
letras.clear()                                                  # Esta función borra todos los elementos de la lista
letras = []                                                     # Otra forma de borrar todos los elementos de la lista

letras.count('a')                                               # Esta función cuenta cuántas veces aparece un elemento en la lista
print(len(letras))                                              # Esta función cuenta cuántos elementos hay en la lista
print(letras.index('a'))                                        # Esta función devuelve la posición del primer elemento que le digamos

letras.pop()                                                    # Esta función borra el último elemento de la lista
letras.remove('a')                                              # Esta función borra la primera aparición del elemento que le digamos
letras.sort(reverse=True)                                       # Esta función ordena los elementos de la lista (solo si son del mismo tipo) en orden inverso por el parámetro reverse=True
letras.reverse()                                                # Esta función invierte el orden de los elementos de la lista
copia:list = letras.copy()                                      # Esta función crea una copia de la lista
copia[0] = 'xxxxxx'                                             # Cambia el valor de la posición 0 de la copia
letras.extend(copia)                                            # Esta función añade los elementos de la lista que le digamos al final de la lista original
copia[1][0] = 9                                                 # Cambia el valor del primer elemento de la lista que está en la posición 1 de la copia
nueva = letras + copia                                          # Esta forma crea una nueva lista con los elementos de las dos listas

print('original', letras)                                       # Imprime la lista original 
print('copia', copia)                                           # Imprime la copia de la lista                      
print('nueva', nueva)                                           # Imprime la nueva lista                  
print('a' in letras)                                            # Esta función devuelve True si el elemento está en la lista y False si no lo está
print(letras[1:4])                                              # Esta función devuelve una sublista desde la posición 1 hasta la 4 (sin incluir la 4)
print(letras[6:1:-1])                                           # Esta función devuelve una sublista desde la posición 6 hasta la 1 (sin incluir la 1) en orden inverso

copia = letras[::-1]                                            # Esta función crea una copia de la lista en orden inverso
print(copia)                                                    # Imprime la copia de la lista