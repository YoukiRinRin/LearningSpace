import tkinter
from tkinter import messagebox
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# チェックボックス入力真偽値判定
def check_boolean(event):
    message = ''
    if bool_1.get():
        message += 'No.1はチェックされている\n'
    else:
        message += 'No.1はチェックされていない\n'
    if bool_2.get():
        message += 'No.2はチェックされている\n'
    else:
        message += 'No.2はチェックされていない\n'
    if bool_3.get():
        message += 'No.3はチェックされている'
    else:
        message += 'No.3はチェックされていない'
    messagebox.showinfo('Check Boolean', message)
# チェック判定用変数
bool_1 = tkinter.BooleanVar()
bool_2 = tkinter.BooleanVar()
bool_3 = tkinter.BooleanVar()
# チェックボックス初期値
bool_1.set(False)
bool_2.set(False)
bool_3.set(False)
# チェックボックスの生成
checkbutton_1 = tkinter.Checkbutton(text='No.1', variable=bool_1)
checkbutton_1.pack()
checkbutton_2 = tkinter.Checkbutton(text='No.2', variable=bool_2)
checkbutton_2.pack()
checkbutton_3 = tkinter.Checkbutton(text='No.3', variable=bool_3)
checkbutton_3.pack()
# チェックボックス入力真偽値判定ボタン
button = tkinter.Button(text='ボタン', width=60)
button.bind('<Button-1>', check_boolean)
button.pack()
window.mainloop()