using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.Models
{
    internal class UnaryOperation : BaseClass
    {
        public void ChangeOperation()
        {
            if (CurrentInput != "0")
            {
                if (CurrentInput.StartsWith("-"))
                {
                    CurrentInput = CurrentInput.Substring(1);
                }
                else
                {
                    CurrentInput = "-" + CurrentInput;
                }
            }
        }
        public void PowerOperation()
        {
            if (CurrentInput != "0")
            {
                double number = double.Parse(CurrentInput);
                CurrentInput = (number * number).ToString();
                //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                //previousInputTextBlock.Text = $"sqr({number})";
            }
        }
        public void SquareOperation()
        {
            if (CurrentInput != "0")
            {
                double number = double.Parse(CurrentInput);
                if (number >= 0)
                {
                    CurrentInput = Math.Sqrt(number).ToString();
                    //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                    //previousInputTextBlock.Text = $"√({number})";
                }
                else
                {
                    CurrentInput = "0";
                }
            }
        }
        public void FormulaOperation()
        {
            if (CurrentInput != "0")
            {
                double number = double.Parse(CurrentInput);
                CurrentInput = (1 / number).ToString();
                //var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                //previousInputTextBlock.Text = $"1/({number})";
            }
        }
    }
}
