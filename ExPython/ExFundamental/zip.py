ta=[1,2,3]
tb=[6,7,8]
tc=zip(ta,tb)
for i in tc:
    print(i)

print(zip(*tc))