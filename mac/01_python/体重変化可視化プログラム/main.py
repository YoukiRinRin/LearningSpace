import os
import datetime
import csv

dt = datetime.datetime.today()

print('今日の日付は',dt,'です')
weight = int(input('今日の体重を入力してください'))

fn_Y = dt.strftime('%Y年')

folder_name = "./csv"

file_name = dt.strftime('%m月')
extention = ".csv"

print(os.path.exists(folder_name))

print(fn_Y)
print(file_name)

