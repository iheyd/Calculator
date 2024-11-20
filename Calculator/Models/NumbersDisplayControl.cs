using System.Windows;

namespace Calculator.Models
{
    internal class NumbersDisplayControl : BaseClass
    {
        

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "0";
            }
            else
            {
                CurrentInput += "0";
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "1";
            }
            else
            {
                CurrentInput += "1";
            }
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "2";
            }
            else
            {
                CurrentInput += "2";
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "3";
            }
            else
            {
                CurrentInput += "3";
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "4";
            }
            else
            {
                CurrentInput += "4";
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "5";
            }
            else
            {
                CurrentInput += "5";
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "6";
            }
            else
            {
                CurrentInput += "6";
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "7";
            }
            else
            {
                CurrentInput += "7";
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "8";
            }
            else
            {
                CurrentInput += "8";
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "9";
            }
            else
            {
                CurrentInput += "9";
            }
        }
        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (!CurrentInput.Contains(","))
            {
                CurrentInput += ",";
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput.Length > 1)
            {
                CurrentInput = CurrentInput.Substring(0, CurrentInput.Length - 1);
            }
            else
            {
                CurrentInput = "0";
            }

        }
    }
}
