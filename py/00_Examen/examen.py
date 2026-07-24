import requests, os, json

API_BASE = 'http://127.0.0.1:5000/'
path_base = os.path.dirname(os.path.abspath(__file__))

credenciales:dict = {
    'user': 'admin',
    'pass': '1234'
}

response = requests.post(f'{API_BASE}login', data=credenciales)
modelo = 'b'

def ejercicio1() -> int:
    users = requests.get(f'{API_BASE}users').json()

    for u in users:
        if u['username'] == 'alan_turing':
            idAlan = u['id']
            break

    comments = requests.get(f'{API_BASE}comments').json()

    postsAlan = []
    for c in comments:
        if 'userId' in c and 'postId' in c:
            if c['userId'] == idAlan and c['postId'] not in postsAlan:
                postsAlan.append(c['postId'])

    posts = requests.get(f'{API_BASE}posts').json()

    postsNoAlan = []
    for p in posts:
        if p['id'] not in postsAlan:
            postsNoAlan.append(p)

    return len(postsNoAlan)

def ejercicio2() -> None:
    comments = requests.get(f'{API_BASE}comments').json()

    for c in comments:
        if c['author'] == 'Desconocido' and 'locura' in c['body']:
            IdLocura = c['id']
            break

    users = requests.get(f'{API_BASE}users').json()

    usuariosFiltrados = []
    for u in users:
        if u['id'] <= IdLocura:
            usuariosFiltrados.append(u)

    print(usuariosFiltrados)

def resetData(dataset='a'):
    requests.post(f'{API_BASE}data/{dataset}')

if __name__ == '__main__':
    print("Post en los que Alan no ha escrito:", ejercicio1())
    ejercicio2()