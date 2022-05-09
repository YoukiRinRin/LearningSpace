import tkinter


# ラジオボタン一つのみ選択可能
def change_radio():
    check = var.get()
    if check == 1:
        radio_2.configure(state='normal')
        radio_3.configure(state='normal')
    elif check == 2:
        radio_1.configure(state='normal')
        radio_3.configure(state='normal')
    elif check == 3:
        radio_1.configure(state='normal')
        radio_2.configure(state='normal')
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# チェック判定用変数
var = tkinter.IntVar()
# ラジオボタン初期選択
var.set(1)
# ラジオボタンの生成
radio_1 = tkinter.Radiobutton(text='Radio1', value=1, variable=var, command=change_radio)
radio_1.pack()
radio_2 = tkinter.Radiobutton(text='Radio2', value=2, variable=var, command=change_radio)
radio_2.pack()
radio_3 = tkinter.Radiobutton(text='Radio3', value=3, variable=var, command=change_radio)
radio_3.pack()
window.mainloop()
