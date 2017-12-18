//使用随机数
import random
random.seed(10)
item=[1,2,3,4,5,6,7]
i=5
while(i>0):
    print(random.random())
    print(random.randint(1,10))
    print(random.uniform(1,5))
    print(random.randrange(20,100,5))
    print(random.sample('helloworld',3))
    random.shuffle(item)
    print(item)
    i=i-1