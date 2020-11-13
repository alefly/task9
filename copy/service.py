import repository

def get(file):
	data = repository.getFromCache(file)
	if data:
		return repository.getFromCache(file)
	data = repository.getFromDB(file)
	if data:
		repository.addToCache(file, data)
		return data
	else:
		return -1

def delete(file):
	repository.deleteFromCache(file)
	repository.deleteFromDB(file)

def put(file, data):
	delete(file)
	repository.addToDB(file, data)
