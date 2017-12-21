def square_sum(a,b):
    c=a**2+b**2
    return c

print(square_sum(3,4))

def isLeapYear(year):
    if year % 400 == 0:
        return True
    elif year % 4 ==0 and year % 100 != 0:
        return True
    else:
        return False

print(2016,isLeapYear(2016))
print(2013,isLeapYear(2013))