import requests, json

API_BASE = "https://jsonplaceholder.typicode.com/"

# 1 Haz una funcion que devuelva cuantos usuarios hay.
def ejercicio1():
    usuarios = requests.get(f'{API_BASE}users') .json()                                          # Convierte la respuesta a JSON
    return len(usuarios)                                                # Devuelve la cantidad de usuarios

print("Ejercicio1:", ejercicio1())


# 2 Haz una funcion que devuelva el id 
# del usuario con email "Sincere@april.biz"
def ejercicio2():
    usuarios = requests.get(f'{API_BASE}users').json()                                          # Convierte la respuesta a JSON
    for i in usuarios:                                                  # Itera sobre los usuarios
        if i["email"] == "Sincere@april.biz":                           # Verifica el email
            return i["id"]                                              # Devuelve el ID del usuario
        else:
            return "No se encontro el usuario con ese email"

print("Ejercicio2:", ejercicio2())


# 3 Haz una funcion que devuelva el numero de comentarios 
# que tiene el primer post del usuario 'Antonette'
def ejercicio3():                                                       # Realiza la solicitud GET
    usuarios = requests.get(f'{API_BASE}users')  .json()                                                                                  # Convierte la respuesta a JSON
    for i in usuarios:                                                                                          # Itera sobre los usuarios
        if i["username"] == "Antonette":                                                                        # Verifica el nombre de usuario
            id = i["id"]                                                                                        # Obtiene el ID del usuario
            break                                                                                               # Sale del bucle una vez encontrado

    response_posts = requests.get(f'{API_BASE}posts?userId={id}')                                               # Realiza la solicitud GET para posts
    posts = response_posts.json()                                                                               # Convierte la respuesta a JSON
    primer_post_id = posts[0]["id"]                                                                             # Obtiene el ID del primer post

    response_comments = requests.get(f'{API_BASE}comments?postId={primer_post_id}')                             # Realiza la solicitud GET para comentarios
    comentarios = response_comments.json()                                                                      # Convierte la respuesta a JSON
    return len(comentarios)                                                                                     # Devuelve la cantidad de comentarios

print("Ejercicio3:", ejercicio3())


# 4 Haz una funcion que cree un comentario nuevo (/comments)
def ejercicio4(mail:str, body:str):
    newComment = {                                                              # Datos del nuevo comentario
        "postId": 1,
        "name": "Nuevo Comentario",
        "email": mail,
        "body": body
    }
    response = requests.post(f'{API_BASE}comments', json=newComment)            # Realiza la solicitud POST
    nuevo_comentario = response.json()                                          # Convierte la respuesta a JSON 
    return nuevo_comentario                                                     # Devuelve el nuevo comentario

print("Ejercicio4:", ejercicio4("Eliseo@gardner.bi", "Este es el cuerpo del comentario"))


# 5 Haz una funcion que modifique el email del comentario con id 10
def ejercicio5(id:int, newEmail:str):
    comments = requests.get(f'{API_BASE}comments').json()
    for i in comments:
        if i["id"] == 10:
            i["email"] = newEmail
            return i["id"], i["email"]
    return None

print("Ejercicio5:", ejercicio5(10, "dawiodwmao@awddwa.es"))


# 6 Haz una fucion que elimine el comentario con id 10
def ejercicio6(id:int) -> str:
    comments = requests.get(f'{API_BASE}comments').json()

    for index, comment in enumerate(comments):
        if comment["id"] == id:
            comments.pop(index)
            return f"Se ha eliminado el comentario con id {id}"
    return f"No se ha encontrado el comentario con id {id}"

print("Ejercicio6:", ejercicio6(10))


# 7 Haz una funcion que devuelva el resultado de sumar todos los id's de los usuarios cuya empresa es una LLC
def ejercicio7() -> int:
    usuarios = requests.get(f'{API_BASE}users').json()

    sumaIds:int = 0

    for i in usuarios:
        name:str = i["company"]["name"]
        sum:int = i["id"]
        if "LLC" in name:
            sumaIds += sum
    
    return sumaIds

print("Ejercicio7:", ejercicio7())


# 8 Haz una funcion que devuelva el color de la ultima foto del primer album cuyo id tenga 2 digitos
def ejercicio8() -> str:
    photos = requests.get(f'{API_BASE}photos').json()

    first_album_id = None
    for photo in photos:
        if 10 <= photo["albumId"] <= 99:
            first_album_id = photo["albumId"]
            break

    if first_album_id is None:
        return "No se encontró ningún álbum con ID entre 10 y 99"

    last_photo = None
    for photo in photos:
        if photo["albumId"] == first_album_id:
            last_photo = photo

    if last_photo is None:
        return "No se encontraron fotos para el álbum"

    filename = last_photo["url"].split("/")[-1]

    return filename

print("Ejercicio8:", ejercicio8())


# 9 Haz una funcion que actue de backup de los posts y comments. 
# Tiene que crear una archivo .json con todos los posts. 
# A cada post hay que añadir el campo comments con todos sus comentarios asociados. 
# Es decir, posts y comments se tienen que guardar en el mismo archivo
def ejercicio9() -> str:
    posts = requests.get(f"{API_BASE}/posts").json()
    comments = requests.get(f"{API_BASE}/comments").json()

    for post in posts:
        post["comments"] = [c for c in comments if c["postId"] == post["id"]]

    with open("archivo.json", "w") as f:
        json.dump(posts, f, indent=4)

    return "Se ha escrito en archivo.json"

print("Ejercicio9:", ejercicio9())


# 10 Hacer una funcion que elimine todos los comments
def ejercicio10() -> str:
    comments = requests.get(f'{API_BASE}comments').json()

    for comment in comments:
        requests.delete(f"{API_BASE}comments/{comment['id']}")

    return "Se han eliminado todos los comentarios"

print("Ejercicio10:", ejercicio10())


# 11 Hacer una funcion que elimine todos los posts
def ejercicio11() -> str:
    posts = requests.get(f'{API_BASE}posts').json()

    for post in posts:
        requests.delete(f"{API_BASE}posts/{post['id']}")

    return "Se han eliminado todos los posts"

print("Ejercicio11:", ejercicio11())

# 12 Hacer una funcion que lea el archivo.json y cargue toda la data en la app
def ejercicio12() -> str:
    with open("archivo.json", "r", encoding="utf-8") as f:
        posts = json.load(f)

    for post in posts:
        new_post = {
            "userId": post["userId"],
            "title": post["title"],
            "body": post["body"]
        }
        requests.post(f"{API_BASE}posts", json=new_post)

        if "comments" in post:
            for comment in post["comments"]:
                new_comment = {
                    "postId": post["id"],
                    "name": comment["name"],
                    "email": comment["email"],
                    "body": comment["body"]
                }
                requests.post(f"{API_BASE}comments", json=new_comment)

    return "Se ha cargado toda la data en la app"

print("Ejercicio12:", ejercicio12())