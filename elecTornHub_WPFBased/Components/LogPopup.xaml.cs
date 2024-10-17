using System.Windows;
using System.Windows.Controls;

namespace elecTornHub_WPFBased.Components
{
    /// <summary>
    /// Interaction logic for LogPopup.xaml
    /// </summary>
    public partial class LogPopup : UserControl
    {
        public LogPopup()
        {
            InitializeComponent();
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(LogPopup), new PropertyMetadata(string.Empty, OnTypeChanged));

        public string Type // Changed from Text to Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as LogPopup;
            string newType = e.NewValue as string;

            if (newType == "Login")
            {
                control.LogPopup_LoginText.Text = "Login";
                control.LogPopup_LogButtonText.Content = "Login";
                control.LogPopup_Redirect.Text = "Register?";
            }
            else if (newType == "Register")
            {
                control.LogPopup_LoginText.Text = "Register";
                control.LogPopup_LogButtonText.Content = "Register";
                control.LogPopup_Redirect.Text = "Login?";
            }
        }
    }
}
