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
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void ReadyButton_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberA.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }
            int x, y, z, s, w;
            x = a / 100;
            y = a % 100 / 10;
            z = a % 100 % 10;
            s = x + y + z;
            w = x * y * z;
            Answer.Text += "сумма =" + s + "\n";
            Answer.Text += "произведение =" + w + "\n";
        }
    }
}
