#inp_str = input('input a sentence')
inp_str = 'This eBook is for the use of anyone anywhere in the United States and most other parts of the world at no cost and with almost no restrictions whatsoever. You may copy it, give it away or re-use it under the terms of the Project Gutenberg License included with this eBook or online at www.gutenberg.org. If you are not located in the United States, you will have to check the laws of the country where you are located before using this eBook.'

str_arr = inp_str.split()

str_find = 'it'

print(str_arr)
count = 0


for i in str_arr:
    if i == str_find:
        count += 1

print(count)

