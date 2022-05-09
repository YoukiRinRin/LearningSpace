import status 

#技
#うんこなげ
def slow_unko(Paformer,Target):
    damage = 50
    Calc_damage()
    return True

#技のダメージを計算する
def Calc_damage(Paformer,Target,damage):
    total_damage = damage + AT[Paformer] - DF[Target]
    HP[Target] = HP[Target] - total_damage
    return True

#剣で切る
def slash(Paformer,Target):
    damage = 30
    Calc_damage()
    return True

#何回か剣で切る
def nankaikakendekiru(Pafomer,Target):
    damage = 15
    Slu_times = random.randint(1,5)
    for ix in range(Slu_times):
        Calc_damage()
    return True

#うんこ大魔神の攻撃時の処理
def unko_AI():
    if HP["unko"] <= 100:
        waza_para[waza_unko["3"]]
    if SP["unko"] <= 10:
        waza_para[waza_unko[2]]
    return True
    
#かいふく
def kaifuku(Target):
    HP[Target] += 500