using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Models
{
    internal class DisplayControl : BaseClass
    {
        public void ClearClick()
        {
            CurrentInput = "0";
            PreviousInput = "";
            CurrentOperation = "";
        }
        public void ClearEnterClick()
        {
            CurrentInput = "0";
        }
        public void BackspaceClick()
        {
            if (CurrentInput.Length > 1)
            {
                CurrentInput = CurrentInput.Substring(0, CurrentInput.Length - 1);
            }
            else
            {
                CurrentInput = "0";
            }

        }
    }
}

