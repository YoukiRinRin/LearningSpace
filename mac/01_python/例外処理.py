import random

answer = random.randint(1,100)

while True:
    try:
        number = int(input('100までの数値を入力してください:'))
    except ValueError:
        print('数字以外が入力されました、数字のみを入力してください')
        continue
    if answer < number:
        print('もっと小さな数値です')
    elif answer > number:
        print('もっと大きな数です')
    else:
        break
print('素晴らしい正解です！')

