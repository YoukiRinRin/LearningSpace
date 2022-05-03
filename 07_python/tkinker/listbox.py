import tkinter
# 選択リストをテキストへ追加
def selection_insert(event):
    for l in listbox.curselection():
        output_txt.insert(tkinter.END, listbox.get(l) + '\n')
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# リストボックス項目
box_name = ('ラベル', '入力ボックス', 'ボタン', 'チェックボックス', 'ラジオボタン', 'リストボックス')
# リストボックス項目の設定
var = tkinter.StringVar(value=box_name)
# リストボックスの生成
listbox = tkinter.Listbox(listvariable=var)
listbox.bind('<<ListboxSelect>>', selection_insert)
listbox.pack()
# 出力用テキスト
output_txt = tkinter.Text()
output_txt.pack()
window.mainloop()