using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LemonApp.Theme.FerrisWheel
{
    /// <summary>
    /// CarRunPage.xaml 的交互逻辑
    /// </summary>
    public partial class CarRunPage : UserControl
    {
        public CarRunPage()
        {
            InitializeComponent();
            bg.Background = new ImageBrush(Properties.Resources.bg.ToBitmapImage());
            car1.Background = new ImageBrush(Properties.Resources.car4.ToBitmapImage()) { Stretch=Stretch.None};
            car2.Background = new ImageBrush(Properties.Resources.car1.ToBitmapImage()) { Stretch = Stretch.None };
            car3.Background = new ImageBrush(Properties.Resources.car5.ToBitmapImage()) { Stretch = Stretch.None };
            car4.Background = new ImageBrush(Properties.Resources.car3.ToBitmapImage()) { Stretch = Stretch.None };
            bottom.Background = new ImageBrush(Properties.Resources.bottom.ToBitmapImage()) { Stretch = Stretch.None };
        }

        public void BeginAni() {
            Storyboard carrun = Resources["CarRun"] as Storyboard;
            carrun.Begin();
        }
    }
}
