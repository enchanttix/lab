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
    /// Логика взаимодействия для _9Page.xaml
    /// </summary>
    public partial class _9Page : Page
    {
        Random random = new Random();
        public _9Page()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frame.Navigate(new MainPage());
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            arr1.Text = "";
            arr2.Text = "";
            arr3.Text = "";
            int sizeArr = Int32.Parse(size.Text);
            int[] arr = new int[sizeArr];
            for (int i = 0; i < sizeArr; i++)
            {
                arr[i] = random.Next(0, 99);
                arr1.Text += arr[i]+" ";
            }

            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < sizeArr; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            for (int i = 0; i < sizeArr; i++)
            {
                arr2.Text += arr[i] + " ";
            }

            double average = arr.Average();
            var greaterThanAverage = new List<int>();
            var lessThanAverage = new List<int>();
            foreach (var item in arr)
            {
                if (item > average)
                {
                    greaterThanAverage.Add(item);
                }
                else
                {
                    lessThanAverage.Add(item);
                }
            }
            int[] greaterArray = greaterThanAverage.ToArray();
            int[] lesserArray = lessThanAverage.ToArray();
            for (int i = 0; i < sizeArr; i++)
            {
                arr3.Text += arr[i] + " ";
            }
        }
    }
}
