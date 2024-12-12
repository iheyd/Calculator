using Calculator.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Calculator.VM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        static private readonly BaseClass _baseClass = new BaseClass();
        private readonly ArithmeticOperations _arithmeticModel = new ArithmeticOperations(_baseClass);
		private readonly MemoryOperations _memoryModel = new MemoryOperations(_baseClass);
        private readonly NumbersDisplayControl _numbersDisplayModel = new NumbersDisplayControl(_baseClass);
        private readonly OperationsDisplayControl _operationDisplayModel = new OperationsDisplayControl(_baseClass);
        private readonly UnaryOperation _unaryModel= new UnaryOperation(_baseClass);
        private readonly DisplayControl _displayControlModel = new DisplayControl(_baseClass);

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

        #region memory settings
        private bool _isMemoryNotEmpty = false;
        public bool IsMemoryNotEmpty
        {
            get => _isMemoryNotEmpty;
            set
            {
                _isMemoryNotEmpty = value;
                OnPropertyChanged();
            }
        }

        private double _memoryButtonOpacity = 0.3;
        public double MemoryButtonOpacity
        {
            get => _memoryButtonOpacity;
            set
            {
                _memoryButtonOpacity = value;
                OnPropertyChanged();
            }
        }

        private bool _isMemoryMenuVisible = false;
        public bool IsMemoryMenuVisible
        {
            get => _isMemoryMenuVisible;
            set
            {
                _isMemoryMenuVisible = value;
                OnPropertyChanged();
            }
        }

        private Visibility _memoryMenuVisibility = Visibility.Collapsed;
        public Visibility MemoryMenuVisibility
        {
            get => _memoryMenuVisibility;
            set
            {
                _memoryMenuVisibility = value;
                OnPropertyChanged();
            }
        }
        #endregion

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

        #region Memory
        public ICommand MemorySaveCommand { get; }
        public ICommand MemoryClearCommand { get; }
        public ICommand MemoryRecallCommand { get; }
        public ICommand MemoryAddCommand { get; }
        public ICommand MemorySubtractCommand { get; }
        public ICommand ToggleMemoryMenuCommand { get; }
        #endregion

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
            CommaClickCommand = new RelayCommand(param => CommaClick());

            MemorySaveCommand = new RelayCommand(param => MemorySave());
            MemoryClearCommand = new RelayCommand(param => MemoryClear());
            MemoryRecallCommand = new RelayCommand(param => MemoryRecall());
            MemoryAddCommand = new RelayCommand(param => MemoryAdd());
            MemorySubtractCommand = new RelayCommand(param => MemorySubtract());
            ToggleMemoryMenuCommand = new RelayCommand(param => ToggleMemoryMenu());
        }
        #endregion

        private void UpdatePreviousDisplay() 
        {
            PreviousDisplay = _baseClass.PreviousInput + " " + _baseClass.CurrentOperation;
            if( _baseClass.Result != null)
            {
                PreviousDisplay = PreviousDisplay + " " + _baseClass.CurrentInput + " =";
            }
        }
        private void UpdateMainDisplay()
        {
            UpdatePreviousDisplay();

            if (_baseClass.Result != null) MainDisplay = _baseClass.Result;
            else MainDisplay = _baseClass.CurrentInput;

            
        }

        private void UpdateMemoryDisplay() 
        {
            MemoryDisplay = _baseClass.Memory.ToString();
        }
        private void UpdateMemoryButtons()
        {
            IsMemoryNotEmpty = _baseClass.Memory != 0;
            MemoryButtonOpacity = IsMemoryNotEmpty ? 1 : 0.3;
            UpdateMemoryDisplay();
        }
        

        #region binaryFunc

        private void Add()
        {
            _operationDisplayModel.PlusClick();
            UpdatePreviousDisplay();
        }
        private void Minus()
        {
            _operationDisplayModel.MinusClick();
            UpdatePreviousDisplay();
        }
        private void Multiply()
        {
            _operationDisplayModel.MultiplyClick();
            UpdatePreviousDisplay();
        }
        private void Percent()
        {
            _operationDisplayModel.PercentClick();
            UpdatePreviousDisplay();
        }
        private void Divide()
        {
            _operationDisplayModel.DivideClick();
            UpdatePreviousDisplay();
        }
        private void Calculate()
        {
            _arithmeticModel.Calculate();
            UpdateMainDisplay();
        }
        #endregion

        #region unaryFunc
        private void Change()
        {
            _unaryModel.ChangeOperation();
            UpdateMainDisplay();
        }
        private void Power()
        {
            _unaryModel.PowerOperation();
            UpdateMainDisplay();
        }
        private void Square()
        {
            _unaryModel.SquareOperation();
            UpdateMainDisplay();
        }
        private void Formula()
        {
            _unaryModel.FormulaOperation();
            UpdateMainDisplay();
        }
        #endregion

        #region NumbersFunc
        private void ZeroClick()
        {
            _numbersDisplayModel.ZeroClick();
            UpdateMainDisplay();
        }
        private void OneClick()
        {
            _numbersDisplayModel.OneClick();
            UpdateMainDisplay();
        }
        private void TwoClick()
        {
            _numbersDisplayModel.TwoClick();
            UpdateMainDisplay();
        }
        private void ThreeClick()
        {
            _numbersDisplayModel.ThreeClick();
            UpdateMainDisplay();
        }
        private void FourClick()
        {
            _numbersDisplayModel.FourClick();
            UpdateMainDisplay();
        }
        private void FiveClick()
        {
            _numbersDisplayModel.FiveClick();
            UpdateMainDisplay();
        }
        private void SixClick()
        {
            _numbersDisplayModel.SixClick();
            UpdateMainDisplay();
        }
        private void SevenClick()
        {
            _numbersDisplayModel.SevenClick();
            UpdateMainDisplay();
        }
        private void EightClick()
        {
            _numbersDisplayModel.EightClick();
            UpdateMainDisplay();
        }
        private void NineClick()
        {
            _numbersDisplayModel.NineClick();
            UpdateMainDisplay();
        }
        private void CommaClick()
        {
            _numbersDisplayModel.CommaClick();
            UpdateMainDisplay();
        }
        #endregion

        #region DisplayFunc
        private void ClearEnterClick()
        {
            _displayControlModel.ClearEnterClick();
            UpdateMainDisplay();
        }
        private void ClearClick()
        {
            _displayControlModel.ClearClick();
            UpdateMainDisplay();
        }
        private void BackspaceClick()
        {
            _displayControlModel.BackspaceClick();
            UpdateMainDisplay();
        }
        #endregion

        #region MemoryFunc
        private void MemorySave()
        {
            _memoryModel.MemorySave();
            UpdateMemoryButtons();
        }

        private void MemoryClear()
        {
            _memoryModel.MemoryClear();
            UpdateMemoryButtons();
        }

        private void MemoryRecall()
        {
            _memoryModel.MemoryRecall();
            UpdateMemoryButtons();
        }

        private void MemoryAdd()
        {
            _memoryModel.MemoryAdd();
            UpdateMemoryButtons();
        }

        private void MemorySubtract()
        {
            _memoryModel.MemorySubtract();
            UpdateMemoryButtons();
        }

        private void ToggleMemoryMenu()
        {
            MemoryMenuVisibility = MemoryMenuVisibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
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
