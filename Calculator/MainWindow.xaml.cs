using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string _currentInput = "0";  
        private string _previousInput = "";  
        private string _currentOperation = "";
        private double _memory = 0;


        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                Width = 320;
                Height = 500;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void DigitButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                var image = (Image)button.Content;
                var originalImagePath = button.Tag.ToString();
                var hoverImagePath = originalImagePath.Replace(".png", "_hover.png");
                image.Source = new BitmapImage(new Uri(hoverImagePath, UriKind.Relative));
            }
        }
        private void DigitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                var image = (Image)button.Content;
                var originalImagePath = button.Tag.ToString();
                image.Source = new BitmapImage(new Uri(originalImagePath, UriKind.Relative));
            }
        }
        private void TopPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Calculate()
        {
            try
            {
                double prev = Convert.ToDouble(_previousInput);
                double current = Convert.ToDouble(_currentInput);
                double result = 0;

                switch (_currentOperation)
                {
                    case "+":
                        result = prev + current;
                        break;
                    case "-":
                        result = prev - current;
                        break;
                    case "*":
                        result = prev * current;
                        break;
                    case "/":
                        result = prev / current;
                        break;
                    case "%":
                        result = prev % current;
                        break;
                }

                var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                previousInputTextBlock.Text += _currentInput + "=";
                _currentInput = result.ToString();
                UpdateDisplay();

                _currentOperation = "";
                _previousInput = "";
            }
            catch
            {
                _currentInput = "0";
                UpdateOperationDisplay();
                UpdateDisplay();
            }
        }
        private void UpdateDisplay()
        {
            var displayTextBlock = (TextBlock)FindName("Display");
            displayTextBlock.Text = _currentInput;
            
        }
        private void UpdateOperationDisplay()
        {
            var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
            previousInputTextBlock.Text = _previousInput + _currentOperation;
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "0";
            }
            else
            {
                _currentInput += "0";
            }
            UpdateDisplay();
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "1";
            }
            else
            {
                _currentInput += "1";
            }
            UpdateDisplay();
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "2";
            }
            else
            {
                _currentInput += "2";
            }
            UpdateDisplay();
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "3";
            }
            else
            {
                _currentInput += "3";
            }
            UpdateDisplay();
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "4";
            }
            else
            {
                _currentInput += "4";
            }
            UpdateDisplay();
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "5";
            }
            else
            {
                _currentInput += "5";
            }
            UpdateDisplay();
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "6";
            }
            else
            {
                _currentInput += "6";
            }
            UpdateDisplay();
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "7";
            }
            else
            {
                _currentInput += "7";
            }
            UpdateDisplay();
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "8";
            }
            else
            {
                _currentInput += "8";
            }
            UpdateDisplay();
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput == "0")
            {
                _currentInput = "9";
            }
            else
            {
                _currentInput += "9";
            }
            UpdateDisplay();
        }
        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (!_currentInput.Contains(","))
            {
                _currentInput += ",";
            }
            UpdateDisplay();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                if (_currentInput.StartsWith("-"))
                {
                    _currentInput = _currentInput.Substring(1);
                }
                else
                {
                    _currentInput = "-" + _currentInput;
                }
            }
            UpdateDisplay();
        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput.Length > 1)
            {
                _currentInput = _currentInput.Substring(0, _currentInput.Length - 1);
            }
            else
            {
                _currentInput = "0";
            }

            UpdateDisplay();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = "0";
            _previousInput = "";
            _currentOperation = "";
            UpdateDisplay();
            UpdateOperationDisplay();
        }
        private void ClearEnter_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = "0";
            UpdateDisplay();
            UpdateOperationDisplay();
        }
        private void Power_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                double number = double.Parse(_currentInput);
                _currentInput = (number * number).ToString();
                var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                previousInputTextBlock.Text = $"sqr({number})";
                UpdateDisplay();
            }
        }
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                double number = double.Parse(_currentInput);
                if (number >= 0)
                {
                    _currentInput = Math.Sqrt(number).ToString();
                    var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                    previousInputTextBlock.Text = $"√({number})";
                    UpdateDisplay();
                }
                else
                {
                    _currentInput = "0";
                    UpdateOperationDisplay();
                    UpdateDisplay();
                }
            }
        }
        private void Formula_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                double number = double.Parse(_currentInput);
                _currentInput = (1 / number).ToString();
                var previousInputTextBlock = (TextBlock)FindName("PreviousInput");
                previousInputTextBlock.Text = $"1/({number})";
                UpdateDisplay();
            }
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                _previousInput = _currentInput;
                _currentOperation = "+";
                _currentInput = "0";

                UpdateDisplay();
                UpdateOperationDisplay();
            }
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                _previousInput = _currentInput;
                _currentOperation = "-";
                _currentInput = "0";

                UpdateDisplay();
                UpdateOperationDisplay();
            }
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                _previousInput = _currentInput;
                _currentOperation = "*";
                _currentInput = "0";

                UpdateDisplay();
                UpdateOperationDisplay();
            }
        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                _previousInput = _currentInput;
                _currentOperation = "%";
                _currentInput = "0";

                UpdateDisplay();
                UpdateOperationDisplay();
            }
        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (_currentInput != "0")
            {
                _previousInput = _currentInput;
                _currentOperation = "/";
                _currentInput = "0";

                UpdateDisplay();
                UpdateOperationDisplay();
            }
        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
        private void MemorySave_Click(object sender, RoutedEventArgs e)
        {
            _memory = Convert.ToDouble(_currentInput.Replace(",", "."));
        }
        private void MemoryClear_Click(object sender, RoutedEventArgs e)
        {
            _memory = 0;
        }
        private void MemoryRecall_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = _memory.ToString().Replace(".", ",");
            UpdateDisplay();
        }
        private void MemoryAdd_Click(object sender, RoutedEventArgs e)
        {
            _memory += Convert.ToDouble(_currentInput.Replace(",", "."));
        }
        private void MemorySubtract_Click(object sender, RoutedEventArgs e)
        {
            _memory -= Convert.ToDouble(_currentInput.Replace(",", "."));
        }
    }
}