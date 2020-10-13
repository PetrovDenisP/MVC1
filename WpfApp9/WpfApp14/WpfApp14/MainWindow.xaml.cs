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

namespace WpfApp14
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
        public void computation()
        {
            string text1 = Num1TextBox.Text.Trim();
            string text2 = Num2TextBox.Text.Trim();
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(text1);
                num2 = Convert.ToInt32(text2);
            }
            catch (Exception) { }
            Calculate(num1, num2);
        }
        public void Calculate(int num1, int num2)
        {
            switch (symbol.Text)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / (double)num2;
                    break;
                case "%":
                    result = num1 / (double)num2 * 100;
                    break;
                case "√":
                    result = Math.Sqrt((double)num1);
                    break;
                case "x^y":
                    result = Math.Pow(num1, num2);
                    break;
                case "n!":
                    result = 1;
                    for (int i = num1; i > 0; i--)
                        result *= i;
                    break;
                case "sin":
                    result = Math.Sin(num1);
                    break;
                case "cos":
                    result = Math.Cos(num1);
                    break;
                case "tan":
                    result = Math.Tan(num1);
                    break;
                case "log":
                    result = Math.Log10(num1);
                    break;
                case "ln":
                    result = Math.Log(num1);
                    break;
                default:
                    break;
            }

            UpdateView();
        }

        double result;

        public void UpdateView()
        {
            ResultTextBlock.Text = result.ToString();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "+";
            computation();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "-";
            computation();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "*";
            computation();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "/";
            computation();
        }

        private void percentButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "%";
            computation();
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "√";
            computation();
        }

        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "x^y";
            computation();
        }

        private void FButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "n!";
            computation();
        }

        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "sin";
            computation();
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "cos";
            computation();
        }

        private void TanButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "tan";
            computation();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "log";
            computation();
        }

        private void LnButton_Click(object sender, RoutedEventArgs e)
        {
            symbol.Text = "ln";
            computation();
        }
    }
}