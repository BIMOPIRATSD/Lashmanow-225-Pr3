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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(Text1.Text, out int x))
            {

            }
            if(x > 0 && x % 2 == 0)
            {
                Text2.Text += $"Положительное чётное число\n";
            }
            else if(x > 0 && x % 2 != 0)
            {
                Text2.Text += $"Положительное нечётное число\n";
            }
            else if(x < 0 && x % 2 == 0)
            {
                Text2.Text += $"Отрицательное чётное число\n";
            }
            else if(x < 0 && x % 2 != 0)
            {
                Text2.Text += $"Отрицательное нечётное число\n";
            }
            else
            {
                Text2.Text += $"Нулевое число\n";
            }
        }
    }
}
