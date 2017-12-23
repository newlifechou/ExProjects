import requests as rr
r=rr.get('https://www.github.com')
print(r.text)