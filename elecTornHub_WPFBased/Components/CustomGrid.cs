using System.Windows;
using System.Windows.Controls;

namespace elecTornHub_WPFBased.Components
{
    public partial class CustomGrid : Grid
    {
        public enum CustomGridMode
        {
            Default,
            Beli,
            Jual,
            Admin
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(CustomGridMode), typeof(CustomGrid), new PropertyMetadata(CustomGridMode.Default));

        public CustomGridMode Mode
        {
            get { return (CustomGridMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(ChoiceCard.ChoiceCardType), typeof(CustomGrid), new PropertyMetadata(ChoiceCard.ChoiceCardType.Default));

        public ChoiceCard.ChoiceCardType Type
        {
            get { return (ChoiceCard.ChoiceCardType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
    }
}
