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
        public void MemorySave()
        {
            _baseClass.Memory = Convert.ToDouble(_baseClass.CurrentInput.Replace(".", ","));
        }
        public void MemoryClear()
        {
            _baseClass.Memory = 0;
        }
        public void MemoryRecall()
        {
            _baseClass.CurrentInput = _baseClass.Memory.ToString().Replace(".", ",");
        }
        public void MemoryAdd()
        {
            _baseClass.Memory += Convert.ToDouble(_baseClass.CurrentInput.Replace(",", "."));
        }
        public void MemorySubtract()
        {
            _baseClass.Memory -= Convert.ToDouble(_baseClass.CurrentInput.Replace(",", "."));
        }
    }
}
