﻿#pragma checksum "..\..\..\..\Views\InvoicesView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861F16736653DC7B4E6CDA2FB2F8C5398B2923D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Telesi.Views;


namespace Telesi.Views {
    
    
    /// <summary>
    /// InvoicesView
    /// </summary>
    public partial class InvoicesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 120 "..\..\..\..\Views\InvoicesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Buscar;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Views\InvoicesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image NewInvoP;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\InvoicesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Til;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\Views\InvoicesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrViwer;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\..\Views\InvoicesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Pp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Telesi;component/views/invoicesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\InvoicesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Buscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 129 "..\..\..\..\Views\InvoicesView.xaml"
            this.Buscar.GotFocus += new System.Windows.RoutedEventHandler(this.TBoxFA);
            
            #line default
            #line hidden
            
            #line 130 "..\..\..\..\Views\InvoicesView.xaml"
            this.Buscar.LostFocus += new System.Windows.RoutedEventHandler(this.TBoxLFA);
            
            #line default
            #line hidden
            
            #line 131 "..\..\..\..\Views\InvoicesView.xaml"
            this.Buscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.K);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NewInvoP = ((System.Windows.Controls.Image)(target));
            
            #line 147 "..\..\..\..\Views\InvoicesView.xaml"
            this.NewInvoP.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClickButtonNewA);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Til = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ScrViwer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.Pp = ((System.Windows.Controls.Border)(target));
            
            #line 176 "..\..\..\..\Views\InvoicesView.xaml"
            this.Pp.SizeChanged += new System.Windows.SizeChangedEventHandler(this.UpdateListA);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
