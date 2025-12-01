import requests, os                                                                 # Asegúrate de tener instalada la librería requests

path_base:str = os.path.dirname(os.path.abspath(__file__))                          # Directorio del script actual

response = requests.get('https://google.com')                                       # Realiza la solicitud GET
print(response.status_code)                                                         # Imprime el código de estado HTTP

print(response.ok)                                                                  # Imprime si la solicitud fue exitosa

if response.ok:                                                                     # Si la solicitud fue exitosa
    with open(f'{path_base}/google.html', 'w', encoding=response.encoding) as fd:   # Abre un archivo para escribir
        fd.write(response.text)                                                     # Escribe el contenido de la respuesta en el archivo
