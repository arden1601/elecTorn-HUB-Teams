using System.Windows;
using System.Windows.Controls;

namespace elecTornHub_WPFBased.Components
{
    public partial class CustomGrid : Grid
    {
        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(string), typeof(CustomGrid), new PropertyMetadata(string.Empty));

        public string Mode
        {
            get { return (string)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(CustomGrid), new PropertyMetadata(string.Empty));

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
    }
}
