using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.Models
{
    public class BaseClass
    {

        private string _currentInput = "0";
        private string _previousInput = "";
        private string _currentOperation = "";
        private string _result = null;
        private double _memory = 0;

        public string CurrentInput {  get { return _currentInput; } set {  _currentInput = value; } }
        public string PreviousInput {  get { return _previousInput; } set { _previousInput = value; } }
        public string CurrentOperation { get { return _currentOperation; } set { _currentOperation = value; } }
        public string Result { get { return _result; } set { _result = value; } }
        public double Memory { get { return _memory; } set { _memory = value; } }
        
    }
}
