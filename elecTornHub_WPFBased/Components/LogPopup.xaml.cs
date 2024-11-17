using System.Windows;
using System.Windows.Controls;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Pages;
    public partial class LogPopup : UserControl, Interfaces.ILogPopup
    {
        // Implementing ILogPopup interface
        private Enumerations.Popup.LogPopupType _logPopupType;

        public Enumerations.Popup.LogPopupType LogPopupType
        {
            get { return _logPopupType; }
            set { _logPopupType = value; OnTypeChanged(value); }
        }

        public LogPopup()
        {
            InitializeComponent();
            UpdateLayout();
        }

        public Window PreviousWindow { get; set; }

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
        private void OnTypeChanged(Enumerations.Popup.LogPopupType newValue)
        {
            switch (newValue)
            {
                case Enumerations.Popup.LogPopupType.Login:
                    LogPopup_LoginText.Text = "Login";
                    LogPopup_LogButtonText.Content = "Login";
                    LogPopup_Redirect.Text = "Register?";
                    LogPopup_RedirectButton.Click += (sender, args) => ShowRegisterWindow();
                    break;
                case Enumerations.Popup.LogPopupType.Register:
                    LogPopup_LoginText.Text = "Register";
                    LogPopup_LogButtonText.Content = "Register";
                    LogPopup_Redirect.Text = "Login?";
                    LogPopup_RedirectButton.Click += (sender, args) => ShowLoginWindow();
                    break;
                default:
                    break;
            }
        }

        // Clear Username and Password
        public void ClearFields()
        {
            LogPopup_UsernameValue.Text = string.Empty;
            LogPopup_PasswordValue.Password = string.Empty;
        }

        private void LogPopup_UsernameValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
