import os
pwd=os.path.dirname(__file__)
filename=os.path.join(pwd,"datawrite.txt")
file=open(filename,'w')
num=file.write('python is a good program  language')
print(num)
file.close()