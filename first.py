from tkinter import Tk, Frame, Button, Entry, END


window = Tk()

window.title("Okno")
window.minsize(width=280,height=300)
e = Entry(window, width=40, borderwidth=5)
e.grid(row=0,column=0, columnspan=3, padx=10,pady=10)

def on_click(num):
    e.insert(END, str(num))

btn1 = Button(window, text="1", padx=40, pady=20, command=lambda: on_click(1))
btn1.grid(column=0,row=1)
btn2 = Button(window, text="2", padx=40, pady=20, command=lambda: on_click(2))
btn2.grid(column=1,row=1)
btn3 = Button(window, text="3", padx=40, pady=20, command=lambda: on_click(3))
btn3.grid(column=2,row=1)
btn4 = Button(window, text="4", padx=40, pady=20, command=lambda: on_click(4))
btn4.grid(column=0,row=2)
btn5 = Button(window, text="5", padx=40, pady=20, command=lambda: on_click(5))
btn5.grid(column=1,row=2)
btn6 = Button(window, text="6", padx=40, pady=20, command=lambda: on_click(6))
btn6.grid(column=2,row=2)
btn7 = Button(window, text="7", padx=40, pady=20, command=lambda: on_click(7))
btn7.grid(column=0,row=3)
btn8 = Button(window, text="8", padx=40, pady=20, command=lambda: on_click(8))
btn8.grid(column=1,row=3)
btn9 = Button(window, text="9", padx=40, pady=20, command=lambda: on_click(9))
btn9.grid(column=2,row=3)
window.mainloop()