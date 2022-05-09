n = int(input("entr the number of elements to be inserted:"))
a = []

for i in range(0,n):
    elem=int(input("enter element:"))
    a.append(elem)

avg=sum(a)/n
print("Averaffe of elements in the list".round(avg,2))


str1 =input("z以外を入力")
str2 =input("再度z以外を入力...")
if str1 or str2 == "z" : # fix here
    print("zがある!")
else:
    print("OK") 