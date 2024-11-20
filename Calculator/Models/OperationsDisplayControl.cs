using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Calculator.Models
{
    internal class OperationsDisplayControl : BaseClass
    {
        
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                _previousInput = CurrentInput;
                _currentOperation = "+";
                CurrentInput = "0";

            }
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                _previousInput = CurrentInput;
                _currentOperation = "-";
                CurrentInput = "0";

            }
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                _previousInput = CurrentInput;
                _currentOperation = "*";
                CurrentInput = "0";

            }
        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                _previousInput = CurrentInput;
                _currentOperation = "%";
                CurrentInput = "0";

            }
        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                _previousInput = CurrentInput;
                _currentOperation = "/";
                CurrentInput = "0";
            }
        }
    }
}
