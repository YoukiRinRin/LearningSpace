import tkinter

root = tkinter.Tk()

lbl = tkinter.Label(text = "a",foreground="#ff0000")
lbl.place(x=30,y=70)

txt = tkinter.Entry(width = 20)
txt.place(x=90,y = 70)


root.title("計算ゲーム")
root.geometry("400x300")

txt.pack()


root.mainloop()