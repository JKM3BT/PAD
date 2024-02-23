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

namespace JkmGr1App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Nie_Wiem(object sender, RoutedEventArgs e)
        {
            Tekst.Text = "NIE WIEM, CO ROBIĆ";
        }

        private void Klasa(object sender, RoutedEventArgs e)
        {
            Tekst.Text = "POZOSTAŃ W KLASIE";
        }

        private void Dom(object sender, RoutedEventArgs e)
        {
            Tekst.Text = "DO DOMU";
        }
    }
}
