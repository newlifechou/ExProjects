import urllib.request
res=urllib.request.urlopen("http://www.douban.com")
print(res.read())