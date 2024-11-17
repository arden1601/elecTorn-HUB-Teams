using System.Windows;
using System.Windows.Controls;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    public partial class ChoiceCard : UserControl, Interfaces.IContentCard
    {
        // Implementing IContentCard interface
        private Enumerations.CustomGrid.CustomGridMode _contentMode;
        private Enumerations.ChoiceCard.ChoiceCardType _contentType;

        public Enumerations.CustomGrid.CustomGridMode ContentMode
        {
            get { return _contentMode; }
            set { _contentMode = value; OnGridModeChanged(value); }
        }

        public Enumerations.ChoiceCard.ChoiceCardType ContentType
        {
            get { return _contentType; }
            set { _contentType = value; OnTypeChange(value); }
        }

        public ChoiceCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void OnTypeChange(Enumerations.ChoiceCard.ChoiceCardType newValue)
        {
            // Handle visibility based on Type
            switch (newValue)
            {
                case Enumerations.ChoiceCard.ChoiceCardType.Post:
                    Card_PostMode.Visibility = Visibility.Visible;
                    Card_ProductMode.Visibility = Visibility.Collapsed;
                    break;
                case Enumerations.ChoiceCard.ChoiceCardType.Product:
                    Card_PostMode.Visibility = Visibility.Collapsed;
                    Card_ProductMode.Visibility = Visibility.Visible;
                    break;
                default:
                    Card_PostMode.Visibility = Visibility.Collapsed;
                    Card_ProductMode.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        // Callback for GridMode change
        public void OnGridModeChanged(Enumerations.CustomGrid.CustomGridMode newValue)
        {
            // Update button content based on GridMode
            switch (newValue)
            {
                case Enumerations.CustomGrid.CustomGridMode.Admin:
                    ProductCard_Button.Content = "Periksa";
                    break;
                case Enumerations.CustomGrid.CustomGridMode.Beli:
                    ProductCard_Button.Content = "Beli Sekarang";
                    break;
                case Enumerations.CustomGrid.CustomGridMode.Jual:
                    ProductCard_Button.Content = "Edit";
                    break;
                default:
                    ProductCard_Button.Content = "Lihat";
                    break;
            }
        }
    }
}
