using System.Windows;
using System.Windows.Controls;

namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Pages;
    public partial class LogPopup : UserControl
    {
        public enum LogPopupType
        {
            Default,
            Login,
            Register
        }

        public LogPopup()
        {
            InitializeComponent();
            UpdateLayout();
        }

        public Window PreviousWindow { get; set; }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(LogPopupType), typeof(LogPopup), new PropertyMetadata(LogPopupType.Default, OnTypeChanged));

        public LogPopupType Type
        {
            get { return (LogPopupType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback Button Login
        public void ShowRegisterWindow()
        {
            // Create and show the Register window
            Register register = new Register();
            register.Show();

            // Close the previous window if it exists
            if (PreviousWindow != null)
            {
                PreviousWindow.Close();
            }

            // Set the PreviousWindow to the newly opened Register window
            PreviousWindow = register;
        }

        // Callback Button Register
        public void ShowLoginWindow()
        {
            // Create and show the Login window
            Login login = new Login();
            login.Show();

            // Close the previous window if it exists
            if (PreviousWindow != null)
            {
                PreviousWindow.Close();
            }

            // Set the PreviousWindow to the newly opened Login window
            PreviousWindow = login;
        }

        // Callback method for TypeProperty
        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as LogPopup;

            if (control == null)
                return;

            LogPopupType newType = (LogPopupType) e.NewValue;

            if (newType == LogPopupType.Login)
            {
                control.LogPopup_LoginText.Text = "Login";
                control.LogPopup_LogButtonText.Content = "Login";
                control.LogPopup_Redirect.Text = "Register?";
                control.LogPopup_RedirectButton.Click += (sender, args) => control.ShowRegisterWindow();
            }
            else if (newType == LogPopupType.Register)
            {
                control.LogPopup_LoginText.Text = "Register";
                control.LogPopup_LogButtonText.Content = "Register";
                control.LogPopup_Redirect.Text = "Login?";
                control.LogPopup_RedirectButton.Click += (sender, args) => control.ShowLoginWindow();
            }
        }

        // Clear Username and Password
        public void ClearFields()
        {
            LogPopup_UsernameValue.Text = string.Empty;
            LogPopup_PasswordValue.Password = string.Empty;
        }
    }
}
