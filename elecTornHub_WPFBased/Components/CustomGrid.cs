using System.ComponentModel; // Add this for INotifyPropertyChanged
using elecTornHub_WPFBased.Extras;
using System.Windows.Controls;

namespace elecTornHub_WPFBased.Components
{
    public partial class CustomGrid : Grid, Interfaces.IContentCard, INotifyPropertyChanged
    {
        // Event required for INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Implementing IContentCard interface
        private Enumerations.CustomGrid.CustomGridMode _mode;
        private Enumerations.ChoiceCard.ChoiceCardType _type;

        public Enumerations.CustomGrid.CustomGridMode ContentMode
        {
            get { return _mode; }
            set
            {
                if (_mode != value)
                {
                    _mode = value;
                    OnPropertyChanged(nameof(ContentMode));
                }
            }
        }

        public Enumerations.ChoiceCard.ChoiceCardType ContentType
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged(nameof(ContentType));
                }
            }
        }

        // Helper method to raise PropertyChanged event
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
