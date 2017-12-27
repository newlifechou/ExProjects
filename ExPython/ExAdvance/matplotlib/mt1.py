import matplotlib.pyplot as plt
import numpy as np




# plt.plot([1,2,3,4])
# plt.plot([1,2,3,4],[1,3,4,6],'ro')
# plt.axis([0,6,-1,7])

# plt.ylabel('some numbers')
# plt.xlabel('x label information')


t=np.arange(0.,5.,0.2)
print(t)

plt.plot(t,t,'r--',t,t**2,'bs',t,t**3,'g^')
plt.show()