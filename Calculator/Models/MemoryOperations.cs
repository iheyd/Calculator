using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Models
{
    internal class MemoryOperations
    {
        public BaseClass _baseClass;
        public MemoryOperations(BaseClass baseClass)
        {
            _baseClass = baseClass;
        }

        public void UpdateMemoryButtons()
        {

            bool isMemoryNotEmpty = _baseClass.Memory != 0;

            //MemoryClearButton.IsEnabled = isMemoryNotEmpty;
            //MemoryRecallButton.IsEnabled = isMemoryNotEmpty;
            //MemoryMenuButton.IsEnabled = isMemoryNotEmpty;

            //MemoryClearButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;
            //MemoryRecallButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;
            //MemoryMenuButton.Opacity = isMemoryNotEmpty ? 1 : 0.3;

            //if (!isMemoryNotEmpty)
            //{
            //    MemoryMenu.Visibility = Visibility.Collapsed;
            //}
        }
        public void MemorySave()
        {
            _baseClass.Memory = Convert.ToDouble(_baseClass.CurrentInput.Replace(",", "."));
            UpdateMemoryButtons();
        }
        public void MemoryClear()
        {
            _baseClass.Memory = 0;
            UpdateMemoryButtons();
        }
        public void MemoryRecall()
        {
            _baseClass.CurrentInput = _baseClass.Memory.ToString().Replace(",", ".");
            UpdateMemoryButtons();
        }
        public void MemoryAdd()
        {
            _baseClass.Memory += Convert.ToDouble(_baseClass.CurrentInput.Replace(",", "."));
        }
        public void MemorySubtract()
        {
            _baseClass.Memory -= Convert.ToDouble(_baseClass.CurrentInput.Replace(",", "."));
        }
            //void MemoryMenu_Click()
            //{
            //    if (MemoryMenu.Visibility == Visibility.Collapsed)
            //    {
            //        MemoryMenu.Visibility = Visibility.Visible;
            //    }
            //    else
            //    {
            //        MemoryMenu.Visibility = Visibility.Collapsed;
            //    }

            //    UpdateMemoryButtons();
            //}
    }
}
