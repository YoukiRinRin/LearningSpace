from logging import exception


while True:
    try:
        print()
        print('1:valueError例外を発生')
        print('2:IndexError例外を発生')
        print('3:例外を発生させない')
        print('4:終了')
        selection = int(input('どれにしますか:'))
        if selection == 1:
            tmp = int('foo')
        elif selection == 2:
            tmp = 'str'[5]
        elif selection == 3:
            print()
            print('例外を発生させませんでした')
        elif selection == 4:
            print()
            print('終了します')
            break
        else:
            print(undefined_var)
    except ValueError as e:
        print("Value Error")
        print(e.args)
        print()
    except IndexError:
        print('Index Error')
        print()
    except Exception as e:
        print('Exception')
        print(e.args)
        print()
    print('Try文の直後の行を実行しました')
print('無限ループを終了しました')