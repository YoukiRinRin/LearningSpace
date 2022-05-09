num = 5
num2 = 0

while(1):
    print(num)
    if num == 15:
        break
    num += 1


while(1):
    print(num2)
    if num == 5:
        break
    num += 1

    a = 1
    b = a
    print(id(a),id(b))
    b = 2
    print(id(a),id(b))