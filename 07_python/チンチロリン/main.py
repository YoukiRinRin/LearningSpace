import random

sai_1 = 0
sai_2 = 0
sai_3 = 0

random.randint(1,6)



sai = random.randint(1,6)

#ピンゾロ
if sai == 1:
    sai_1 = sai
    sai = random.randint(1.6)
    if sai == 1:
        sai_2 = sai
        sai = random.randint(1.6)
        if sai == 1:
            sai_3 = sai
elif sai == 1:
    sai_1 = sai
    sai = random.randint(1.6)
    if sai == 1:
        sai_2 = sai
        sai = random.randint(1.6)
        if sai == 1:
            sai_3 = sai




def f_Roll_Dice():
    sai_1 = random.randint(1,6)
    sai_2 = random.randint(1,6)
    sai_3 = random.randint(1,6)

def f_Juge_Yaku():

    #ピンゾロ
    if sai_1 == 1 & sai_2 == 1 & sai_3 == 1:
        print('ピンゾロ')
    elif sai_1 == sai_2 & sai_2 == sai_3:
        print('ゾロ目')
    
        
