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
            CurrentInput = "0";
            PreviousInput = "";
            CurrentOperation = "";
        }
        private void ClearEnter_Click(object sender, RoutedEventArgs e)
        {
            CurrentInput = "0";
        }
    }
}
