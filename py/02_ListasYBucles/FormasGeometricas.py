salir = False                                                               # Variable para controlar el bucle principal        

while salir == False:                                                       # Bucle principal
    mensaje = "1. Triangulo\n2. Cuadrado\nX. Salir"                         # Menú de opciones
    print(mensaje)                                                          # Muestra el menú                      
    modo = int(input("---> "))                                              # Solicita la opción al usuario                  

    if modo == 1:                                                           # Opción para dibujar un triángulo     
        altura = int(input("De que altura quieres el triangulo: "))         # Solicita la altura del triángulo         

        for i in range (altura):                                            # Bucle para cada fila del triángulo   
            for i in range (i):                                             # Bucle para imprimir los espacios
                print("* ", end="")                                         # Imprime un asterisco sin salto de línea                 
            print("* ")                                                     # Imprime el asterisco final y salta de línea      
    
    elif modo == 2:                                                         # Opción para dibujar un cuadrado             
        altura = int(input("De que altura quieres el cuadrado: "))          # Solicita la altura del cuadrado        
        base = int(input("De que base quieres el cuadrado: "))              # Solicita la base del cuadrado       

        for i in range (altura):                                            # Bucle para cada fila del cuadrado         
            for i in range (base-1):                                        # Bucle para imprimir los asteriscos en la fila      
                print("* ", end="")                                         # Imprime un asterisco sin salto de línea      
            print("* ")                                                     # Imprime el asterisco final y salta de línea       
    
    else:                                                                   # Opción para salir del programa   
        salir = True                                                        # Cambia la variable para salir del bucle           
        print("Gracias por jugar")                                          # Mensaje de despedida            

