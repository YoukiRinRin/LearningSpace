import tkinter
from tkinter import messagebox
# メッセージボックス表示
def hello_window(event):
    messagebox.showinfo('Hello', 'Hello Tkinter')
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# ボタン
button = tkinter.Button(text='ボタン', width=60)

button.bind('<Button-1>', hello_window)

button.pack()
window.mainloop()