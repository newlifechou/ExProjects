from urllib import request
import urllib

url="https://www.baidu.com/s?"
headers=headers = {
    'User-Agent': r'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) '
                  r'Chrome/45.0.2454.85 Safari/537.36 115Browser/6.0.3',
    'Referer': r'http://www.lagou.com/zhaopin/Python/?labelWords=label',
    'Connection': 'keep-alive'
}
data={
    'wd':'python'
}

data=urllib.parse.urlencode(data).encode("utf-8")


req=request.Request(url,headers=headers,data=data)
res=request.urlopen(req)
print(res.info())
print(res.geturl())
# print(res.read())