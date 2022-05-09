list_1 = ['1','2','3']

numbers = [i if i % 2 == 1 else i**2 for i in range(10)]
print(numbers)

def binary_search(data,value):
    left = 0
    right = len(data) -1
    while left <= right:
        mid = (left + right) 
        if data[mid] == value:
            return mid 
        elif data[mid] < value:
            left = mid + 1
        else:
            right = mid -1

        return -1
data = [10,20,30,40,50,60,70,80,90]
print(binary_search(data,90))
        

data2 = [6, 15, 4, 2, 8, 5, 11, 9, 7, 13]
for i in range(len(data)):
    for j in range(len(data)-i - 1):
        if data2[j] > data2[i + 1]:
            data2[j],data2[j + 1] = data2[j + 1], data2[j]
print(data)    

data3 = [6, 15, 4, 2, 8, 5, 11, 9, 7, 13]

change = True 
    for i in range(len(data3)):
        if not change:
            break
        change = False
        for j in range(len(data)-i -1):
            if data[]