from bs4 import BeautifulSoup
import re

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

print("helloworld")
for child in head_tag.descendants:
    print(child)
print(len(list(soup.children)))
print(len(list(soup.descendants)))

print(title_tag.contents)
print(title_tag.string)
p_soup=soup.p
print(p_soup.attrs["class"])

print("################")
for str in soup.strings:
    print(repr(str))
print("***************")
for str in soup.stripped_strings:
    print(repr(str))

print("###############")
print(title_tag.parent)
print(title_tag.string.parent)
print(soup.parent)
print(p_soup)
print(soup.p.next_sibling.next_sibling)

print("===============")

for sibling in p_soup.next_siblings:
    print(sibling)

first_p=soup.find("p",id="second")
print(first_p)
print(first_p.next_element)

for i in soup.find_all("a"):
    print(i)

for p in soup.find_all("p"):
    print(p)

for tag in soup.find_all(re.compile("p")):
    print(tag.string)


for tag in soup.find_all(["p","a"]):
    print(tag)
print("$$$$$$$$$$$$$$$$$$$$$$")
for t in soup.find_all(True):
    print(t)


def has_class_but_no_id(tag):
    return tag.has_attr('class') and  not tag.has_attr('id')

for t in soup.find_all(has_class_but_no_id):
    print("====>",t)