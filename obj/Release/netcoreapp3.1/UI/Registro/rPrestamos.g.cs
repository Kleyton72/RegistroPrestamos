﻿#pragma checksum "..\..\..\..\..\UI\Registro\rPrestamos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1CF0382ACB386DBAA7D464A450A793E8C33BF53C"
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


namespace RegistroPrestamos.UI.Registro {
    
    
    /// <summary>
    /// rPrestamos
    /// </summary>
    public partial class rPrestamos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrestamoIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarBoton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaDatePicker;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PersonaTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConceptoTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MontoTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoBoton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarBoton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarBoton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RegistroPrestamos;component/ui/registro/rprestamos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PrestamoIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarBoton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
            this.BuscarBoton.Click += new System.Windows.RoutedEventHandler(this.BuscarBoton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FechaDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.PersonaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ConceptoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MontoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.NuevoBoton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
            this.NuevoBoton.Click += new System.Windows.RoutedEventHandler(this.NuevoBoton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GuardarBoton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
            this.GuardarBoton.Click += new System.Windows.RoutedEventHandler(this.GuardarBoton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EliminarBoton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\..\UI\Registro\rPrestamos.xaml"
            this.EliminarBoton.Click += new System.Windows.RoutedEventHandler(this.EliminarBoton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
