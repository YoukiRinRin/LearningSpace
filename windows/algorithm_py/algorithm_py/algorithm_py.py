#2bunntansa
def binary_search(data,value):
    left = 0
    right = len(data) -1
    while left <= right:
        mid =(left + right) //2
        if data[mid] == value:
            return mid
        elif data[mid] < value:
            left = mid + 1
        else:
            right = mid -1
    return -1

data = [10,20,30,40,50,60,70,80,90]
print(binary_search(data,90))

#bouble sort

data = [6,15,4,2,8,5,11,9,7,13]

for i in range(len(data)):
    for j in range(len(data) - i -1):
        if data[j] > data[j + 1]:
            data[j], data[j + 1] = data[j + 1],data[j]
            print(data)

#insert sort

def insert_sort(arr):
    for i in range(1,len(arr)):
        j = i -1
        ele = arr[i]
        while arr[i] > ele and j>= 0:
            arr[j + 1] = arr[j]
            j -= 1
            arr[j + i] = ele
            return arr
