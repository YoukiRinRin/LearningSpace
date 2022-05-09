import random
Who = ''
To = ''
HP_unko = 2000

HP_me = 500
HP_nakama1 = 500
HP_nakama2 = 500
#勝者
winner = ''




#ターゲット指定用
target_dic={1:'unko',2:'me',3:'nakama1',4:'nakama2'}

#技のパラメータ
waza_para = {"うんこなげ":slow_unko(Paformer = Who,Target = To),"剣で切る":slash}



#主人公の名前を決める
Get_YorN =''
while Get_YorN !='Y':
    Name_me = input('あなたの名前を入力してください')
    Get_YorN = input('あなたのお名前は'+ Name_me +'でよろしいですか？:Y/N') 
    if Get_YorN != 'Y' or 'N':
        print('正しい値を入力してください')

#戦闘開始
print('うんこ大魔神が現れた！')
while winner == '':
    print('あなたの行動を選んでください')
    print(waza_me)
    get_waza_me = input()
    print('仲間１の行動を選んでください')
    print(waza_nakama1)
    get_waza_1 = input()
    print('仲間２の行動を選んでください')
    print(waza_nakama2)
    get_waza_2 = input()
    if get_waza_2 == '2':
        who = input('誰を回復させますか？')

    get_waza = input()
    Who = "me"
    To = "unko"
    waza_para[waza_me[get_waza_me]]

#各キャラクターのSPから攻撃する順番を決める
def juge_order():
    return True
