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
            /*
            bool isMemoryNotEmpty = Memory != 0;

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

            private void MemorySave_Click()
            {
                Memory = Convert.ToDouble(CurrentInput.Replace(",", "."));
                UpdateMemoryButtons();
            }
            private void MemoryClear_Click()
            {
                Memory = 0;
                UpdateMemoryButtons();
            }
            private void MemoryRecall_Click()
            {
                CurrentInput = Memory.ToString().Replace(",", ".");
                UpdateMemoryButtons();
            }
            private void MemoryAdd_Click()
            {
                Memory += Convert.ToDouble(CurrentInput.Replace(",", "."));
            }
            private void MemorySubtract_Click()
            {
                Memory -= Convert.ToDouble(CurrentInput.Replace(",", "."));
            }
            private void MemoryMenu_Click()
            {
                if (MemoryMenu.Visibility == Visibility.Collapsed)
                {
                    MemoryMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    MemoryMenu.Visibility = Visibility.Collapsed;
                }

                UpdateMemoryButtons();
            }
            */
        }
    }
}
