import requests as rr
#r=rr.get('https://www.github.com')
#print(r.text)
#print(type(r))

param={'wd','tank'}
baidu=rr.get('https://www.baidu.com/s',params=param)
print(baidu.text)