"""import list_class

player1 = list_class.player
player2 = list_class.player



player1.masu_now = player1.f_Roll_Dice
player2.masu_now = player2.f_Roll_Dice

print(player1.masu_now)
print(player2.masu_now)
"""

import random

mes = {1:'a',2:'b'}
func ={1:'',2:''}

NUM_MASU = 2

field = []

for i in range(NUM_MASU):
    field.append(i)

print(field)

player1_pos = 0
player1_maney = 0

player2_pos = 0
player2_maney = 0


dice = random.randint(1,2)

player1_pos = player1_pos + dice

print(mes[player1_pos])
