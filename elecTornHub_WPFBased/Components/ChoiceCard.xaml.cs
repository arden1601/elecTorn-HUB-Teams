﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class ChoiceCard : UserControl
    {
        public ChoiceCard()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
        }

    }
}