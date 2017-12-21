def f(a,b,c):
    print(a,b,c)

def ff(a,b=10):
    print(a,b)

f(1,2,3)
f(c=1,b=2,a=4)
ff(2,4)
ff(1)


def func(*name):
    print(type(name))
    print(name)
func(1,4,6)
func(2,3,5,6,5,6)

def func2(**dict):
    print(type(dict))
    print(dict)
func2(a=1,b=9)
func2(m=1,n=1,q=3)

def func3(a,b,c):
    print(a,b,c)

args=(1,2,3)
func3(*args)

dict={'a':1,'b':2,'c':3}
func3(**dict)
