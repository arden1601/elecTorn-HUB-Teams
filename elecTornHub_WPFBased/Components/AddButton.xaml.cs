using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class AddButton : UserControl
    {
        public AddButton()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
        }
    }
}
