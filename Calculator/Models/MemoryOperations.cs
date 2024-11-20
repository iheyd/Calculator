using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Models
{
    internal class MemoryOperations : BaseClass
    {
        private void UpdateMemoryButtons()
        {
            bool isMemoryNotEmpty = _memory != 0;

            MemoryClearButton.IsEnabled = isMemoryNotEmpty;
            MemoryRecallButton.IsEnabled = isMemoryNotEmpty;
            MemoryMenuButton.IsEnabled = isMemoryNotEmpty;

            MemoryClearButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;
            MemoryRecallButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;
            MemoryMenuButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;

            if (!isMemoryNotEmpty)
            {
                MemoryMenu.Visibility = Visibility.Collapsed;
            }

            private void MemorySave_Click(object sender, RoutedEventArgs e)
            {
                _memory = Convert.ToDouble(_currentInput.Replace(",", "."));
                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
                UpdateMemoryButtons();
            }
            private void MemoryClear_Click(object sender, RoutedEventArgs e)
            {
                _memory = 0;
                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
                UpdateMemoryButtons();
            }
            private void MemoryRecall_Click(object sender, RoutedEventArgs e)
            {
                _currentInput = _memory.ToString().Replace(",", ".");
                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
                UpdateMemoryButtons();
            }
            private void MemoryAdd_Click(object sender, RoutedEventArgs e)
            {
                _memory += Convert.ToDouble(_currentInput.Replace(",", "."));
                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
            }
            private void MemorySubtract_Click(object sender, RoutedEventArgs e)
            {
                _memory -= Convert.ToDouble(_currentInput.Replace(",", "."));
                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
            }
            private void MemoryMenu_Click(object sender, RoutedEventArgs e)
            {
                if (MemoryMenu.Visibility == Visibility.Collapsed)
                {
                    MemoryMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    MemoryMenu.Visibility = Visibility.Collapsed;
                }

                UpdateDisplay(_currentInput, _previousInput, _currentOperation, _memory);;
                UpdateMemoryButtons();
            }
        }
    }
}
