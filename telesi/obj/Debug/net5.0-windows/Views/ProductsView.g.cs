﻿#pragma checksum "..\..\..\..\Views\ProductsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E79F7C7347C592E3038E9EA0ECB1D6BF2201F0CD"
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
    /// ProductsView
    /// </summary>
    public partial class ProductsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 120 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Buscar;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SaveLogButton;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image NewInvoP;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Tls;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrViwer_;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\Views\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Pp_;
        
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
            System.Uri resourceLocater = new System.Uri("/Telesi;component/views/productsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ProductsView.xaml"
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
            
            #line 129 "..\..\..\..\Views\ProductsView.xaml"
            this.Buscar.GotFocus += new System.Windows.RoutedEventHandler(this.TBoxF);
            
            #line default
            #line hidden
            
            #line 130 "..\..\..\..\Views\ProductsView.xaml"
            this.Buscar.LostFocus += new System.Windows.RoutedEventHandler(this.TBoxLF);
            
            #line default
            #line hidden
            
            #line 131 "..\..\..\..\Views\ProductsView.xaml"
            this.Buscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.K);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SaveLogButton = ((System.Windows.Controls.Image)(target));
            
            #line 138 "..\..\..\..\Views\ProductsView.xaml"
            this.SaveLogButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClickButtonSave);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 144 "..\..\..\..\Views\ProductsView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClickButtonSave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewInvoP = ((System.Windows.Controls.Image)(target));
            
            #line 156 "..\..\..\..\Views\ProductsView.xaml"
            this.NewInvoP.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClickButtonNew);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tls = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.ScrViwer_ = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 7:
            this.Pp_ = ((System.Windows.Controls.Border)(target));
            
            #line 186 "..\..\..\..\Views\ProductsView.xaml"
            this.Pp_.SizeChanged += new System.Windows.SizeChangedEventHandler(this.UpdateList);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

