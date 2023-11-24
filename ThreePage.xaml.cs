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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для ThreePage.xaml
    /// </summary>
    public partial class ThreePage : Page
    {
        public ThreePage()
        {
            InitializeComponent();
        }

        private void ReadyButton_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberK.Text, out int k))
            {
                MessageBox.Show("Введите число!");
            }
            int day;

            day = k % 7;

            Answer.Text += $"{day}\n";
        }
    }
}
