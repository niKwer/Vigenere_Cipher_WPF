﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF69442115A7B5FDF5BB521C2ECFE7E65BC2B1C4C8AF43538229050A0670C289"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPF_Cipher_Nyss;


namespace WPF_Cipher_Nyss {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 369 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenBtn;
        
        #line default
        #line hidden
        
        
        #line 379 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EncryptBtn;
        
        #line default
        #line hidden
        
        
        #line 388 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DecryptBtn;
        
        #line default
        #line hidden
        
        
        #line 398 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseBtn;
        
        #line default
        #line hidden
        
        
        #line 422 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup_uc;
        
        #line default
        #line hidden
        
        
        #line 428 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPF_Cipher_Nyss.PopupUserControl Header;
        
        #line default
        #line hidden
        
        
        #line 435 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxOriginal;
        
        #line default
        #line hidden
        
        
        #line 444 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxFinal;
        
        #line default
        #line hidden
        
        
        #line 456 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKey;
        
        #line default
        #line hidden
        
        
        #line 470 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Cipher_Nyss;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 347 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OpenBtn = ((System.Windows.Controls.Button)(target));
            
            #line 373 "..\..\MainWindow.xaml"
            this.OpenBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OpenBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 373 "..\..\MainWindow.xaml"
            this.OpenBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OpenBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 373 "..\..\MainWindow.xaml"
            this.OpenBtn.Click += new System.Windows.RoutedEventHandler(this.OpenBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EncryptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 383 "..\..\MainWindow.xaml"
            this.EncryptBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.EncryptBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 383 "..\..\MainWindow.xaml"
            this.EncryptBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.EncryptBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 383 "..\..\MainWindow.xaml"
            this.EncryptBtn.Click += new System.Windows.RoutedEventHandler(this.EncryptBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DecryptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 392 "..\..\MainWindow.xaml"
            this.DecryptBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DecryptBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 392 "..\..\MainWindow.xaml"
            this.DecryptBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DecryptBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 392 "..\..\MainWindow.xaml"
            this.DecryptBtn.Click += new System.Windows.RoutedEventHandler(this.DecryptBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 402 "..\..\MainWindow.xaml"
            this.SaveBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.SaveBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 402 "..\..\MainWindow.xaml"
            this.SaveBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.SaveBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 402 "..\..\MainWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 417 "..\..\MainWindow.xaml"
            this.CloseBtn.Click += new System.Windows.RoutedEventHandler(this.CloseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.popup_uc = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 8:
            this.Header = ((WPF_Cipher_Nyss.PopupUserControl)(target));
            return;
            case 9:
            this.TextBoxOriginal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TextBoxFinal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.TextBoxKey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.TextBoxMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

