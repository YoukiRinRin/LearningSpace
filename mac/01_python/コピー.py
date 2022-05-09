a = [[1,2],[3,4]]
b = a.copy()

b.append([5,6])
print(a)
print(b)

print(a[0][0])
print(a[0][1])
print(a[1][0])
print(a[1][1])

a = 1,2
print(a)

print(list(range(10)))

a = [5,1,3,4]

for i,d in enumerate(a):
    print(i,d)

S = '123.0'
s = int(S)

print(S+S)
print(s + s)

x = 1
y = 2

if x > y:
    ('xはyより大きい')
elif y < x:
    ('yはxより大きい')
else:
    ('xとyは等しい')

