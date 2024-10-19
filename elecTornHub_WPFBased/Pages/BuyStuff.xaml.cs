namespace elecTornHub_WPFBased.Pages
{
    using System.Windows.Controls;
    using System.Windows;
    using static elecTornHub_WPFBased.Extras.Variables;
    using elecTornHub_WPFBased.Components;

    public partial class BuyStuff : Window
    {
        public BuyStuff()
        {
            InitializeComponent();

            // Add logic to generate 100 rows dynamically
            AddRowsToGrid(100);
        }

        private void AddRowsToGrid(int rowCount)
        {
            CardGrids.RowDefinitions.Clear(); // Clear existing row definitions
            CardGrids.Children.Clear(); // Clear existing children (ChoiceCards)

            int columnCount = 2; // Number of columns you want to display
            for (int i = 0; i < rowCount; i++)
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

                }
            }
        }

    }
}
