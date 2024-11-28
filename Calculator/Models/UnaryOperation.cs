using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.Models
{
    internal class UnaryOperation
    {

        private BaseClass _BaseClass;
        public UnaryOperation(BaseClass BaseClass)
        {
            _BaseClass = BaseClass;
        }

        public void ChangeOperation()
        {
            if (_BaseClass.CurrentInput != "0")
            {
                if (_BaseClass.CurrentInput.StartsWith("-"))
                {
                    _BaseClass.CurrentInput = _BaseClass.CurrentInput.Substring(1);
                }
                else
                {
                    _BaseClass.CurrentInput = "-" + _BaseClass.CurrentInput;
                }
            }
        }
        public void PowerOperation()
        {
            if (_BaseClass.CurrentInput != "0")
            {
                double number = double.Parse(_BaseClass.CurrentInput);
                _BaseClass.CurrentInput = (number * number).ToString();
                //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                //previousInputTextBlock.Text = $"sqr({number})";
            }
        }
        public void SquareOperation()
        {
            if (_BaseClass.CurrentInput != "0")
            {
                double number = double.Parse(_BaseClass.CurrentInput);
                if (number >= 0)
                {
                    _BaseClass.CurrentInput = Math.Sqrt(number).ToString();
                    //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                    //previousInputTextBlock.Text = $"√({number})";
                }
                else
                {
                    _BaseClass.CurrentInput = "0";
                }
            }
        }
        public void FormulaOperation()
        {
            if (_BaseClass.CurrentInput != "0")
            {
                double number = double.Parse(_BaseClass.CurrentInput);
                _BaseClass.CurrentInput = (1 / number).ToString();
                //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                //previousInputTextBlock.Text = $"1/({number})";
            }
        }
    }
}
