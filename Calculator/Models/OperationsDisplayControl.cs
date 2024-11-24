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
        
        public void PlusClick(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                PreviousInput = CurrentInput;
                CurrentOperation = "+";
                CurrentInput = "0";

            }
        }
        public void MinusClick(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                PreviousInput = CurrentInput;
                CurrentOperation = "-";
                CurrentInput = "0";

            }
        }
        public void MultiplyClick(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                PreviousInput = CurrentInput;
                CurrentOperation = "*";
                CurrentInput = "0";

            }
        }
        public void PercentClick(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                PreviousInput = CurrentInput;
                CurrentOperation = "%";
                CurrentInput = "0";

            }
        }
        public void DivideClick(object sender, RoutedEventArgs e)
        {
            if (CurrentInput != "0")
            {
                PreviousInput = CurrentInput;
                CurrentOperation = "/";
                CurrentInput = "0";
            }
        }
    }
}
