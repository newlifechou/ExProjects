class Bird(object):
    have_feather=True
    way_of_reproduction='egg'

    def move(self,dx,dy):
        position=[0,0]
        position[0]=position[0]+dx
        position[1]=position[1]+dy
        return position
class Chicken(Bird):
    can_find_in_KFC=True

summer=Bird()
print(summer.have_feather)
print(summer.way_of_reproduction)
print(summer.move(5,8))

winter=Chicken()
print(winter.have_feather)
print(winter.way_of_reproduction)
print(winter.move(10,7))
print(winter.can_find_in_KFC)