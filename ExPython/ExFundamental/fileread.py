import os
pwd=os.getcwd()
print(pwd)

filename=os.path.join(pwd,'ExPython','data.txt')
f=open(filename,'r')
#str=f.read()
str=f.readlines()
print(str)
f.close()

for line in str:
    print("#"+line,end='')



cwd=os.path.dirname(__file__)
print(cwd)