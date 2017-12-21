import os
print(os.getcwdb())

import zlib
s='够一国家生死以岂因福祸避趋之'
print(len(s.encode()))
t=zlib.compress(s.encode())
print(len(t))
tt=zlib.decompress(t)
print(len(tt))
print(zlib.crc32(s.encode()))