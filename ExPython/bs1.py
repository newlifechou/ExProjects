from bs4 import BeautifulSoup
import urllib.request
res=urllib.request.urlopen("http://www.cdpmi.net")

html=res.read()
print(html)

soup=BeautifulSoup(html)
print(soup.prettify())
