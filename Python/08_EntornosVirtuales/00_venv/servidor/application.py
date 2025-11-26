import shutil, os, json, hashlib
from flask import Flask, jsonify, request

path_base = os.path.dirname(os.path.abspath(__file__))

application = Flask(__name__)

@application.route('/')
def root():
    return 'API Levantada'

@application.route('/<string:itemName>', methods=['GET'])
def returnItems(itemName):
    return getItems(itemName)

@application.route('/<string:itemName>/<int:id>', methods=['GET'])
def returnItem(itemName, id):
    return getItem(itemName, id)

@application.route('/<string:itemName>/<int:id>', methods=['PUT'])
def modifyItem(itemName:str, id:int):
    return updateItem(itemName, id)

@application.route('/<string:itemName>/<int:id>', methods=['DELETE'])
def removeItem(itemName:str, id:int):
    return deleteItem(itemName, id)

@application.route('/<string:itemName>', methods=['POST'])
def createItem(itemName:str):
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

@application.errorhandler(Exception)
def handle_500(error):
    return jsonify({'ERROR': 'Error desconocido'}), 400

if __name__ == '__main__':
    application.run(debug=True)