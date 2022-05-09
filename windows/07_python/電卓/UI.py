from tkinter import *
from tkinter import ttk
from tkinter import messagebox
import function as f

root = Tk()
root.title('電卓')

num_1 = 0
num_2 = 0
num_all = 0



# Frame as Widget Container
frame1 = ttk.Frame(
    root,
    padding=10)
frame1.grid()

# Label 1



label1 = ttk.Label(
    frame1
    )
label1.grid(row=0, column=0)

# Label 2
label2 = ttk.Label(
    frame1,
    text='Will schools be open this fall?',
    width=20,
    anchor=W,
    padding=(20))
label2.grid(row=0, column=1)

# ボタン
button1 = ttk.Button(
    frame1,
    text='1',
    command=lambda:f.add_num(1,num_all))
button1.grid(row=0, column=0)

button2 = ttk.Button(
    frame1,
    text='2',
    command=lambda:f.add_num(2
    ,num_all))
button2.grid(row=0, column=1)

button3 = ttk.Button(
    frame1,
    text='3',
    command=lambda: f.add_num(3,num_all))
button3.grid(row=0, column=2)

button4 = ttk.Button(
    frame1,
    text='4',
    command=lambda: f.add_num(4,num_all))
button4.grid(row=2, column=0)

button5 = ttk.Button(
    frame1,
    text='5',
    command=lambda: f.add_num(5,num_all))
button5.grid(row=2, column=1)

button6 = ttk.Button(
    frame1,
    text='6',
    command=lambda: f.add_num(6,num_all))
button6.grid(row=2, column=2)

button7 = ttk.Button(
    frame1,
    text='7',
    command=lambda: f.add_num(7,num_all))
button7.grid(row=3, column=0)

button8 = ttk.Button(
    frame1,
    text='8',
    command=lambda: f.add_num(8,num_all))
button8.grid(row=3, column=1)

button9 = ttk.Button(
    frame1,
    text='9',
    command=lambda: f.add_num(9,num_all))
button9.grid(row=3, column=2)

button_plus = ttk.Button(
    frame1,
    text='+',
    command=lambda: f.add_num('+',num_all))
button_plus.grid(row=1, column=4)

button_minus = ttk.Button(
    frame1,
    text='-',
    command=lambda: f.add_num('-',num_all))
button_minus.grid(row=2, column=4)


root.mainloop()

