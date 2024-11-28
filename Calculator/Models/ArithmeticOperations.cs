using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.Models
{
    internal class ArithmeticOperations
    {

        private BaseClass _baseClass;
        public ArithmeticOperations(BaseClass baseClass)
        {
            _baseClass = baseClass;
        }

        /// <summary>
        /// Поменять single responsability
        /// </summary>
        public void Calculate() 
        {
            try
            {
                double prev = Convert.ToDouble(_baseClass.PreviousInput);
                double current = Convert.ToDouble(_baseClass.CurrentInput);
                double result = 0;

                switch (_baseClass.CurrentOperation)
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
                _baseClass.CurrentInput = result.ToString();
                _baseClass.CurrentOperation = "";
                _baseClass.PreviousInput = "";
            }
            catch
            {
                _baseClass.CurrentInput = "0";
            }

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
        
    }
}
