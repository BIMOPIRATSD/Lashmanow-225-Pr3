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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double y;
            if(!double.TryParse(Text1.Text, out double x))
            {

            }
            if ((-PI / 2) < x && x < (PI / 2))
            {
                y = Sqrt(Abs(Sin(x) + Pow(Tan(x), 2) / 3.5 * Cos(x)));
                Text2.Text += $"{y}\n";
            }
            else if ((PI / 2) < x && x < PI)
            {
                y = Cos(x / 3) / (Sin(x) + Pow(Tan(x), 2));
                Text2.Text += $"{y}\n";
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
