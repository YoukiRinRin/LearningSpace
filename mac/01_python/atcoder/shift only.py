from concurrent.futures.process import EXTRA_QUEUED_CALLS


num_list = []

try:
    num = int(input('数値を入力してください'))
except ValueError:
    print('数値を入力してください')

for ix in range(num):
    try:
        num_list.append(int(input('数値を入力してください')))
    except ValueError:
        print('正しい数値を入力してください')


even_flg = 0

for ix in range(num):
    if num_list[ix] % 2 == 1:
        even_flg == 1
    if even_flg == 1:
        print('数列には奇数が混じっています')
        break






        