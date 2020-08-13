using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LemonApp.Theme
{
    public abstract class ThemeBase : UserControl
    {
        public string ThemeName { get; set; }
        public static string NameSpace;
        public Color ThemeColor { get; set; }
        public string FontColor { get; set; }
        public abstract ThemeBase GetPage();
        public abstract void Draw();
    }
    public static class ImageHelper
    {
        public static BitmapImage ToBitmapImage(this byte[] array, int[] DecodePixel = null)
        {
            using (var ms = new MemoryStream(array))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                if (DecodePixel != null)
                {
                    image.DecodePixelHeight = DecodePixel[0];
                    image.DecodePixelWidth = DecodePixel[1];
                }
                image.EndInit();
                image.Freeze();
                return image;
            }
        }

    }
}
