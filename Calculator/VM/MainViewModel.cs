using Calculator.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

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

        private string _mainDisplay = "1";
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

        #region Объявление функций
        public ICommand AddCommand { get; }
        public ICommand MinusCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand PercentCommand { get; }
        public ICommand DivideCommand { get; }
        public ICommand CalculateCommand { get; }
        public ICommand ChangeCommand { get; }
        public ICommand PowerCommand { get; }
        public ICommand SquareCommand { get; }
        public ICommand FormulaCommand { get; }
        
        public MainViewModel()
		{
            AddCommand = new RelayCommand(param => Add());
            MinusCommand = new RelayCommand(param => Minus());
            MultiplyCommand = new RelayCommand(param => Multiply());
            PercentCommand = new RelayCommand(param => Percent());
            DivideCommand = new RelayCommand(param => Divide());
            CalculateCommand = new RelayCommand(param => Calculate());
            ChangeCommand = new RelayCommand(param => Change());
            PowerCommand = new RelayCommand(param => Power());
            SquareCommand = new RelayCommand(param => Square());
            FormulaCommand = new RelayCommand(param => Formula());

        }
        #endregion

        private void UpdateDisplay()
        {
            _mainDisplay = _baseClass.CurrentInput;
            _previousDisplay = _baseClass.PreviousInput + _baseClass.CurrentOperation;
            _memoryDisplay = _baseClass.Memory.ToString();
        }

        #region binary

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
        #endregion

        #region unary
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
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
        #endregion

    }
}
