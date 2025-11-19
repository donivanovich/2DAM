# Usando la API WEB: https://jsonplaceholder.typicode.com/
# Hacer un script que genere un archivo html con una lista. 
# Por cada usuario de la API se creará un elemento de la lista mostrando su nombre y 
# enlazando a su sitio web y otro enlace a Google Maps que cargue en la localización del usuario.
# Se adjunta un ejemplo del archivo que tiene que generar

import os
import requests

response = requests.get("https://jsonplaceholder.typicode.com/users")
usuarios = response.json()

path_base = os.path.dirname(os.path.abspath(__file__))
with open(f'{path_base}/index.html', 'w', encoding='utf8') as fd:
    fd.write('''<html>
<body>
<ul>
''')

    for usuario in usuarios:
        name = usuario["name"]
        website = usuario["website"]
        lat = usuario["address"]["geo"]["lat"]
        lng = usuario["address"]["geo"]["lng"]

        fd.write(f'''<li><a target="_blank" href="http://{website}">{name}</a> (<a target="_blank" href="https://www.google.com/maps?q={lat},{lng}">Mapa</a>)</li>
''')

    fd.write('''</ul>
</body>
</html>
''')
