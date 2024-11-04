using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.Extras;
using System.Security.RightsManagement;
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
using Npgsql;

namespace elecTornHub_WPFBased.Pages
{
    using static elecTornHub_WPFBased.Extras.Variables;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Window PreviousWindow { get; set; }

        public Login()
        {
            InitializeComponent();
            UpdateLayout();
            /*ConnectToDatabase();*/
            LogPopupControl.PreviousWindow = this;
            LogPopupControl.LogPopup_LogButtonText.Click += (s, e) => CheckLogin();
        }

        /*private void ConnectToDatabase()
        {
            // connect to databas
            string conn = "Server=pg-izcy-mail-06ee.i.aivencloud.com;Port=24266;User Id=avnadmin;Password=;Database=defaultdb;SslMode=Require;";

            try
            {
                using (var connection = new NpgsqlConnection(conn))
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Try to query
                    using (var cmd = new NpgsqlCommand("SELECT * FROM public.\"Accounts\"", connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("user: "+reader.GetString(0)+" pass: "+reader.GetString(1), "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        public void CheckLogin()
        {
            if (LogPopupControl.LogPopup_UsernameValue.Text == "Lorem" && LogPopupControl.LogPopup_PasswordValue.Password == "Ipsum")
            {
                LogPopupControl.ClearFields();

                SearchDash newDash = new SearchDash
                {
                    PreviousWindow = this,
                    GridMode = CustomGrid.CustomGridMode.Beli,
                    GridType = ChoiceCard.ChoiceCardType.Product,
                    NavbarType = Navbar.NavbarType.User,
                    NavbarChosen = Navbar.NavbarChosen.Beli
                };

                // Set DataContext for binding if needed
                newDash.DataContext = newDash;
                newDash.Show();

                this.Close();

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