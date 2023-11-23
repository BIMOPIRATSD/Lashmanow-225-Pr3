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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int x))
            {

            }
            if (x >= 1 && x <= 9 && x % 2 == 0)
            {
                Text2.Text += $"Однозначное чётное число\n";
            }
            else if (x >= 1 && x <= 9 && x % 2 != 0)
            {
                Text2.Text += $"Однозначное нечётное число\n";
            }
            else if (x >= 10 && x <= 99 && x % 2 == 0)
            {
                Text2.Text += $"Двузначное чётное число\n";
            }
            else if (x >= 10 && x <= 99 && x % 2 != 0)
            {
                Text2.Text += $"Двузначное нечётное число\n";
            }
            else if(x >= 100 && x <= 999 && x % 2 == 0)
            {
                Text2.Text += $"Трёхзначное чётное число\n";
            }
            else
            {
                Text2.Text += $"Трёхзначное нечётное число\n";
            }
        }
    }
}
