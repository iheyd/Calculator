using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.Models
{
    internal class ArithmeticOperations : BaseClass
    {

        
        /// <summary>
        /// Поменять single responsability
        /// </summary>
        public void Calculate() 
        {
            try
            {
                double prev = Convert.ToDouble(PreviousInput);
                double current = Convert.ToDouble(CurrentInput);
                double result = 0;

                switch (CurrentOperation)
                {
                    case "+":
                        result = prev + current;
                        break;
                    case "-":
                        result = prev - current;
                        break;
                    case "*":
                        result = prev * current;
                        break;
                    case "/":
                        result = prev / current;
                        break;
                    case "%":
                        result = prev % current;
                        break;
                }

                //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                //previousInputTextBlock.Text += _currentInput + "=";
                CurrentInput = result.ToString();
                CurrentOperation = "";
                PreviousInput = "";
            }
            catch
            {
                CurrentInput = "0";
            }

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
        
    }
}
