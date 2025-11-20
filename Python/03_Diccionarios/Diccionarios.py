persona:dict = {                                    # Diccionario
    'nombre': 'Bob',                                # Clave-Valor      
    'edad': 20                                      # Clave-Valor          
}

persona['nombre'] = 'Alice'                         # Modificar valor
persona['name'] = persona.pop('nombre')             # Renombrar clave
persona['nota'] = 6                                 # Añadir nueva clave-valor
#print(persona)

#print(persona.get('nombre', 'Anonimo'))            # Obtener valor con valor por defecto

for k in persona:
    print(k, persona[k])                            # Iterar claves y valores