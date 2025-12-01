texto:str = 'hola que tal'                              # Definimos una variable de tipo string                 

print(texto.capitalize())                               # (.capitalize) convierte la primera letra en mayuscula

print(texto.count("a", 5, 7))                           # (.count) cuenta las "a" que hay entre las posiciones 5 y 7

print(texto.endswith("tal"))                            # (.endwith) devuelve True o False si el texto termina con "tal"

print(texto.find("m", 4, 12))                           # (.find) devuelve la posicion de la primera "a" que encuentra a partir de la posicion 4 hasta la 12 pero devuelve -1 si no la encuentra

print(texto.index("a", 4, 12))                          # (.index) devuelve la posicion de la primera "a" que encuentra a partir de la posicion 4 hasta la 12 pero devuelve un error si no la encuentra

try:                                                    # El uso de try y except es para evitar que el programa se detenga si hay un error
    print(texto.index("m", 4, 12))                      # Intentamos ejecutar el codigo que puede dar error
except Exception:                                       # Si da error, se ejecuta el codigo dentro del except             
    print("No se ha encontrado la letra")               # El uso de try y except es para evitar que el programa se detenga si hay un error