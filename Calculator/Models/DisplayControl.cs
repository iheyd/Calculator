using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Models
{
    internal class DisplayControl
    {
        private BaseClass _BaseClass;
        public DisplayControl(BaseClass BaseClass)
        {
            _BaseClass = BaseClass;
        }

        public void ClearClick()
        {
            _BaseClass.CurrentInput = "0";
            _BaseClass.PreviousInput = "";
            _BaseClass.CurrentOperation = "";
            _BaseClass.Result = null;
        }
        public void ClearEnterClick() //прикольная фича
        {
            _BaseClass.CurrentInput = "0";
            _BaseClass.Result = null;
        }
        public void BackspaceClick()
        {
            string inputToChange = _BaseClass.Result ?? _BaseClass.CurrentInput;
            if (inputToChange.Length > 1)
            {
                inputToChange = inputToChange.Substring(0, inputToChange.Length - 1);
            }
            else
            {
                inputToChange = "0";
            }

            if (_BaseClass.Result != null)
            {
                _BaseClass.Result = inputToChange;
            }
            else
            {
                _BaseClass.CurrentInput = inputToChange;
            }
        }
    }
}

