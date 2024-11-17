using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    public partial class ConfirmPopup : UserControl, INotifyPropertyChanged, Interfaces.IConfirmPopup
    {
        // Implementing IConfirmPopup interface
        private Enumerations.Popup.ConfirmPopupType _confirmPopupType;

        public Enumerations.Popup.ConfirmPopupType ConfirmPopupType
        {
            get { return _confirmPopupType; }
            set { _confirmPopupType = value; }
        }

        private void OnTypeChanged(Enumerations.Popup.ConfirmPopupType newValue)
        {
            // Setup Default Values
            ConfirmPopup_Title.Text = Title;
            ConfirmPopup_OnYesNoButtonContainer.Visibility = Visibility.Collapsed;
            ConfirmPopup_InputContainer.Visibility = Visibility.Collapsed;

            switch (newValue)
            {
                case Enumerations.Popup.ConfirmPopupType.Terbeli:
                    // Additional logic for "Terbeli" can go here
                    break;
                case Enumerations.Popup.ConfirmPopupType.Kontak:
                    break;
                case Enumerations.Popup.ConfirmPopupType.HapusJualan:
                    ConfirmPopup_OnYesNoButtonContainer.Visibility = Visibility.Visible;
                    ConfirmPopup_OnYesOnlyButton.Visibility = Visibility.Collapsed;
                    break;
                case Enumerations.Popup.ConfirmPopupType.HapusPost:
                    break;
                case Enumerations.Popup.ConfirmPopupType.HapusAkun:
                    ConfirmPopup_OnYesNoButtonContainer.Visibility = Visibility.Visible;
                    ConfirmPopup_OnYesOnlyButton.Visibility = Visibility.Collapsed;
                    break;
                case Enumerations.Popup.ConfirmPopupType.Lapor:
                    ConfirmPopup_InputContainer.Visibility = Visibility.Visible;
                    break;
                case Enumerations.Popup.ConfirmPopupType.Takedown:
                    ConfirmPopup_OnYesNoButtonContainer.Visibility = Visibility.Visible;
                    ConfirmPopup_OnYesOnlyButton.Visibility = Visibility.Collapsed;
                    ConfirmPopup_InputContainer.Visibility = Visibility.Visible;
                    break;
                case Enumerations.Popup.ConfirmPopupType.AkunNotFound:
                    // Additional logic for "Akun Not Found" can go here
                    break;
                default:
                    break;
            }
        }

        public ConfirmPopup()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // DependencyProperty for Title
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // DependencyProperty for Message_0
        public static readonly DependencyProperty Message_0Property =
            DependencyProperty.Register("Message_0", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_0
        {
            get { return (string)GetValue(Message_0Property); }
            set { SetValue(Message_0Property, value); }
        }

        // DependencyProperty for Message_1
        public static readonly DependencyProperty Message_1Property =
            DependencyProperty.Register("Message_1", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_1
        {
            get { return (string)GetValue(Message_1Property); }
            set { SetValue(Message_1Property, value); }
        }

        // DependencyProperty for Message_2
        public static readonly DependencyProperty Message_2Property =
            DependencyProperty.Register("Message_2", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_2
        {
            get { return (string)GetValue(Message_2Property); }
            set { SetValue(Message_2Property, value); }
        }

        // DependencyProperty for Message_3
        public static readonly DependencyProperty Message_3Property =
            DependencyProperty.Register("Message_3", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_3
        {
            get { return (string)GetValue(Message_3Property); }
            set { SetValue(Message_3Property, value); }
        }

        // DependencyProperty for Message_4
        public static readonly DependencyProperty Message_4Property =
            DependencyProperty.Register("Message_4", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_4
        {
            get { return (string)GetValue(Message_4Property); }
            set { SetValue(Message_4Property, value); }
        }

        // DependencyProperty for Message_5
        public static readonly DependencyProperty Message_5Property =
            DependencyProperty.Register("Message_5", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_5
        {
            get { return (string)GetValue(Message_5Property); }
            set { SetValue(Message_5Property, value); }
        }

        // DependencyProperty for Message_6
        public static readonly DependencyProperty Message_6Property =
            DependencyProperty.Register("Message_6", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_6
        {
            get { return (string)GetValue(Message_6Property); }
            set { SetValue(Message_6Property, value); }
        }

        // DependencyProperty for Message_7
        public static readonly DependencyProperty Message_7Property =
            DependencyProperty.Register("Message_7", typeof(string), typeof(ConfirmPopup), new PropertyMetadata(string.Empty));
        public string Message_7
        {
            get { return (string)GetValue(Message_7Property); }
            set { SetValue(Message_7Property, value); }
        }
    }
}
