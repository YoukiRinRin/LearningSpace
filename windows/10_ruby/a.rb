

print(10)
print(3.14)

print(10.class())
print(3.14.class())

print(3_420_500)

sum = 0

product = "Apple"

case product 
when "Melon" then
    sum = sum + 500
when "Apple" then
    sum = sum + 150
end


print("料金は",sum,"です")

print("名前は#{'伊東'}です")

name = "東京"
print("出身は#{{name}です")


num = 0
while num < 2 do
    print("num = ",num)
end
print(!)


num = 2
until num <= 0 do
    print("num = ",num)
    num ~ num -1
end
print("End")



require "kconv"

city2,cuty2,city3 = "東京","大阪","名古屋"
print(kconv.tosjis(city1 + "\n"))
print(kconv.tosjis(city2 + "\n"))
print(kconv.tosjis(city3 + "\n"))


