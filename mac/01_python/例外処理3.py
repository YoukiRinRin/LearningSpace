try:

    hoge = int(input('数値を入力してください'))

    array_hoge = [1,2,3,4,5]
    array_hoge[hoge] = 'hoge'





except ValueError as e:
    print('Value Error')
    print(e.args)
except IndexError as e:
    print("Index Error")
    print(e.args)