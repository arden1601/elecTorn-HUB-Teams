﻿using elecTornHub_WPFBased.Components;
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
using elecTornHub_WPFBased.Classes;
using elecTornHub_WPFBased.ViewModels;
using Newtonsoft.Json;

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

        public async void CheckLogin()
        {
            string uname = LogPopupControl.LogPopup_UsernameValue.Text;
            string pwd = LogPopupControl.LogPopup_PasswordValue.Password;

            List<ContentViewModel> newData = new List<ContentViewModel>();
            
            // udah bisa keluar bang
            var data = await Products.getAllProduct();
            var selectedObj = data[0];
            Console.WriteLine(selectedObj.productId.ToString());
            
            // udah bisa keluar bang
            var data_lagi = await Products.getOwnProduct();
            var selectedObj_lagi = data_lagi[0];
            Console.WriteLine("hahahah");
            Console.WriteLine(selectedObj_lagi.productId.ToString());


            Accounts acc = new Accounts(uname, pwd, "");
            bool isLogin = await acc.Login();
            if (isLogin && acc.Role != "admin")
            {
                 ContentViewModel.TemporaryPostsMod = await ContentViewModel.GetAllContent();

                SearchDash newDash = new SearchDash
                {
                    PreviousWindow = this,
                    ContentMode = Enumerations.CustomGrid.CustomGridMode.Beli,
                    ContentType = Enumerations.ChoiceCard.ChoiceCardType.Product,
                    NavbarType = Enumerations.Navbar.NavbarType.User,
                    NavbarChosen = Enumerations.Navbar.NavbarChosen.Beli
                };

                // Set DataContext for binding if needed
                newDash.DataContext = newDash;
                newDash.Show();

                this.Close();

                // print success
                MessageBox.Show("Login successful! sebagai "+acc.Role, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            else if (isLogin && acc.Role == "admin")
            {
                SearchDash newDash = new SearchDash
                {
                    PreviousWindow = this,
                    ContentMode = Enumerations.CustomGrid.CustomGridMode.Admin,
                    ContentType = Enumerations.ChoiceCard.ChoiceCardType.Product,
                    NavbarType = Enumerations.Navbar.NavbarType.Admin,
                    NavbarChosen = Enumerations.Navbar.NavbarChosen.Item
                };

                // Set DataContext for binding if needed
                newDash.DataContext = newDash;
                newDash.Show();

                this.Close();

                // print success
                MessageBox.Show("Login successful! sebagai " + acc.Role, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                MessageBox.Show("Login failed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LogPopupControl.ClearFields();
        }

        private void LogPopupControl_Loaded()
        {

        }
    }
}