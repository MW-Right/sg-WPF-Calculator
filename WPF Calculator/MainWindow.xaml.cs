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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int num1;
        static int num2;
        static string displayText;
        static string oppSymbol = "Unassigned";
        static bool firstButton = true;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "1";
                firstButton = false;
            }
            else
            {
                display.Text += "1";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "2";
                firstButton = false;
            }
            else
            {
                display.Text += "2";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "3";
                firstButton = false;
            }
            else
            {
                display.Text += "3";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "4";
                firstButton = false;
            }
            else
            {
                display.Text += "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "6";
                firstButton = false;
            }
            else
            {
                display.Text += "6";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "7";
                firstButton = false;
            }
            else
            {
                display.Text += "7";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "8";
                firstButton = false;
            }
            else
            {
                display.Text += "8";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "9";
                firstButton = false;
            }
            else
            {
                display.Text += "9";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "9";
                firstButton = false;
            }
            else
            {
                display.Text += "9";
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            display.Text = "0";
            num1 = 0;
            num2 = 0;
            firstButton = true;
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (firstButton)
            {
                display.Text = "0";
                firstButton = false;
            }
            else
            {
                display.Text += "0";
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            displayText = display.Text;
            num2 = Convert.ToInt32(displayText);
            switch (oppSymbol)
            {
                case "+":
                    display.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    display.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    display.Text = Convert.ToString(num1 * num2);
                    break;
            }
            displayText = "";
            firstButton = true;
        }

        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            displayText = display.Text;
            num1 = Convert.ToInt32(displayText);
            display.Text = "0";
            oppSymbol = "+";
            firstButton = true;
        }

        private void Button_Click_sub(object sender, RoutedEventArgs e)
        {
            displayText = display.Text;
            num1 = Convert.ToInt32(displayText);
            display.Text = "0";
            oppSymbol = "-";
            firstButton = true;
        }

        private void Button_Click_mult(object sender, RoutedEventArgs e)
        {
            displayText = display.Text;
            num1 = Convert.ToInt32(displayText);
            display.Text = "0";
            oppSymbol = "*";
            firstButton = true;
        }
    }
}
