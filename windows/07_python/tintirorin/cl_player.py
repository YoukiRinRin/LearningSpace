class player():
    money = 0
    flg_oya = 0
    kake_money = 0

    dice = 0

    def f_kake_money():
        while(1):
            kake_money = input('掛け金を入力してください')
            if kake_money < player.money:
                print('掛け金が持ち金を上回っています。')
            else:
                break