import requests

API_BASE = 'http://127.0.0.1:5000/'

credenciales:dict = {
    'user': 'admin',
    'pass': '1234'
}

response = requests.post(f'{API_BASE}login', data=credenciales)

if not response.ok:
    print('Login fallido')
    exit()
token:str = response.json()['token']
headers:dict = {'Authorization': f'Bearer {token}'}

# 1- Hacer una función que elimine todos los "TODOs" que en su title tengan más de 3 palabras.
def ejercicio1() -> None:
    todos:list[dict] = requests.get(f'{API_BASE}todos').json()
    for todo in todos:
        partes:list[str] = todo['title'].split(maxsplit=4)
        if len(partes) > 3:
            requests.delete(f'{API_BASE}todos/{todo['id']}', headers=headers)

# 2- Después de hacer el ejercicio 1, hacer una función que devuelva cuántos usuarios tienen algún TODO pendiente.
def ejercicio2() -> int:
    filtrado:dict = {'completed': False}
    todos:list[dict] = requests.get(f'{API_BASE}todos', params=filtrado).json()

    user_ids:list[int] = []
    for todo in todos:
        todo_full:dict = requests.get(f'{API_BASE}todos/{todo['id']}').json()
        if todo_full['userId'] not in user_ids:
            user_ids.append(todo_full['userId'])

    return len(user_ids)

# 3- Hacer una función que devuelva cuántos TLD distintos hay en 
# las websites de los usuarios.
def ejercicio3() -> int:
    users:list[dict] = requests.get(f'{API_BASE}users').json()
    tlds:set[str] = set()
    for u in users:
        user:dict = requests.get(f'{API_BASE}users/{u['id']}').json()
        tlds.add(user['website'].split('.')[-1])
    return len(tlds)

# 4- Hacer una función que marque como completados los TODOS 
# que tengan pendientes los usuarios con un dominio .org.
def ejercicio4() -> None:
    users:list[dict] = requests.get(f'{API_BASE}users').json()
    tlds:set[str] = set()
    for u in users:
        user:dict = requests.get(f'{API_BASE}users/{u['id']}').json()
        if user['website'].endswith('.org'):
            filtrado:dict = {'userId': user['id'], 'completed': False}
            todos:list[dict] = requests.get(f'{API_BASE}todos', params=filtrado).json()
            for td in todos:
                requests.get(f'{API_BASE}todos/{td['id']}', json={'completed': True}, headers=headers)

# 5- Hacer una función que cree el TODO "Estudiar para el examen" 
# vinculado al usuario con la website "ola.org".
def ejercicio5() -> None:
    filtrado:dict = {'website': 'ola.org'}
    user:dict = requests.get(f'{API_BASE}users', params=filtrado).json()[0]
    new_todo:dict = {
        'completed': False,
        'title': 'Estudiar para el examen',
        'userId': user['id']
    }
    result = requests.post(f'{API_BASE}todos', json=new_todo, headers=headers)
    print(result.json())

if __name__ == "__main__":
    # ejemplo: ejecutar todos los ejercicios
    ejercicio1()
    print("Ejercicio 1 hecho")

    print("Usuarios con TODO pendiente:", ejercicio2())

    print("TLDs distintos:", ejercicio3())

    ejercicio4()
    print("Ejercicio 4 hecho")

    ejercicio5()   # esta ya hace un print del resultado