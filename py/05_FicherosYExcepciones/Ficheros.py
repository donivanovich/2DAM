import os                                                               # Libreria para manejar rutas y ficheros

print(os.path.abspath(__file__))                                        # Muestra la ruta absoluta del fichero actual
exit()                                                                  # Salir del programa        

path_base:str = os.path.dirname(os.path.abspath(__file__))              # Directorio del fichero actual       

path:str = 'D:\\Mi unidad\\2DAM\\Python>'                               # Ruta absoluta ejemplo        

# fd = open('persona.txt', 'w', encoding='utf8')                        # Abre (o crea) el fichero en modo escritura        
# fd.write('Alice Smith')                                               # Escribe en el fichero                  
# fd.close()                                                            # Cierra el fichero            

# with open('persona.txt', 'w', encoding='utf8') as fd:                 # Esto es para evitar olvidar el close
#     fd.write('Alice Smith')                                           # Escribe en el fichero        

# with open('persona.txt', 'r', encoding='utf8') as fd:                 # Abre el fichero en modo lectura    
#     texto:str = fd.read()                                             # Lee el contenido del fichero

# with open('persona.txt', 'w', encoding='utf8') as fd:                 # Abre el fichero en modo escritura
#     fd.write(texto + '\n' + 'Alice Smith')                            # Escribe en el fichero

with open(f'{path_base}/persona.txt', 'a', encoding='utf8') as fd:      # Abre el fichero en modo añadir (append)
    fd.write('Alice Smith')                                             # Escribe en el fichero        