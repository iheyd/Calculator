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

        public void Calculate()
        {
            try
            {

                if (_baseClass.Result != null)
                {
                    _baseClass.PreviousInput = _baseClass.Result;
                }

                string currentOperation = _baseClass.CurrentOperation;
                double prevInput = Convert.ToDouble(_baseClass.PreviousInput);
                double currentInput = Convert.ToDouble(_baseClass.CurrentInput);
                double result = 0;

                switch (currentOperation)
                {
                    case "+":
                        result = prevInput + currentInput;
                        break;
                    case "-":
                        result = prevInput - currentInput;
                        break;
                    case "*":
                        result = prevInput * currentInput;
                        break;
                    case "/":
                        result = prevInput / currentInput;
                        break;
                    case "%":
                        result = prevInput % currentInput;
                        break;
                }

                _baseClass.Result = result.ToString();
            }
            catch
            {
                _baseClass.CurrentInput = "0";
            }

        }
    }
}
