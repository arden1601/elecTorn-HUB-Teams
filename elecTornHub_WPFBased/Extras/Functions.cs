using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using elecTornHub_WPFBased.Components;
using System.Windows;
using System.Globalization;
using System.Globalization;
using elecTornHub_WPFBased.ViewModels;
using elecTornHub_WPFBased.Pages;

namespace elecTornHub_WPFBased.Extras
{
    public class Functions
    {
        // Method to format number as Rp. xxx.xxx.xxx,-
        public static string FormatToRupiah(int amount)
        {
            // Use "id-ID" culture for Indonesian Rupiah formatting
            CultureInfo indonesianCulture = new CultureInfo("id-ID");

            // Format the amount to currency without decimals and use grouping separator (.)
            string formattedAmount = amount.ToString("N0", indonesianCulture);

            // Add Rp prefix and ,-
            return $"Rp. {formattedAmount},-";
        }

        public static string CutFromStart(string input, int count)
        {
            // Check if the count is greater than the string length
            if (input == null || count >= input.Length)
            {
                return input;
            }

            // Return the first count characters
            return input.Substring(0, count) + "...";
        }

        public static void ClickDataHandler<T>(
            T DataContext,
            Action<ContentViewModel> callback
            )
        {
            // Access the DataContext directly inside the handler
            if (DataContext is ContentViewModel viewModel)
            {
                callback(viewModel);
            }
            else
            {
                MessageBox.Show("DataContext is not of type ContentViewModel.");
            }
        }
    }
}
