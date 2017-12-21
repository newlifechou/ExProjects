def Add(x,y):
    return x+y

def SayHello():
    print('hello my friend')

def isCatorDog(flag):
    if(flag == 'cat'):
        print('this is a cat')
    else:
        print('this is a dog')

sum = lambda arg1,arg2: arg1+arg2

m=1
n=2
print(Add(m,n))
SayHello()
print(Add(x=2,y=6))
print(sum(3,4))
isCatorDog('cat')