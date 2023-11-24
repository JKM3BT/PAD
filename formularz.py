import tkinter as tk

win = tk.Tk()
win.title("Różne widgety")
win.minsize(width=400,height=600)

lbl = tk.Label(win, text="Jakiś tekst", font=("Arial",24))
lbl.pack(padx=10,pady=60)

my_text = tk.Text(win, height=5, width=39)
my_text.insert(tk.END, "pierwsza linia\n")
my_text.insert(tk.END, "druga linia \n")
print(my_text.get("1.1"))
my_text.pack()

def spinbox_handler():
    print(spinbox.get())
    lbl.config(text=spinbox.get())

spinbox = tk.Spinbox(win, from_=0, to=10, width=5, command=spinbox_handler)
spinbox.pack(padx=10)

def scale_hadler(value):
    lbl.config(text=value)

scale = tk.Scale(win, from_=0, to=100, command=scale_hadler, orient="horizontal")
scale.pack(pady=10)

def check_button_handler():
    print(checked_state.get())
checked_state = tk.IntVar()
check_button = tk.Checkbutton(win, text="Is on?", variable=checked_state, command=check_button_handler)
check_button.pack()

def radio_button_handler():
    print(radio_state.get())
radio_state = tk.IntVar()
radio_button = tk.Radiobutton(win, text="opcja 1", value=1, variable=radio_state, command=radio_button_handler)
radio_button.pack()
radio_button2 = tk.Radiobutton(win, text="opcja 2", value=2, variable=radio_state, command=radio_button_handler)
radio_button2.pack()
win.mainloop()