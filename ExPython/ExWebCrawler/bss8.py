from bs4 import BeautifulSoup

soup=BeautifulSoup(open("test.html","r",encoding="utf-8"),"html.parser")
head_tag=soup.head
print(head_tag)
print(head_tag.contents)
print("##################")
title_tag=head_tag.contents[7]
print(title_tag)
print(title_tag.string)

for child in head_tag.contents:
    if child != '\n':
        print(child)
