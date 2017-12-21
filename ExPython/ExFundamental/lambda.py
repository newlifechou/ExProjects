func=lambda x,y: x+y

print(func(2,3))

def test(f,a,b):
    print("test")
    print(f(a,b))

test(lambda x,y:x-y,10,2)

re=map(lambda x:x**2,[1,2,3,4])
print(list(re))

def func2(a):
    return a % 2 == 0

le=filter(func2,[1,2,3,4,5,6])
for i in le:
    print(i)