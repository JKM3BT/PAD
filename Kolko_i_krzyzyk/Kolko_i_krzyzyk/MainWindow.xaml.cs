using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kolko_i_krzyzyk
{
    public partial class MainWindow : Window
    {
        private Button[] btns = new Button[16];
        private bool IsPlayerTurn { get; set; }
        private int Counter { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            InitializeBtnArray();
        }

        private void InitializeBtnArray()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = FindName($"btn{i}") as Button;
                btns[i].Background = Brushes.White;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.Content == "O" || button.Content == "X")
            {
                return;
            } else {
                button.Background = IsPlayerTurn ? Brushes.DeepSkyBlue : Brushes.Goldenrod;
                button.Content = IsPlayerTurn ? "O" : "X";

                if (btn0.Content == "X" && btn4.Content == "X" && btn8.Content == "X" && btn12.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn1.Content == "X" && btn5.Content == "X" && btn9.Content == "X" && btn13.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn2.Content == "X" && btn6.Content == "X" && btn10.Content == "X" && btn14.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn3.Content == "X" && btn7.Content == "X" && btn11.Content == "X" && btn15.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }

                if (btn0.Content == "X" && btn1.Content == "X" && btn2.Content == "X" && btn3.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn4.Content == "X" && btn5.Content == "X" && btn6.Content == "X" && btn7.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn8.Content == "X" && btn9.Content == "X" && btn10.Content == "X" && btn11.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn12.Content == "X" && btn13.Content == "X" && btn14.Content == "X" && btn15.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }

                if (btn0.Content == "X" && btn5.Content == "X" && btn10.Content == "X" && btn15.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn3.Content == "X" && btn6.Content == "X" && btn9.Content == "X" && btn12.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }


                if (btn0.Content == "X" && btn4.Content == "X" && btn8.Content == "X" && btn12.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn1.Content == "X" && btn5.Content == "X" && btn9.Content == "X" && btn13.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn2.Content == "X" && btn6.Content == "X" && btn10.Content == "X" && btn14.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }
                if (btn3.Content == "X" && btn7.Content == "X" && btn11.Content == "X" && btn15.Content == "X")
                {
                    MessageBox.Show("Wygrywa gracz 1");
                    Close();
                }


                if (btn0.Content == "O" && btn4.Content == "O" && btn8.Content == "O" && btn12.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn1.Content == "O" && btn5.Content == "O" && btn9.Content == "O" && btn13.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn2.Content == "O" && btn6.Content == "O" && btn10.Content == "O" && btn14.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn3.Content == "O" && btn7.Content == "O" && btn11.Content == "O" && btn15.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }

                if (btn0.Content == "O" && btn1.Content == "O" && btn2.Content == "O" && btn3.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn4.Content == "O" && btn5.Content == "O" && btn6.Content == "O" && btn7.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn8.Content == "O" && btn9.Content == "O" && btn10.Content == "O" && btn11.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn12.Content == "O" && btn13.Content == "O" && btn14.Content == "O" && btn15.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }

                if (btn0.Content == "O" && btn5.Content == "O" && btn10.Content == "O" && btn15.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                if (btn3.Content == "O" && btn6.Content == "O" && btn9.Content == "O" && btn12.Content == "O")
                {
                    MessageBox.Show("Wygrywa gracz 2");
                    Close();
                }
                IsPlayerTurn = !IsPlayerTurn;
            }
        }
    }
}
