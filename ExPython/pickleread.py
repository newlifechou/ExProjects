import pickle
import pprint


data1={'a':1,'b':2,'c':3}
file=open('datapickle.pk1','wb')
pickle.dump(data1,file)
file.close()

file2=open('datapickle.pk1','rb')
data2=pickle.load(file2)
pprint.pprint(data2)
file2.close()