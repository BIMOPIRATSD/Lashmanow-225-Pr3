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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Text1.Text, out double x))
            {

            }
            if(!double.TryParse(Text2.Text, out double y))
            {

            }
            if (x > 0 && x < 70 && y < x && y < 70 && y > 0)
            {
                Text3.Text += $"Лежит в области\n";
            }
            else if (x >= 0 && x <= 70 && y <= x && y <= 70 && y >= 0)
            {
                Text3.Text += $"Лежит на границе\n";
            }
            else
            {
                Text3.Text += $"Не лежит в области\n";
            }
        }
    }
}
