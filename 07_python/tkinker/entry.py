import tkinter
# ウィンドウ
window = tkinter.Tk()
window.title('Sample Tkinter')
window.geometry('480x480')
# ボックス
entry = tkinter.Entry(width=60)
entry.pack()
window.mainloop()