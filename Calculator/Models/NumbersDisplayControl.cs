using System.Windows;

namespace Calculator.Models
{
    internal class NumbersDisplayControl : BaseClass
    {


        public void ZeroClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "0";
            }
            else
            {
                CurrentInput += "0";
            }
        }
        public void OneClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "1";
            }
            else
            {
                CurrentInput += "1";
            }
        }
        public void TwoClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "2";
            }
            else
            {
                CurrentInput += "2";
            }
        }
        public void ThreeClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "3";
            }
            else
            {
                CurrentInput += "3";
            }
        }
        public void FourClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "4";
            }
            else
            {
                CurrentInput += "4";
            }
        }
        public void FiveClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "5";
            }
            else
            {
                CurrentInput += "5";
            }
        }
        public void SixClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "6";
            }
            else
            {
                CurrentInput += "6";
            }
        }
        public void SevenClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "7";
            }
            else
            {
                CurrentInput += "7";
            }
        }
        public void EightClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "8";
            }
            else
            {
                CurrentInput += "8";
            }
        }
        public void NineClick()
        {
            if (CurrentInput == "0")
            {
                CurrentInput = "9";
            }
            else
            {
                CurrentInput += "9";
            }
        }
        public void CommaClick()
        {
            if (!CurrentInput.Contains(","))
            {
                CurrentInput += ",";
            }
        }

    }
}
