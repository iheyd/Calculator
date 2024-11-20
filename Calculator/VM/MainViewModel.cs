using Calculator.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.VM
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private readonly ArithmeticOperations _arithmeticModel = new ArithmeticOperations();
		private readonly WindowControl _windowModel = new WindowControl();
		private readonly MemoryOperations _memoryModel = new MemoryOperations();
        private readonly NumbersDisplayControl _numbersDisplayModel = new NumbersDisplayControl();
        private readonly OperationsDisplayControl _operationDisplayModel = new OperationsDisplayControl();
        private readonly UnaryOperation _unaryModel= new UnaryOperation();
        private readonly WindowControl _displayModel = new WindowControl();
        private readonly BaseClass _baseClass = new BaseClass();

        private string _mainDisplay = "0";
		public string mainDisplay
		{
			get => _mainDisplay;
			set
			{
				_mainDisplay = value;
				OnPropertyChanged();
			}
		}

        private string _memoryDisplay = "";
        public string memoryDisplay
        {
            get => _memoryDisplay;
            set
            {
                _memoryDisplay = value;
                OnPropertyChanged();
            }
        }

        private string _previousDisplay = "";
        public string previousDisplay
        {
            get => _previousDisplay;
            set
            {
                _previousDisplay = value;
                OnPropertyChanged();
            }
        }

        /*
        /// <summary>
        /// Нахуя
        /// </summary>
        
        public MainViewModel(ArithmeticOperations arithmeticModel, WindowControl windowModel, MemoryOperations memoryModel,
            NumbersDisplayControl numbersDisplayModel, OperationsDisplayControl operationDisplayModel, UnaryOperation unaryModel,
            WindowControl displayModel, BaseClass baseClass)
		{
            _arithmeticModel = arithmeticModel;
            _windowModel = windowModel;
            _memoryModel = memoryModel;
            _numbersDisplayModel = numbersDisplayModel;
            _operationDisplayModel = operationDisplayModel;
            _unaryModel = unaryModel;
            _displayModel = displayModel;
            _baseClass = baseClass;
        }*/


        //public ICommand Add { get; }

        //binary
        private void UpdateDisplay()
        {
            _mainDisplay = _baseClass.CurrentInput;
            _previousDisplay = _baseClass.PreviousInput + _baseClass.CurrentOperation;
            _memoryDisplay = _baseClass.Memory.ToString();
        }
        private void Add()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        private void Minus()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        private void Multiply()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        private void Percent()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        private void Divide()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        private void Calculate()
        {
            _arithmeticModel.Calculate();
            UpdateDisplay();
        }
        /// <summary>
        /// 1/x
        /// </summary>


        //unary
        private void Change()
        {
            _unaryModel.ChangeOperation();
            UpdateDisplay();
        }
        private void Power()
        {
            _unaryModel.PowerOperation();
            UpdateDisplay();
        }
        private void Square()
        {
            _unaryModel.SquareOperation();
            UpdateDisplay();
        }
        private void Formula()
        {
            _unaryModel.FormulaOperation();
            UpdateDisplay();
        }
        
        

        /////////////////////////////////
        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
