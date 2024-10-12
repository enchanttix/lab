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
    /// Логика взаимодействия для _3Page.xaml
    /// </summary>
    public partial class _3Page : Page
    {
        public _3Page()
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
            int sizeNumber = Int32.Parse(size.Text);
            for (int i = 0; i < sizeNumber; i++)
            {
                for (int j = 0; j < sizeNumber; j++)
                {
                    rez.Text += fillCharacter.Text+" ";
                }
                rez.Text += "\n";
            }
        }

        private void sizeKV_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sizeKV.Text))
            {
                double sizeK = double.Parse(sizeKV.Text);
                rez2.Text = Convert.ToString((sizeK * sizeK) / 2);
            }
        }
    }
}
