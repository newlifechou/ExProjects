import sys
import csv
import os

BASE_DIR=os.path.dirname(__file__)
print(BASE_DIR)
filepath=os.path.join(BASE_DIR,'log.csv')
csv_reader=csv.reader(open(filepath,'r'))
for row in csv_reader:
    print(row)

csv_writer=csv.writer(open(filepath,'a'))
csv_writer.writerow(['Python','Program'])
