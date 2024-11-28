using Calculator.VM;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Calculator.Views
{
    public partial class MainWindow : Window
    {
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

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            if (SideMenu.Visibility == Visibility.Collapsed)
            {
                SideMenu.Visibility = Visibility.Visible;
            }
            else
            {
                SideMenu.Visibility = Visibility.Collapsed;
            }
        }

        private void CommonButton_Click(object sender, RoutedEventArgs e)
        {
            CalcName.Text = "Обычный";
        }
        private void EngineeringButton_Click(object sender, RoutedEventArgs e)
        {
            CalcName.Text = "Инженерный";
        }

        
    }
}