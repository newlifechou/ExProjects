from bs4 import BeautifulSoup
soup=BeautifulSoup(open("test.html"))
print(soup.p)
print(type(soup.p))
