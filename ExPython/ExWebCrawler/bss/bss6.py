from bs4 import BeautifulSoup

css_soup=BeautifulSoup('<p class="body strikeout"></p>',"html.parser")
print(css_soup.p['class'])
for css in css_soup.p["class"]:
    print(css)


id_soup=BeautifulSoup('<p id="myid"></p>',"html.parser")
print(id_soup.p["id"])

class_soup=BeautifulSoup('<p class="first cap"></p>',"html.parser")
print(class_soup.p['class'])
class_soup.p['class']=['hello','world']
print(class_soup.p['class'])

soup=BeautifulSoup(open("test.html","r",encoding="utf-8"),"html.parser")
print(soup.prettify())