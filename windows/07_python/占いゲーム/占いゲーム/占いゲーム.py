import random

print('エンターを押してください')
inpKey = input('>>')

kuji_list = ['大吉','中吉','吉','凶','大凶']


kuji = random.randint(0,5)


print(kuji)
print(kuji_list[kuji])

