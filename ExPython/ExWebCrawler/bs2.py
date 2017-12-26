from bs4 import BeautifulSoup

#import urllib.request
#res=urllib.request.urlopen("http://www.cd-pmi.com")
#html=res.read()
#print(html)
#读取文件的时候必须用这正确的编码读取，否则中文会乱码
file=open("test.html","r",encoding="utf-8")
html=""
for line in file.readlines():
    html=html+line
file.close()
#print(html)
soup=BeautifulSoup(html,"html.parser")
print(soup.title)
print(soup.title.name)
print(soup.title.string)
print(soup.p)
print(soup.p["class"])
print(soup.a)
for link in soup.find_all('a'):
    print(link)
#print(soup.find_all('p'))
print("##################Content")
print(soup.get_text())