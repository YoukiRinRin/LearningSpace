#while(1):
#    S = input('input string')
#    N = int(input('input number of string'))
#    n = N // 2
#    if len(S) != N:
#        print('等しくない')
#    else:
#        break

S = input('input a string')
N = len(S)
n = N // 2

print(S)
print(n)
n_ = n -1
print(n_)

T = S[0:n]
S_b = S[n:N]

if T == S[n:N]:
    print('T={0}　入力した文字は{1}の繰り返しになっています'.format(T,S))
