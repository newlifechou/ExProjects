from bs4 import BeautifulSoup

soup=BeautifulSoup("<p>hello world</p>","html.parser")
print(soup.p.string)

unicode_string=soup.p.string.encode("utf-8")
print(unicode_string)
soup.p.string.replace_with("hello python")
print(soup.p.string)
print(soup.body)
