import shutil, os, json, hashlib, jwt
from flask import Flask, jsonify, request, abort
from enum import IntEnum
from functools import wraps
from datetime import datetime, timedelta, timezone

path_base = os.path.dirname(os.path.abspath(__file__))

application = Flask(__name__)

TOKEN_KEY = 'top-secret'

class UserRole(IntEnum):
    SUPERADMIN = 1
    ADMIN = 5
    USUARIO = 100

def check_auth(role):
    def decorator(f):
        @wraps(f)
        def wrapper(*args, **kargs):
            try:
                token = request.headers['Authorization']
                token = token.split()[1]
                token_data = jwt.decode(token, TOKEN_KEY, algorithms=['HS256'])
            except Exception as e:
                print(str(e))
                abort(401)
            if token_data['type'] > role:
                abort(401)
            return f(token_data['id'], *args, **kargs)
        return wrapper
    return decorator

@application.route('/')
def root():
    return 'API Levantada'

@application.route("/login", methods=['POST'])
def login():
    user:str = request.form.get('user', '')
    password:str = request.form.get('pass', '')
    userType:int = -1
    userId:int = -1
    if user == 'admin' and password == '1234':
        userType = 1
        userId = 0
    else:
        with open('data/users.json', 'r') as json_file:
            users = json.load(json_file)
        for u in users:
            if u['username'] == user:
                userType = 100
                userId = u['id']
                break

    if userType > 0:
        token_data = {
            'id': str(userId),
            'type': userType,
            'exp': datetime.now(timezone.utc) + timedelta(seconds=6000)
        }
        token = jwt.encode(token_data, TOKEN_KEY, algorithm='HS256')
        return jsonify({'token':token}), 200
    return jsonify({}), 401

@application.route('/<string:itemName>', methods=['GET'])
def returnItems(itemName):
    return getItems(itemName)

@application.route('/<string:itemName>/<int:id>', methods=['GET'])
def returnItem(itemName, id):
    return getItem(itemName, id)

@application.route('/<string:itemName>/<int:id>', methods=['PUT'])
@check_auth(UserRole.SUPERADMIN)
def modifyItem(user_id:int, itemName:str, id:int):
    return updateItem(itemName, id)

@application.route('/<string:itemName>/<int:id>', methods=['DELETE'])
@check_auth(UserRole.SUPERADMIN)
def removeItem(user_id:int, itemName:str, id:int):
    return deleteItem(itemName, id)

@application.route('/<string:itemName>', methods=['POST'])
@check_auth(UserRole.USUARIO)
def createItem(user_id:int, itemName:str):
    return addItem(itemName)

@application.route('/data/screenshot', methods=['GET'])
def getScreenshot():
    calculate_hash = lambda data: hashlib.sha256(str(json.dumps(data, ensure_ascii=False)).encode('utf-8')).hexdigest()
    return jsonify({'result': 'OK', 'screenshot': calculate_hash({key: readData(key) for key in fieldsGetAll})})

@application.route('/data/reset', methods=['POST'])
def setData():
    source_folder = f'{path_base}/data-bk/'
    [shutil.copy(source_folder + file_name, f'{path_base}/data/{file_name}') for file_name in os.listdir(source_folder) if os.path.isfile(source_folder + file_name)]
    return jsonify({'result': 'OK'}), 200

fieldsGetAll = {
    'posts': ['id', 'title'],
    'comments': ['id', 'postId', 'name'],
    'users': ['id', 'username'],
    'albums': ['userId', 'id', 'title'],
    'photos': ['id', 'title', 'thumbnailUrl'],
    'todos': ['id', 'title']
}

fieldsGetOne = {
    'posts': ['id', 'userId', 'title', 'body'],
    'comments': ['id', 'postId', 'name', 'email', 'body'],
    'users': ['id', 'name', 'username', 'email', 'address', 'phone', 'website', 'company'],
    'albums': ['userId', 'id', 'title'],
    'photos': ['albumId', 'id', 'title', 'url', 'thumbnailUrl'],
    'todos': ['userId', 'id', 'title', 'completed']
}

fieldsUpdate = {key: [field for field in fieldsGetOne[key] if field != 'id'] for key in fieldsGetOne}
fieldsInsert = fieldsUpdate

def readData(itemName:str):
    with open(f'{path_base}/data/{itemName}.json', 'r', encoding='utf8') as json_file:
        data = json.load(json_file)
    return data

def saveData(itemName:str, data):
    with open(f'{path_base}/data/{itemName}.json', 'w', encoding='utf8') as f:
        json.dump(data, f, indent=4, ensure_ascii=False)

getPublicItem = lambda item, itemFields: {field: item[field] for field in item if field in itemFields}
filterItems = lambda items, args: items if not args else [item for item in items if all(str(item.get(arg)) == str(args[arg]) for arg in args)]
findItemById = lambda items, id: next((item for item in items if item['id'] == id), None)
getLatestId = lambda items: max((item['id'] for item in items), default=0)

getItems = lambda itemName: (jsonify([getPublicItem(item, fieldsGetAll[itemName]) for item in filterItems(readData(itemName), request.args)]), 200)

def getItem(itemName:str, itemId:int):
    item = findItemById(readData(itemName), itemId)
    if item is None:
        return jsonify({}), 404
    return jsonify(getPublicItem(item, fieldsGetOne[itemName])), 200

def addItem(itemName:str):
    items = readData(itemName)
    data = request.get_json()
    if data is None:
        raise Exception()
    newItem = {'id': getLatestId(items) + 1}
    for field in fieldsInsert[itemName]:
        newItem[field] = data[field]
    items.append(newItem)
    saveData(itemName, items)
    return jsonify(newItem), 201

def updateItem(itemName:str, itemId:int):
    items = readData(itemName)
    item = findItemById(items, itemId)
    if item is None:
        return jsonify({'ERROR': 'El elemento no existe'}), 404
    data = request.get_json()
    if data is None:
        raise Exception()
    for field in fieldsUpdate[itemName]:
        if field in data:
            item[field] = data[field]
    saveData(itemName, items)
    return jsonify(item), 200

def deleteItem(itemName:str, itemId:int):
    items = readData(itemName)
    item = findItemById(items, itemId)
    if item is None:
        return jsonify({'ERROR': 'El elemento no existe'}), 404
    items.remove(item)
    saveData(itemName, items)
    return ('', 200)

@application.errorhandler(401)
def handle_401(error):
    return jsonify({'ERROR': 'Acceso no autorizado o token inválido'}), 401

@application.errorhandler(Exception)
def handle_500(error):
    return jsonify({'ERROR': 'Error desconocido'}), 400

if __name__ == '__main__':
    application.run(debug=True)