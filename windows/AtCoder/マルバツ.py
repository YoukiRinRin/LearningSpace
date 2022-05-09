masu=['','','','','',]
count = 0
juge = ''

for i in range(len(masu)):
    while(1):
        masu[i] = input('入力してね')
        if i != 0:
            if masu[i] == masu[i-1]:
                if masu[i] == '○':
                    juge = '○'
                    count += 1
                elif masu[i] == '☓':
                    juge = '☓'
                    count += 1
                else:
                    print('入力が間違っています')
            else:
                count = 1
                juge = ''
        

print(count)
print(juge)
if count >= 2:
    if juge == '○':
        print('○の勝ちです。')
    elif juge == '☓':
        print('☓の勝ちです。')
