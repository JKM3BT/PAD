using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PodstawoweKomponenty
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

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void mybtn_Click(object sender, RoutedEventArgs e)
        {
            string msg = "";

            /*if (rbt_1.IsChecked.Value)
            {
                msg = rbt_1.Content.ToString();
            }
            if (rbt_2.IsChecked.Value)
            {
                msg = rbt_2.Content.ToString();
            }
            if (rbt_3.IsChecked.Value)
            {
                msg = rbt_3.Content.ToString();
            }*/

            /*DateTime? selectedDate = dp.SelectedDate;
            msg = selectedDate.HasValue ? selectedDate.Value.ToString() : "Nie wybrano daty";*/

            msg = ((ComboBoxItem)cBx.SelectedItem).Content.ToString();
            MessageBox.Show(msg);
        }
    }
}