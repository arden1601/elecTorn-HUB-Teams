﻿#pragma checksum "..\..\..\..\Components\LogPopup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01D648B9C7B8062424BE6695C195F52659954CB3"
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
using elecTornHub_WPFBased.Extras;


namespace elecTornHub_WPFBased.Components {
    
    
    /// <summary>
    /// LogPopup
    /// </summary>
    public partial class LogPopup : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run LogPopup_LoginText;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogPopup_UsernameValue;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox LogPopup_PasswordValue;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogPopup_LogButtonText;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogPopup_RedirectButton;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\Components\LogPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LogPopup_Redirect;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/elecTornHub_WPFBased;component/components/logpopup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Components\LogPopup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LogPopup_LoginText = ((System.Windows.Documents.Run)(target));
            return;
            case 2:
            this.LogPopup_UsernameValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\..\Components\LogPopup.xaml"
            this.LogPopup_UsernameValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LogPopup_UsernameValue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogPopup_PasswordValue = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.LogPopup_LogButtonText = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.LogPopup_RedirectButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.LogPopup_Redirect = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

