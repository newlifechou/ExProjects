import json

data={'name':'xs.zhou','age':30}
json_str=json.dumps(data)
print(json_str)

data2=json.loads(json_str)
print(data2['name'])
print(data['age'])