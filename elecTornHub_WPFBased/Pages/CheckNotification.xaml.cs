﻿using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.Extras;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace elecTornHub_WPFBased.Pages
{
    using static elecTornHub_WPFBased.Extras.Variables;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CheckNotification : Window
    {
        public CheckNotification()
        {
            InitializeComponent();
            UpdateLayout();
            /*CheckNotification.PreviousWindow = this;
            CheckNotification.LogPopup_LogButtonText.Click += (s, e) => CheckLogin();*/
        }
    }
}