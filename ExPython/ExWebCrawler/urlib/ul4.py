from urllib import request
import urllib

res=request.urlopen("https://www.baidu.com")
print(res.read())

# response=request.urlopen("http://www.cd-pmi.com")
# print(response.readline())
