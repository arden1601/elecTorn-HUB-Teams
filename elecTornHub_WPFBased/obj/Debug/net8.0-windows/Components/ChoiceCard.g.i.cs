﻿#pragma checksum "..\..\..\..\Components\ChoiceCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED1BBCDF3D6FEF0364E22D303EC183EF200F136C"
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
    /// ChoiceCard
    /// </summary>
    public partial class ChoiceCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Card_ProductMode;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ProductCard_Image;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductCard_Name;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductCard_Price;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProductCard_Button;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Card_PostMode;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Components\ChoiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock News_Name;
        
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
            System.Uri resourceLocater = new System.Uri("/elecTornHub_WPFBased;component/components/choicecard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Components\ChoiceCard.xaml"
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
            this.Card_ProductMode = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ProductCard_Image = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ProductCard_Name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ProductCard_Price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ProductCard_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Card_PostMode = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.News_Name = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

