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
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = "0";
            _previousInput = "";
            _currentOperation = "";
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void ClearEnter_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = "0";
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
    }
}
