﻿#pragma checksum "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FD8BA3403B8D5BB8F3852DE3826E36A134874F6B"
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
    /// ContactBulkCRUDWindow
    /// </summary>
    public partial class ContactBulkCRUDWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 28 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContactNo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbMale;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbFemale;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgContacts;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MVCDemo;component/views/forms/contactbulkcrudwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
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
            
            #line 40 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            this.rdbMale.Click += new System.Windows.RoutedEventHandler(this.rdoGender_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdbFemale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            this.rdbFemale.Click += new System.Windows.RoutedEventHandler(this.rdoGender_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgContacts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 52 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            this.dgContacts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgContacts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 57 "..\..\..\..\..\Views\Forms\ContactBulkCRUDWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Remove_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

