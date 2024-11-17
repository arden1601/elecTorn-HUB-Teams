using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using elecTornHub_WPFBased.Components;
using System.Windows;

namespace elecTornHub_WPFBased.Extras
{
    public class Functions
    {
        public static BitmapImage GetDummyImage(BitmapImage dummyImage, string ImgSrc)
        {
            if (dummyImage == null)
            {
                /*dummyImage = new BitmapImage();
                dummyImage.BeginInit();
                dummyImage.CacheOption = BitmapCacheOption.OnLoad;
                dummyImage.UriSource = new Uri(ImgSrc, UriKind.RelativeOrAbsolute);
                dummyImage.EndInit();*/

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad; // Fully load the image into memory
                bitmapImage.UriSource = new Uri(ImgSrc, UriKind.RelativeOrAbsolute);
                bitmapImage.EndInit();

                return bitmapImage;
            }
            return dummyImage;
        }
    }
}
