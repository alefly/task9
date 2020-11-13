from flask import Flask, request
import json, sys
import service, time

app = Flask(__name__)

@app.route('/storage/<file>', methods=['GET', 'PUT', 'DELETE'])
def storage(file):
	if request.method == 'GET':
		resp = service.get(file)
		if(resp == -1):
			return 'File not found', 404
		else:
			return resp, 200
	if request.method == 'DELETE':
		service.delete(file)
		return 'File deleted', 204
	if request.method == 'PUT':
		try:
			json.loads(request.data)
		except:
			return 'JSON isn`t right!', 400
		service.put(file, request.data)
		return 'File changed', 201
	return 'Error on server', 405

if __name__ == '__main__':
	app.run(host='0.0.0.0', port=int(sys.argv[1]))
