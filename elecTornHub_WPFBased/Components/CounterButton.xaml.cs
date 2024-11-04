using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class CounterButton : UserControl
    {
        public CounterButton()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
        }
    }
}
