from bs4 import BeautifulSoup
soup=BeautifulSoup(open("test.html","r",encoding="utf-8"),"html.parser")
print(soup.a)
print(soup.a.name)
print(soup.a.string)
print(soup.p.attrs)
soup.p.attrs["id"]="first_paragraph"

print(soup.prettify())

del soup.p.attrs["id"]

print(soup.prettify())