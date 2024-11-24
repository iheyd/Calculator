using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Calculator.Models
{
    internal class OperationsDisplayControl
    {
        private BaseClass _baseClass;
        public OperationsDisplayControl(BaseClass baseClass) 
        {
            _baseClass = baseClass;
        }

        public void PlusClick()
        {
            if (_baseClass.CurrentInput != "0")
            {
                _baseClass.PreviousInput = _baseClass.CurrentInput;
                _baseClass.CurrentOperation = "+";
                _baseClass.CurrentInput = "0";

            }
        }
        public void MinusClick()
        {
            if (_baseClass.CurrentInput != "0")
            {
                _baseClass.PreviousInput = _baseClass.CurrentInput;
                _baseClass.CurrentOperation = "-";
                _baseClass.CurrentInput = "0";

            }
        }
        public void MultiplyClick()
        {
            if (_baseClass.CurrentInput != "0")
            {
                _baseClass.PreviousInput = _baseClass.CurrentInput;
                _baseClass.CurrentOperation = "*";
                _baseClass.CurrentInput = "0";
            }
        }
        public void PercentClick()
        {
            if (_baseClass.CurrentInput != "0")
            {
                _baseClass.PreviousInput = _baseClass.CurrentInput;
                _baseClass.CurrentOperation = "%";
                _baseClass.CurrentInput = "0";

            }
        }
        public void DivideClick()
        {
            if (_baseClass.CurrentInput != "0")
            {
                _baseClass.PreviousInput = _baseClass.CurrentInput;
                _baseClass.CurrentOperation = "/";
                _baseClass.CurrentInput = "0";
            }
        }
    }
}
