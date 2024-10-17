using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace elecTornHub_WPFBased.Extras
{
    public static class Variables
    {
        // screen icon

        // Function to export the icon as a BitmapImage
        public static BitmapImage GetScreenIcon()
        {
            BitmapImage bitmapImage = new BitmapImage();
            try
            {
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("pack://application:,,,/Resources/logo.ico");
                bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad; // Cache the image immediately
                bitmapImage.EndInit();
                bitmapImage.Freeze(); // Freeze the image to make it cross-thread accessible

                // Convert the BitmapImage to the desired pixel format
                var convertedBitmap = ConvertToPixelFormat(bitmapImage, PixelFormats.Bgra32);

                // Convert the BitmapSource to BitmapImage
                return ConvertToBitmapImage(convertedBitmap);
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine($"Error loading image: {ex.Message}");
            }

            return null; // Return null if there's an error
        }

        private static BitmapSource ConvertToPixelFormat(BitmapSource source, PixelFormat pixelFormat)
        {
            // Create a new WriteableBitmap with the original source
            WriteableBitmap writeableBitmap = new WriteableBitmap(source);

            // Create a FormatConvertedBitmap with the desired pixel format
            BitmapSource convertedBitmap = new FormatConvertedBitmap(writeableBitmap, pixelFormat, null, 0);
            return convertedBitmap; // This returns a BitmapSource
        }

        private static BitmapImage ConvertToBitmapImage(BitmapSource source)
        {
            using (var memoryStream = new MemoryStream())
            {
                BitmapEncoder encoder = new PngBitmapEncoder(); // Choose the appropriate encoder
                encoder.Frames.Add(BitmapFrame.Create(source));
                encoder.Save(memoryStream);
                memoryStream.Position = 0; // Reset the stream position

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream; // Load from the memory stream
                bitmapImage.EndInit();
                bitmapImage.Freeze(); // Freeze the image to make it cross-thread accessible

                return bitmapImage; // Return the new BitmapImage
            }
        }

        // screen values
        public static double ScreenWidth { get; private set; } = 1024;
        public static double ScreenHeight { get; private set; } = 576;

        // font values
        public static FontFamily PrimaryFont { get; private set; } = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/Fonts/#Roboto Regular");
        public static FontFamily SecondaryFont { get; private set; } = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/Fonts/#Montserrat");
        public static FontFamily SecondaryFontBold { get; private set; } = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/Fonts/#Montserrat Bold");

        // font sizes
        public static double FontSizeXS { get; private set; } = 8;
        public static double FontSizeSM { get; private set; } = 12;
        public static double FontSizeMD { get; private set; } = 16;
        public static double FontSizeLG { get; private set; } = 20;
        public static double FontSizeXL { get; private set; } = 24;

        // colors defined as SolidColorBrush
        public static SolidColorBrush ColorGreen { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#27AE60"));
        public static SolidColorBrush ColorDarkGray { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2C3E50"));
        public static SolidColorBrush ColorAccentOrange { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E67E22"));
        public static SolidColorBrush ColorLightGray { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ECF0F1"));
        public static SolidColorBrush ColorOffWhite { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));
        public static SolidColorBrush ColorSoftCream { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F0EDE5"));
        public static SolidColorBrush ColorAbsoluteWhite { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
    }
}
