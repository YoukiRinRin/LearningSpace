import random

kanto = ["東京","神奈川","埼玉","千葉","茨城","群馬","栃木"]
print(kanto[1:4])
print(kanto[::1])

l = ["赤","青"]
ll = l * 4
print(ll)

animal = ["猫"]

print(type(animal))
print(type(l))

colors = ["赤","青","黒","白"]

c = input("色を入力してください")

try:
    if colors.index(c) >= 0:
        print("色がリストにあります")
except:
    print("リストにありません")

print('colorsの中からランダムに一つ抽出:',random.choice(colors))
print('kantoの中からランダムに一つ抽出:',random.choice(kanto))

kujis = ["大吉","中吉","小吉","凶"]
unsei = random.choices(kujis)

print(unsei)

seasons = {"Spring":"春","Summer":"夏","Autumn":"秋","Winter":"冬"}

print(seasons)
print(seasons.items())

for(s1,s2) in seasons.items():
    print(s1,s2)

for(s1) in seasons.items():
    print(s1)

for(s1,s2) in seasons.items():
    print(s1)
    print(s2)