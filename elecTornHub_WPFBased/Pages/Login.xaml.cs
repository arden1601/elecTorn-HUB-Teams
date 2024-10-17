using elecTornHub_WPFBased.Components;
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
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            LogPopupControl.PreviousWindow = this;
            LogPopupControl.LogPopup_LogButtonText.Click += (s, e) => CheckLogin();
        }

        public void CheckLogin()
        {
            if (LogPopupControl.LogPopup_UsernameValue.Text == "Lorem" && LogPopupControl.LogPopup_PasswordValue.Password == "Ipsum")
            {
                LogPopupControl.ClearFields();
                // print success
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                LogPopupControl.ClearFields();
                // print fail
                MessageBox.Show("Login failed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}