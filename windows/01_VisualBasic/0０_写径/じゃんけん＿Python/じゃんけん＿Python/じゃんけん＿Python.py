import sys

Rock = 1 
Paper = 2
Scissors = 3


print("じゃんけんゲームを始めます")
print("最初はグー...")
print("ジャンケン,,,")
print(">>>出す手を選択してください")
print("1:グー　2:チョキ 3:パー")

Player1 = 0

while Player1 == 0:
    Player1  = input()
    if Player1 is not 1 or 2 or 3:
        Player1 = 0
        print("正しい値を入力してください")



