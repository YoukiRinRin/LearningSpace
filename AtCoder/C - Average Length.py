import math
def calcurate_distance(x1,x2,y1,y2):
    A = x1 - x2
    B = y1 - y2 
    C = A + B
    D = math.sqrt(C)
    return D

N = int(input('input num of town'))
dis_x = []
dis_y = []
dis_all = []
dis_sum = 0
dis_ave = 0

print(N)

for i in range(N):
    dis_x_str = 'input distance x of town'+str(i)
    dis_y_str = 'input distance y of town'+str(i)
    dis_x.append(int(input(dis_x_str)))
    dis_y.append(int(input(dis_y_str)))


print(dis_x[0])
print(dis_y[0])

for i in range(N):
    dis_all.append(calcurate_distance(dis_x[i],dis_x[i + 1],dis_y[i],dis_y[i +1]))
    dis_sum += dis_all(i)

dis_ave = dis_sum / len(dis_all)