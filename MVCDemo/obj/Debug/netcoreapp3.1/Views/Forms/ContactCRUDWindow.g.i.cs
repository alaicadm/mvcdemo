﻿#pragma checksum "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C3C2FACA682CB698D06A589BF24417AC2E54691"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MVCDemo.Views.Forms;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace MVCDemo.Views.Forms {
    
    
    /// <summary>
    /// ContactCRUDWindow
    /// </summary>
    public partial class ContactCRUDWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContactNo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbMale;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbFemale;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MVCDemo;component/views/forms/contactcrudwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtMName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtLName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtContactNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.rdbMale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
            this.rdbMale.Click += new System.Windows.RoutedEventHandler(this.rdoGender_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdbFemale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 39 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
            this.rdbFemale.Click += new System.Windows.RoutedEventHandler(this.rdoGender_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\Views\Forms\ContactCRUDWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

