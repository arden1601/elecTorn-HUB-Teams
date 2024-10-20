namespace elecTornHub_WPFBased.Pages
{
    using System.Windows;
    using System.Windows.Controls;
    using static elecTornHub_WPFBased.Extras.Variables;
    using elecTornHub_WPFBased.Components;

    public partial class SearchDash : Window
    {
        public SearchDash()
        {
            InitializeComponent();

            // Generate 100 choice cards dynamically
            GenerateChoiceCards(100);

            // if mode is Jual, show the AddButton
            if (((CustomGrid)CardGrids).Mode == "Jual")
                this.SearchDash_AddButton.Visibility = Visibility.Visible;
            else this.SearchDash_AddButton.Visibility = Visibility.Collapsed;
        }

        private void GenerateChoiceCards(int count)
        {
            // Ensure you access the Mode property from the instance of CustomGrid
            CardGrids.RowDefinitions.Clear(); // Clear existing row definitions
            CardGrids.Children.Clear(); // Clear existing children (ChoiceCards)

            int columnCount = 2; // Number of columns you want to display
            for (int i = 0; i < count; i++)
            {
                // Add a new row definition for each row
                CardGrids.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                for (int j = 0; j < columnCount; j++)
                {
                    // Create a new ChoiceCard instance
                    var choiceCard = new ChoiceCard();

                    // Set the row and column for the ChoiceCard
                    Grid.SetRow(choiceCard, i);
                    Grid.SetColumn(choiceCard, j);

                    // Add the ChoiceCard to the grid
                    CardGrids.Children.Add(choiceCard);
                    // make gaps margin, 0, 0, 10, 10 for odd cols, 10, 0, 0, 10 for even cols
                    choiceCard.Margin = new Thickness(j % 2 == 0 ? 0 : 10, 0, j % 2 == 0 ? 10 : 0, 10);
                    choiceCard.Type = ((CustomGrid)CardGrids).Type;

                    UpdateCardButtonContent(((CustomGrid)CardGrids).Mode);
                }
            }
        }

        private void UpdateCardButtonContent(string mode)
        {
            foreach (var child in CardGrids.Children)
            {
                if (child is ChoiceCard choiceCard)
                {
                    choiceCard.ProductCard_Button.Content = mode switch
                    {
                        "Beli" => "Beli Sekarang",
                        "Jual" => "Edit",
                        "Admin" => "Periksa",
                        _ => choiceCard.ProductCard_Button.Content // Default or keep existing
                    };
                }
            }
        }
    }
}
