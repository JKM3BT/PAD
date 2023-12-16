import tkinter as tk
from tkinter import ttk
win = tk.Tk()
win.title("Formularz dołączenia do Mafii")
win.minsize(width=370,height=750)
separator = ttk.Separator(win, orient="horizontal")
class TextRelatedForms:
    def __init__(self, text, horizontal, vertical):
        self.text = text
        self.horizontal = horizontal
        self.vertical = vertical
    def Lbl(text,horizontal,vertical):
        lbl = tk.Label(win, text=text)
        lbl.grid(column=horizontal, row=vertical)
    def Text(horizontal,vertical):
        text = tk.Text(win, height=1, width=15)
        text.grid(column=horizontal, row=vertical)
class IntRelatedForms:
    def __init__(self,horizontal,vertical, min_value, max_value):
        self.horizontal = horizontal
        self.vertical = vertical
        self.min_value = min_value
        self.max_value = max_value
    def Spinbox(min_value,max_value, horizontal,vertical):
        spinbox = tk.Spinbox(win, from_=min_value, to=max_value, width=5)
        spinbox.grid(column=horizontal, row=vertical)
class OtherForms:
    def __init__(self, option1, option2, option3, value1, value2, value3, horizontal, vertical):
        self.option1 = option1
        self.option2 = option2
        self.option3 = option3
        self.value1 = value1
        self.value2 = value2
        self.value3 = value3
    def Radio_button(option1, option2, value1, value2, horizontal, vertical):
        var = tk.IntVar()
        radio_button1 = tk.Radiobutton(win, text=option1, value=value1, variable=var)
        radio_button2 = tk.Radiobutton(win, text=option2, value=value2, variable=var)
        radio_button1.grid(column=horizontal, row=vertical)
        radio_button2.grid(column=horizontal+1, row=vertical)
    def checkBox(option1, option2, option3, horizontal, vertical):
        var1 = tk.IntVar(win,1)
        var2 = tk.IntVar(win,2)
        var3 = tk.IntVar(win,3)
        check_box1 = tk.Checkbutton(win, text=option1, variable=var1)
        check_box2 = tk.Checkbutton(win, text=option2, variable=var2)
        check_box3 = tk.Checkbutton(win, text=option3, variable=var3)
        check_box1.grid(column=horizontal, row=vertical, sticky="W")
        check_box2.grid(column=horizontal, row=vertical+1, sticky="W")
        check_box3.grid(column=horizontal, row=vertical+2, sticky="W")
    
lbl_name = TextRelatedForms.Lbl("What's your name: ", 0, 0)
text_name = TextRelatedForms.Text(1, 0)
lbl_nickName = TextRelatedForms.Lbl("Your Nickname: ", 0, 1)
text_nickName = TextRelatedForms.Text(1, 1)

lbl_age = TextRelatedForms.Lbl("Your age: ", 2, 0)
spinbox_age = IntRelatedForms.Spinbox(18, 100, 3, 0)
lbl_adress = TextRelatedForms.Lbl("Your house number: ", 2, 1)
spinbox_adress = IntRelatedForms.Spinbox(0, 1000, 3, 1)

lbl_gender = TextRelatedForms.Lbl("Are you a boy or a girl: ", 0, 2)
radioButton_gender = OtherForms.Radio_button("Boy", "Girl", 1, 2, 1, 2)
lbl_outfit = TextRelatedForms.Lbl("Write what are you wearing right now: ", 0, 3)
text_outfit = TextRelatedForms.Text(1, 3)
separator.pack(fill="x")
lbl_prison = TextRelatedForms.Lbl("Ever been to prison: ", 0, 5)
rdiobutton_prison = OtherForms.Radio_button("Yes", "No", 1, 2, 1, 5)
lbl_reason = TextRelatedForms.Lbl("Why you got to prison: ", 0, 6)
checkbox_reason = OtherForms.checkBox("You shot someone", "You kidnapped someone", "You blew up somebody's house", 1, 5)

lbl_preferences = TextRelatedForms.Lbl("You like to eat: ", 0, 10)
checkbox_preferences = OtherForms.checkBox("Garlic", "Pizza", "Salami", 1, 10)

lbl_shoes = TextRelatedForms.Lbl("Do you know how to make cement shoes: ", 0, 13)
radioButton_shoes = OtherForms.Radio_button("Yes", "No", 1, 2, 1, 13)
win.mainloop()