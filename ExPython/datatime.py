import time
print(time.time())
localtime=time.localtime(time.time())
print(time.asctime(localtime))
print(time.localtime())
print(time.strftime("%Y-%m-%d",time.localtime()))

import calendar
print(calendar.month(2017,12))