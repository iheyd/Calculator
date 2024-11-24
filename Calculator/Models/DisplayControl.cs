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
        }
        public void ClearEnterClick()
        {
            _BaseClass.CurrentInput = "0";
        }
        public void BackspaceClick()
        {
            if (_BaseClass.CurrentInput.Length > 1)
            {
                _BaseClass.CurrentInput = _BaseClass.CurrentInput.Substring(0, _BaseClass.CurrentInput.Length - 1);
            }
            else
            {
                _BaseClass.CurrentInput = "0";
            }

        }
    }
}

