import codacs

text = 'あいうえお'
target_file = codacs_open(path,"a","utf_8")

target_file.write(text)

target_file.close