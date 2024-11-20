using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Calculator.Models
{
    internal class NumbersDisplayControl : BaseClass
    {
        

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "0";
            }
            else
            {
                _currentInput += "0";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "1";
            }
            else
            {
                _currentInput += "1";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "2";
            }
            else
            {
                _currentInput += "2";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "3";
            }
            else
            {
                _currentInput += "3";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "4";
            }
            else
            {
                _currentInput += "4";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "5";
            }
            else
            {
                _currentInput += "5";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "6";
            }
            else
            {
                _currentInput += "6";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "7";
            }
            else
            {
                _currentInput += "7";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "8";
            }
            else
            {
                _currentInput += "8";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "9";
            }
            else
            {
                _currentInput += "9";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (!_currentInput.Contains(","))
            {
                _currentInput += ",";
            }
            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput.Length > 1)
            {
                _currentInput = _currentInput.Substring(0, _currentInput.Length - 1);
            }
            else
            {
                _currentInput = "0";
            }

            UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
        }
    }
}
