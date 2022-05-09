P_Turn = 0 #0=〇=Player1 1=●=Player2
Winer = 0
Flag_migi = 0
Flag_hidari = 0
Flag_shita = 0
Flag_ue = 0

field = [['□','□','□','□','□','□','□','□'],
         ['□','□','□','□','□','□','□','□'],
         ['□','□','□','□','□','□','□','□'],
         ['□','□','□','○','●','□','□','□'],
         ['□','□','□','●','○','□','□','□'],
         ['□','□','□','□','□','□','□','□'],
         ['□','□','□','□','□','□','□','□'],
         ['□','□','□','□','□','□','□','□']]

field_end1 = 8
field_end2 = 0
for Ix in range(8):
    for Ix2 in range(8):
        print(field[Ix][Ix2],end='')
        if Ix2 == 7 :
            print('\n',end='')


while Winer == 0:
    print('石を置く場所を指定してください')
    print('横')
    Next_W = input()
    print('縦')
    Next_H = input()

    Flag_migi_shita = 0
    Flag_migi_ue = 0
    Flag_migi_shita = 0
    Flag_hidari_ue = 0
    Flag_hidari_shita = 0


    print('('+Next_W+','+Next_H+')')

    if P_Turn == 0:
        field[int(Next_W)][int(Next_H)] = '●'
    else:
        field[int(Next_W)][int(Next_H)] = '○'
    

    for Ix in range(8):
        for Ix2 in range(8):
            print(field[Ix][Ix2],end='')
            if Ix2 == 7 :
                print('\n',end='')

    if P_Turn == 0:
        P_Turn = 1
    else:
        P_Turn = 0
 
    if Check_Reverce() == 0:
        print('おける場所を選択してください')
        
def Check_Reverce(Next_W,Next_H,P_Turn):
    Check_Ishi = ''
    Re_Masu = []
    Check_Masu = ''

    

    if P_Turn == 0:
        Check_Ishi = '○'
    else:
        Check_Ishi = '●'

    while Flag_migi == 0:
     Check_migi = Next_W
     if field(Check_migi,Next_H) == Check_Ishi:
        Flag_migi = 1
     Check_migi = Check_migi + 1
     if Check_migi == field_end1:
        break

    while Flag_hidari == 0:
        Check_hidari = Next_W
        if field(Check_hidari,Next_H) == Check_Ishi:
            Flag_migi = 1
        Check_hidari = Check_hidari - 1
        if Check_hidari == field_end1:
            break

    while Flag_shita == 0:
        Check_shita = Next_H
        if field(Next_W,Check_shita) == Check_Ishi:
            Flag_shita = 1
        Check_shita = Check_shita + 1
        if Check_shita == field_end2:
            break

    while Flag_ue == 0:
        Check_ue = Next_H
        if field(Next_W,Check_ue) == Check_Ishi:
            Flag_ue = 1
        Check_ue = Check_ue - 1
        if Check_ue == field_end2:
            break

    while Flag_migi_shita == 0:
        Check_ue = Next_H
        if field(Next_W,Check_ue) == Check_Ishi:
            Flag_ue = 1
        Check_ue = Check_ue - 1
        if Check_ue == field_end2:
            break

    while Flag_migi_ue == 0:
        Check_ue = Next_H
        if field(Next_W,Check_ue) == Check_Ishi:
            Flag_ue = 1
        Check_ue = Check_ue - 1
        if Check_ue == field_end2:
            break

    while Flag_hidari_shita == 0:
        Check_ue = Next_H
        if field(Next_W,Check_ue) == Check_Ishi:
            Flag_ue = 1
        Check_ue = Check_ue - 1
        if Check_ue == field_end2:
            break

    while Flag_hidari_ue == 0:
        Check_ue = Next_H
        if field(Next_W,Check_ue) == Check_Ishi:
            Flag_ue = 1
        Check_ue = Check_ue - 1
        if Check_ue == field_end2:
            break

    if Flag_migi == 0 and Flag_hidari == 0 and Flag_ue == 0 and Flag_shita == 0:
        return 0


        
        #オセロのひっくり返すかどうか判定する
        #対象は上下左右斜め
        #マスを一つずつチェックする
        #同じ色の意思に出会ったら終わり
        #なければ置けない
        #
        #繰り返し
        #条件　チェックした石＝現在の石    
        #
        #右横に＋１
        #左横に-1
        #下縦に＋１
        #上縦に-1
        #
        #必要な変数
        #現在の石色
        #色を変えるべき場所
        #
        #
        ##   
        #プレイヤーの石と同じでなければ続行、同じならば終了
        #
        #ただし一回目で同じならば置けないメッセージ表示で選択肢直し
        #
        #正常ならばその間の石をすべて自分の石の色にする
        #
        #####

def ReverseIshi(Next_w,Next_h):
