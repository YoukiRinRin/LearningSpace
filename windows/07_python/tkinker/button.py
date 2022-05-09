import tkinter
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# ボタン
button = tkinter.Button(text='ボタン', width=60)
button.pack()


window.mainloop()