N = input('')
A = []
min = 0
flg_even = 0
for i in range(N):
    A.append(int(input('')))
    if i == 0:
        min = A[i]
    elif i != 0:
        if min > A[i]:
            min = A[i]
    if A[i] // 2 == 1:
        flg_even = 1

if flg_even == 1:
    print('一回も無理ー')

times = 0
while(1):
    min_ = min / 2 
    if min_ // 2 == 1:
        break
    times += 1




