A = []
N = int(input('日数を入力してください'))
sa = []

for i in range(N):
    str = i,'日目、売上を入力してください'
    A.append(int(input(str)))
    if i != 0:
        sa.append(A[i] - A[i -1])



for i in range(N):
    print(i+1,'日目',A[i],'円')
    zogen = ''
    
    if sa[i] > 0:
        zogen = '増'
    elif sa[i] < 0:
        sa[i] = sa[i] * -1
        zogen='減'   
    else:
        zogen = '同じ'
    print('前日比',sa[i],'円')
    print(zogen)
