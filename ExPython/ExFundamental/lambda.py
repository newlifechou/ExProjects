func=lambda x,y: x+y

print(func(2,3))

def test(f,a,b):
    print("test")
    print(f(a,b))

test(lambda x,y:x-y,10,2)