using System;
using System.Collections.Generic;
using System.Data;
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

namespace calculyator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            input.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            input.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            input.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            input.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            input.Text += "6";
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            input.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            input.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            input.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            input.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            input.Text += "/";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            input.Text += "*";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            input.Text += "-";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            input.Text += "+";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            String expression = input.Text;

            DataTable dt = new DataTable();
            var result = dt.Compute(expression, "");
            output.Text = result.ToString();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            input.Text += ".";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            input.Text += "<";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            input.Text += input.Text.Substring(0, input.Text.Length - 1);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }
    }
}
