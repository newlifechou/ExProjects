import urllib.request
res=urllib.request.urlopen("http://www.cdpmi.net")
res.encoding="utf-8"
html=res.read()
print(html)