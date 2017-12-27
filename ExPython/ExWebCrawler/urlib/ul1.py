from urllib import request

response=request.urlopen("http://www.cd-pmi.com")
# page=response.read()
# print(page)


print(response.info())
print(response.getcode())
print(response.geturl())

# for line in response.readlines():
#     print(line)
i=10
while i>0:
    print(response.readline())
    i=i-1 