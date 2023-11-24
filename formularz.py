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

win.mainloop()