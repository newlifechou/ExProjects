from bs4 import BeautifulSoup
soup=BeautifulSoup(open("test.html"))
print(soup.prettify())

soup2=BeautifulSoup("<html>hello</html>")
print(soup2.prettify())