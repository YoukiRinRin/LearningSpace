
for num in range(1,21):
    if num % 3 == 0 and num % 5 == 0:
        print("3と5の両方の倍数です。")
    elif num % 3 == 0:
        print("3の倍数です。")
    elif num % 5 == 0:
            print("5の倍数です")
    else:
                print(num)
