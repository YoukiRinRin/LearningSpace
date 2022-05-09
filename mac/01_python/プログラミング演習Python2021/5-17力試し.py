import math


while(1):
    x = input('整数を入力して下さい')

    try:
        x = int(x)
    except ValueError:
        print('入力された値は整数に変換できません')
        continue
    except:
        print('予期しないエラーが発生しました。')
        continue
        
    if x <= 0:
        print('入力された値は負の数です')
        continue
        
    x = math.sqrt(x)

    print('入力された値の平方根は',x,'です')