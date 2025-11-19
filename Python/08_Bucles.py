i:int = 1                                       # Inicializa la variable i

while i < 10:                                   # Bucle mientras i sea menor que 10               
    i += 1                                      # Incrementa i en 1                
    
    if i == 5:                                  # Si i es igual a 5 
        continue                                # Salta el resto del código y vuelve al inicio del bucle      
    
    if i == 7:                                  # Si i es igual a 7           
        break                                   # Sale del bucle          
    #print(i, end= ' - ')                       # Muestra el valor de i       
    
letras:list[str] = ['a', 'b', 'c', 'd']         # Lista de letras   

#for l in letras:                               # Bucle para cada letra en la lista        
    #print(l, end=' - ')                        # Muestra la letra actual      

for n in range(10):                             # Bucle para n desde 0 hasta 9             
    print(n, end=' - ')                         # Muestra el valor de n        