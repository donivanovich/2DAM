# while True:                                   # Bucle infinito
#     try:                                      # Intenta ejecutar el siguiente bloque de código
#         2132312313*321231                     # Operación que puede causar un error   
#         1/0                                   # División por cero, genera una excepción   
#     except:                                   # Si ocurre una excepción, ejecuta este bloque    
#         print('Fallo')                        # Muestra un mensaje de error  

try:                                            # Intenta ejecutar el siguiente bloque de código    
    int('0')                                    # Conversión que puede causar un error     
    raise Exception('Mi Excepcion')             # Lanza una excepción personalizada    
    2/0                                         # División por cero, genera una excepción               
except ZeroDivisionError:                       # Captura la excepción de división por cero
    print('Aprende Matematicas')                # Muestra un mensaje específico
except ValueError as e:                         # Captura la excepción de valor incorrecto             
    print('Aprende a leer', e)                  # Muestra un mensaje específico con el error         
except Exception as e:                          # Captura cualquier otra excepción      
    print('Fallo', e)                           # Muestra un mensaje genérico con el error