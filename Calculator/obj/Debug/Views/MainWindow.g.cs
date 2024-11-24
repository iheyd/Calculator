﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC54569D7CA90F53FB2B598163A3953C367CDE17BF45250AAFA197F815D620D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Calculator;
using Calculator.VM;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Calculator.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CalcName;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SideMenu;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MemoryMenu;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MemoryInput;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PreviousInput;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Display;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MemoryClearButton;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MemoryRecallButton;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MemoryMenuButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Calculator;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopPanel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 39 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 43 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaximizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 64 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NavigationButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CalcName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 69 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SideMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 82 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommonButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 85 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EngineeringButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MemoryMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.MemoryInput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.PreviousInput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.Display = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.MemoryClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\Views\MainWindow.xaml"
            this.MemoryClearButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 121 "..\..\..\Views\MainWindow.xaml"
            this.MemoryClearButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 16:
            this.MemoryRecallButton = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\Views\MainWindow.xaml"
            this.MemoryRecallButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\Views\MainWindow.xaml"
            this.MemoryRecallButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 129 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 129 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 133 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 137 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 137 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 20:
            this.MemoryMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\Views\MainWindow.xaml"
            this.MemoryMenuButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Views\MainWindow.xaml"
            this.MemoryMenuButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 161 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 161 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 165 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 165 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 169 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 169 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 178 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 178 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 182 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 182 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 186 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 186 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 190 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 190 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 194 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 194 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 198 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 198 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 202 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 202 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 206 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 206 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 210 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 210 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 214 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 214 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 218 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 218 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 222 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 222 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 226 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 226 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 230 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 230 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 234 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 234 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 238 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 238 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 242 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 242 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 246 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 246 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 250 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 250 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 254 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 254 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DigitButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

