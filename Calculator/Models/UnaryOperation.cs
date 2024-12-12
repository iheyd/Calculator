using System;
using System.Xml.Serialization;

namespace Calculator.Models
{
    internal class UnaryOperation
    {

        private BaseClass _BaseClass;
        public UnaryOperation(BaseClass BaseClass)
        {
            _BaseClass = BaseClass;
        }

        public void switcher(String inputToChange)
        {
            if (_BaseClass.Result != null)
            {
                _BaseClass.Result = inputToChange;
            }
            else
            {
                _BaseClass.CurrentInput = inputToChange;
            }
        }

        public void ChangeOperation()
        {
            string inputToChange = _BaseClass.Result ?? _BaseClass.CurrentInput;

            if (inputToChange != "0")
            {
                if (inputToChange.StartsWith("-"))
                {
                    inputToChange = inputToChange.Substring(1);
                }
                else
                {
                    inputToChange = "-" + inputToChange;
                }
            }

            switcher(inputToChange);
        }

        public void PowerOperation()
        {
            string inputToChange = _BaseClass.Result ?? _BaseClass.CurrentInput;

            if (inputToChange != "0")
            {
                double number = double.Parse(inputToChange);
                inputToChange = (number * number).ToString();
            }
            switcher(inputToChange);
        }
        public void SquareOperation()
        {
            string inputToChange = _BaseClass.Result ?? _BaseClass.CurrentInput;

            if (inputToChange != "0")
            {
                double number = double.Parse(inputToChange);
                if (number >= 0)
                {
                    inputToChange = Math.Sqrt(number).ToString();
                }
                else
                {
                    inputToChange = "0";
                }
            }

            switcher(inputToChange);
        }
        public void FormulaOperation()
        {
            string inputToChange = _BaseClass.Result ?? _BaseClass.CurrentInput;

            if (inputToChange != "0")
            {
                double number = double.Parse(inputToChange);
                inputToChange = (1 / number).ToString();
            }

            switcher(inputToChange);
        }
    }
}
