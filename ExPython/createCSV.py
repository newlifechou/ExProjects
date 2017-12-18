import csv
import os

BASE_DIR=os.path.dirname(__file__)
print(BASE_DIR)
filepath=os.path.join(BASE_DIR,'log.csv')
csv_reader=open(filepath,'r')
data=[]
for line in csv_reader:
    data.append(list(line.strip().split('|')))

for line in data:
    print(line)