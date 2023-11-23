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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Text1.Text, out double a))
            {

            }
            if(!double.TryParse(Text2.Text, out double b))
            {

            }
            if (!double.TryParse(Text3.Text, out double c))
            {

            }
            if(!double.TryParse(Text4.Text, out double d))
            {

            }
            if (b == c && c == d)
            {
                Text5.Text += "1\n";
            }
            else if (a == c && a == d)
            {
                Text5.Text += "2\n";
            }
            else if (d == a && b == d)
            {
                Text5.Text += "3\n";
            }
            else
            {
                Text5.Text += "4\n";
            }
        }
    }
}
