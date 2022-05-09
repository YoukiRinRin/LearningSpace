try:
    inp_num = int(input('数値を入力してね'))
except ValueError:
    print('数値を入力してください')

if inp_num == 1:
    print('this is 1')
else:
    print('this is not 1')