import random
import cl_player as pl

sai_1 = 0
sai_2 = 0
sai_3 = 0

def_money = 10000

num_player = 0

random.randint(1,6)
num_player = input('参加人数を入力してください')

if num_player == '2':
    p1 = pl.player()
    p2 = pl.player()
elif num_player == '3':
    p1 = pl.player()
    p2 = pl.player()
    p3 = pl.player()
elif num_player == '4':
    p1 = pl.player()
    p2 = pl.player()
    p3 = pl.player()
    p4 = pl.player()


print('親を決めます')
p1.dice = random.randint
p2.dice = random.randint
p3.dice = random.randint
p4.dice = random.randint

  









    

