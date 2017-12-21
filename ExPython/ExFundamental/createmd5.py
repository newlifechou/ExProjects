#use hashlib
import hashlib
m=hashlib.md5()

s=['123','456','789']
for line in s:
    m.update(line.encode())
    print(m.hexdigest())

data='苟以国家生死已,岂因福祸避趋之'
m.update(data.encode(encoding='gb2312'))
print(m.hexdigest())
m.update(data.encode(encoding='utf_8'))
print(m.hexdigest())