using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculatorByGermanLol
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Переменная первой строки, в которую вводится первое число
        /// </summary>
        public static string MainString; 
        /// <summary>
        /// переменная второй строки, в которую вводится второе число
        /// </summary>
        public string secondmainstr = "Enter the numbers";
        public double a, b, c;
        public string pl = "+";
        public string mi = "-";
        public bool bolmi, bolpl, bolinc, boldiv;
        public bool HelloWorld;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NumberOne_Click(object sender, RoutedEventArgs e)
        {
            string one = "1";
            MainString += one;
            textBlock.Text = MainString;
        }

        private void NumberTwo_Click(object sender, RoutedEventArgs e)
        {
            string two = "2";
            MainString += two;
            textBlock.Text = MainString;
        }

        private void NumberThree_Click(object sender, RoutedEventArgs e)
        {
            string three = "3";
            MainString += three;
            textBlock.Text = MainString;
        }

        private void NumberFour_Click(object sender, RoutedEventArgs e)
        {
            string four = "4";
            MainString += four;
            textBlock.Text = MainString;
        }

        private void NumberFive_Click(object sender, RoutedEventArgs e)
        {
            string five = "5";
            MainString += five;
            textBlock.Text = MainString;
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(MainString);
            if (MainString != null & MainString != "" & MainString != "-" & MainString != ".")
            {
                if (MainString == secondmainstr)
                {
                    textBlock.Text = secondmainstr;
                }
                if (bolmi == true)
                {
                    c = a - b;
                }
                if (bolpl == true)
                {
                    c = a + b;
                }
                if (bolinc == true)
                {
                    c = a * b;
                }
                if (boldiv == true)
                {
                    c = a / b;
                }
                MainString = Convert.ToString(c);
                textBlock.Text = MainString;
                secondmainstr = null;
                textBlock1.Text = "";
                action.Text = "";
                //MainString = null;
                boldiv = false;
                bolinc = false;
                bolmi = false;
                bolpl = false;
                minus.IsEnabled = true;
                plus.IsEnabled = true;
                multiply.IsEnabled = true;
                division.IsEnabled = true;
                end.IsEnabled = true;
                falsenumber.IsEnabled = true;
                Запятая.IsEnabled = true;
            }
            else
            {
                //MainString = null;
                action.Text = "";
                textBlock1.Text = "";
                textBlock.Text = secondmainstr;
                secondmainstr = "";
                boldiv = false;
                bolinc = false;
                bolmi = false;
                bolpl = false;
                minus.IsEnabled = true;
                plus.IsEnabled = true;
                multiply.IsEnabled = true;
                division.IsEnabled = true;
                end.IsEnabled = true;
                falsenumber.IsEnabled = true;
                Запятая.IsEnabled = true;
            }
        }

        private void NumberSeven_Click(object sender, RoutedEventArgs e)
        {
            string seven = "7";
            MainString += seven;
            textBlock.Text = MainString;
        }

        private void NumberEight_Click(object sender, RoutedEventArgs e)
        {
            string eight = "8";
            MainString += eight;
            textBlock.Text = MainString;
        }

        private void NumberNine_Click(object sender, RoutedEventArgs e)
        {
            string nine = "9";
            MainString += nine;
            textBlock.Text = MainString;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (MainString != null & MainString != "-")
            {
                bolinc = true;
                boldiv = false;
                bolmi = false;
                bolpl = false;
                secondmainstr = MainString;
                textBlock1.Text = secondmainstr;
                textBlock.Text = "0";
                a = Convert.ToDouble(secondmainstr);
                MainString = null;
                action.Text = "*";
                //twomain += "*";
                textBlock1.Text = secondmainstr;
                minus.IsEnabled = false;
                plus.IsEnabled = false;
                multiply.IsEnabled = false;
                division.IsEnabled = false;
                falsenumber.IsEnabled = true;
                Запятая.IsEnabled = true;
            }
            else
            {
                MainString = null;
                secondmainstr = "0";
                textBlock1.Text = "";
                textBlock.Text = "0";
                falsenumber.IsEnabled = true;
            }
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (MainString != null & MainString != "-")
            {
                bolpl = false;
                bolmi = false;
                bolinc = false;
                boldiv = true;
                secondmainstr = MainString;
                textBlock1.Text = secondmainstr;
                textBlock.Text = "0";
                a = Convert.ToDouble(secondmainstr);
                MainString = null;
                action.Text = "/";
                //twomain += "/";
                textBlock1.Text = secondmainstr;
                minus.IsEnabled = false;
                plus.IsEnabled = false;
                multiply.IsEnabled = false;
                division.IsEnabled = false;
                falsenumber.IsEnabled = true;
                Запятая.IsEnabled = true;
            }
            else
            {
                MainString = null;
                secondmainstr = "0";
                textBlock1.Text = "";
                textBlock.Text = "0";
            }
        }
        public void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "" & MainString != null)
            {
                MainString = MainString.Substring(0, MainString.Length - 1);
                // twomain = twomain.Substring(0, twomain.Length - 1);
                textBlock.Text = MainString;
                //textBlock1.Text = twomain
            }
            else
            {
                MainString = null;
                textBlock.Text = "Enter the number";
            }
        }

        private void falsenumber_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "" & MainString != null)
            {
                string minusnamber = "-";
                MainString = minusnamber + MainString;
                textBlock.Text = MainString;
                falsenumber.IsEnabled = false;
            }
            else
            {
                MainString = null;
                textBlock.Text = "0";
            }
        }

        private void Запятая_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "" & MainString != null)
            {
                MainString += ".";
                textBlock.Text = MainString;
                Запятая.IsEnabled = false;
            }
            else
            {
                MainString = null;
                textBlock.Text = "0";
            }
         }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void NumberZero_Click(object sender, RoutedEventArgs e)
        {
            string zero = "0";
            MainString += zero;
            textBlock.Text = MainString;
        }

        public void minus_Click(object sender, RoutedEventArgs e)
        {
            if (MainString != null & MainString != "-")
            {
                bolmi = true;
                bolpl = false;
                boldiv = false;
                bolinc = false;
                secondmainstr = MainString;
                textBlock1.Text = secondmainstr;
                textBlock.Text = "0";
                a = Convert.ToDouble(secondmainstr);
                MainString = null;
                action.Text = mi;
                textBlock1.Text = secondmainstr;
                minus.IsEnabled = false;
                plus.IsEnabled = false;
                multiply.IsEnabled = false;
                division.IsEnabled = false;
                falsenumber.IsEnabled = true;
                Запятая.IsEnabled = true;
            }
            else
            {
                MainString = null;
                secondmainstr = "0";
                textBlock1.Text = "";
                textBlock.Text = "0";
            }
        }

        private void NumberSix_Click(object sender, RoutedEventArgs e)
        {
            string six = "6";
            MainString += six;
            textBlock.Text = MainString;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MainString = null;
            secondmainstr = "";
            textBlock.Text = "Enter the number";
            textBlock1.Text = secondmainstr;
            action.Text = "";
            minus.IsEnabled = true;
            plus.IsEnabled = true;
            multiply.IsEnabled = true;
            division.IsEnabled = true;
            falsenumber.IsEnabled = true;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text == MainString)
            {
                if (MainString != null & MainString != "-")
                {
                    bolpl = true;
                    bolmi = false;
                    bolinc = false;
                    boldiv = false;
                    secondmainstr = MainString;
                    textBlock1.Text = secondmainstr;
                    textBlock.Text = "0";
                    a = Convert.ToDouble(MainString);
                    MainString = null;
                    //twomain += pl;
                    action.Text = pl;
                    minus.IsEnabled = false;
                    plus.IsEnabled = false;
                    multiply.IsEnabled = false;
                    division.IsEnabled = false;
                    falsenumber.IsEnabled = true;
                    Запятая.IsEnabled = true;
                }
            }
            else
            {
                MainString = null;
                secondmainstr = "0";
                textBlock1.Text = "";
                textBlock.Text = "0";
            }
        }
    }
}
