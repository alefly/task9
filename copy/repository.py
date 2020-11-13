import redis, pymongo, sys


cache = redis.Redis(host=sys.argv[4], port=int(sys.argv[2]), decode_responses=True, health_check_interval=30)
mongoClient = pymongo.MongoClient(host='mongo', port=int(sys.argv[3]))
mongo_table = mongoClient['hw9_4']['files']
cache.ping()


def getFromCache(file):
    return cache.get(file)


def getFromDB(file):
    resp = mongo_table.find_one({'key': file})
    if resp:
            return str(resp['value'])


def deleteFromCache(file):
    cache.delete(file)


def deleteFromDB(file):
    mongo_table.delete_many({'key': file})


def addToCache(file, data):
    cache.set(file, data)


def addToDB(file, data):
    mongo_table.insert_one({'key':file, 'value':data})
