using Calculator.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Calculator.VM
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private readonly ArithmeticOperations _arithmeticModel = new ArithmeticOperations();
		private readonly MemoryOperations _memoryModel = new MemoryOperations();
        private readonly NumbersDisplayControl _numbersDisplayModel = new NumbersDisplayControl();
        private readonly OperationsDisplayControl _operationDisplayModel = new OperationsDisplayControl();
        private readonly UnaryOperation _unaryModel= new UnaryOperation();
        private readonly DisplayControl _displayControlModel = new DisplayControl();
        private readonly BaseClass _baseClass = new BaseClass();

        private string _mainDisplay = "0";
		public string MainDisplay
		{
			get => _mainDisplay;
			set
			{
				_mainDisplay = value;
				OnPropertyChanged();
			}
		}

        private string _memoryDisplay = "";
        public string MemoryDisplay
        {
            get => _memoryDisplay;
            set
            {
                _memoryDisplay = value;
                OnPropertyChanged();
            }
        }

        private string _previousDisplay = "";
        public string PreviousDisplay
        {
            get => _previousDisplay;
            set
            {
                _previousDisplay = value;
                OnPropertyChanged();
            }
        }

        #region Объявление функций
        #region Операции
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
        #endregion

        #region Числа на экран
        public ICommand ZeroClickCommand { get; }
        public ICommand OneClickCommand { get; }
        public ICommand TwoClickCommand { get; }
        public ICommand ThreeClickCommand { get; }
        public ICommand FourClickCommand { get; }
        public ICommand FiveClickCommand { get; }
        public ICommand SixClickCommand { get; }
        public ICommand SevenClickCommand { get; }
        public ICommand EightClickCommand { get; }
        public ICommand NineClickCommand { get; }
        public ICommand CommaClickCommand { get; }
        public ICommand ClearEnterClickCommand { get; }
        public ICommand ClearClickCommand { get; }
        public ICommand BackspaceClickCommand { get; }
        #endregion

        public MainViewModel()
		{
            #region OperandsCommand
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
            #endregion

            #region NumbersCommand
            ZeroClickCommand = new RelayCommand(param => ZeroClick());
            OneClickCommand = new RelayCommand(param => OneClick());
            TwoClickCommand = new RelayCommand(param => TwoClick());
            ThreeClickCommand = new RelayCommand(param => ThreeClick());
            FourClickCommand = new RelayCommand(param => FourClick());
            FiveClickCommand = new RelayCommand(param => FiveClick());
            SixClickCommand = new RelayCommand(param => SixClick());
            SevenClickCommand = new RelayCommand(param => SevenClick());
            EightClickCommand = new RelayCommand(param => EightClick());
            NineClickCommand = new RelayCommand(param => NineClick());
            ClearEnterClickCommand = new RelayCommand(param => ClearEnterClick());
            ClearClickCommand = new RelayCommand(param => ClearClick());
            BackspaceClickCommand = new RelayCommand(param => BackspaceClick());
            #endregion
        }
        #endregion

        private void UpdateDisplay()
        {
            _mainDisplay = _baseClass.CurrentInput;
            _previousDisplay = _baseClass.PreviousInput + _baseClass.CurrentOperation;
            _memoryDisplay = _baseClass.Memory.ToString();
        }

        #region binaryFunc

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

        #region unaryFunc
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

        #region NumbersFunc
        private void ZeroClick()
        {
            _numbersDisplayModel.ZeroClick();
            UpdateDisplay();
        }
        private void OneClick()
        {
            _numbersDisplayModel.OneClick();
            UpdateDisplay();
        }
        private void TwoClick()
        {
            _numbersDisplayModel.TwoClick();
            UpdateDisplay();
        }
        private void ThreeClick()
        {
            _numbersDisplayModel.ThreeClick();
            UpdateDisplay();
        }
        private void FourClick()
        {
            _numbersDisplayModel.FourClick();
            UpdateDisplay();
        }
        private void FiveClick()
        {
            _numbersDisplayModel.FiveClick();
            UpdateDisplay();
        }
        private void SixClick()
        {
            _numbersDisplayModel.SixClick();
            UpdateDisplay();
        }
        private void SevenClick()
        {
            _numbersDisplayModel.SevenClick();
            UpdateDisplay();
        }
        private void EightClick()
        {
            _numbersDisplayModel.EightClick();
            UpdateDisplay();
        }
        private void NineClick()
        {
            _numbersDisplayModel.NineClick();
            UpdateDisplay();
        }
        private void CommaClick()
        {
            _numbersDisplayModel.CommaClick();
            UpdateDisplay();
        }
        #endregion

        #region DisplayFunc
        private void ClearEnterClick()
        {
            _displayControlModel.ClearEnterClick();
            UpdateDisplay();
        }
        private void ClearClick()
        {
            _displayControlModel.ClearClick();
            UpdateDisplay();
        }
        private void BackspaceClick()
        {
            _displayControlModel.BackspaceClick();
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
