using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace Calculator.Models
{
    internal class NumbersDisplayControl : BaseClass
    {
        private BaseClass _BaseClass;
        public NumbersDisplayControl(BaseClass BaseClass) 
        {
            _BaseClass = BaseClass;
        }

        public void ZeroClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                
                _BaseClass.CurrentInput = "0";
            }
            else
            {
               
                _BaseClass.CurrentInput += "0";
            }
        }
        public void OneClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "1";
            }
            else
            {
                _BaseClass.CurrentInput += "1";
                
            }
        }
        public void TwoClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "2";
            }
            else
            {
                _BaseClass.CurrentInput += "2";
            }
        }
        public void ThreeClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "3";
            }
            else
            {
                _BaseClass.CurrentInput += "3";
            }
        }
        public void FourClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "4";
            }
            else
            {
                _BaseClass.CurrentInput += "4";
            }
        }
        public void FiveClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "5";
            }
            else
            {
                _BaseClass.CurrentInput += "5";
            }
        }
        public void SixClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "6";
            }
            else
            {
                _BaseClass.CurrentInput += "6";
            }
        }
        public void SevenClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "7";
            }
            else
            {
                _BaseClass.CurrentInput += "7";
            }
        }
        public void EightClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "8";
            }
            else
            {
                _BaseClass.CurrentInput += "8";
            }
        }
        public void NineClick()
        {
            if (_BaseClass.CurrentInput == "0")
            {
                _BaseClass.CurrentInput = "9";
            }
            else
            {
                _BaseClass.CurrentInput += "9";
            }
        }
        public void CommaClick()
        {
            if (!_BaseClass.CurrentInput.Contains(","))
            {
                _BaseClass.CurrentInput += ",";
            }
        }

    }
}
