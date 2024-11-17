using elecTornHub_WPFBased.Classes;
using elecTornHub_WPFBased.Extras;
using System.Threading.Tasks;
using System.Windows;

namespace elecTornHub_WPFBased.Pages
{
    using static elecTornHub_WPFBased.Extras.Variables;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();

            LogPopupControl.PreviousWindow = this;

            LogPopupControl.LogPopup_LogButtonText.Click += async (s, e) => await RegisterController();
        }

        public async Task RegisterController()
        {
            string uname = LogPopupControl.LogPopup_UsernameValue.Text;
            string pwd = LogPopupControl.LogPopup_PasswordValue.Password;

            Accounts acc = new Accounts(uname, pwd, "");
            bool isSuccess = await acc.Register();

            if (isSuccess)
            {
                Login newLogin = new Login
                {
                    DataContext = new Login()
                };
                newLogin.Show();

                // Close the current Register window
                this.Close();

                // Show success message
                MessageBox.Show("Successfully registered!");
            }
            else
            {
                // Show failure message
                MessageBox.Show("Registration failed.");
            }
        }

        public Window PreviousWindow { get; set; }
    }
}
