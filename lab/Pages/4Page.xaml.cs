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

namespace lab.Pages
{
    /// <summary>
    /// Логика взаимодействия для _4Page.xaml
    /// </summary>
    public partial class _4Page : Page
    {
        public _4Page()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frame.Navigate(new MainPage());
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            rez.Text = "";
            string tr = "Среди введенных значений есть нечетное число";
            string fl = "Среди введенных значений нет нечетного числа";
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);
            int c = Int32.Parse(num3.Text);
            int d = Int32.Parse(num4.Text);
            if (a % 2 != 0)
            {
                rez.Text = tr;
            }
            else if (b % 2 != 0)
            {
                rez.Text = tr;
            }
            else if (c % 2 != 0)
            {
                rez.Text = tr;
            }
            else if (d % 2 != 0)
            {
                rez.Text = tr;
            }
            else
            {
                rez.Text = fl;
            }
        }
    }
}
