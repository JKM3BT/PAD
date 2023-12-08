import tkinter as tk

win = tk.Tk()
win.title("Formularz dołączenia do Mafii")
win.minsize(width=700,height=1000)

lbl_name = tk.Label(win, text="What's your name: ")
text_name = tk.Text(win, height=1,width=15)
lbl_name.grid(row=0,column=0)
text_name.grid(row=0, column=1)

lbl_age = tk.Label(win, text="Your Age: ")
spin_age = tk.Spinbox(win, from_=18, to=100, width=5)
lbl_age.grid(row=0, column=2)
spin_age.grid(row=0, column=3)

lbl_nickname = tk.Label(win, text="What's your nickname: ")
text_nickname = tk.Text(win, height=1,width=15,)
lbl_nickname.grid(row=1,column=0)
text_nickname.grid(row=1, column=1)
win.mainloop()