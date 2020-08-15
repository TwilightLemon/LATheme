using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/*
           Lemon App 通用主题模板 V2 Run on .Net Core 3.1
           2020.1.19
     Twilight./Lemon QQ:2728578956

   需要用到的几个部分:
       1.Background:在此Page上自由绘制   或 
          在 GetBrush方法内以Brush类型返回
       2.ThemeColor 主题颜色
       3.Font 字体颜色 White or Black
   可以随意更改的部分:
       1.命名空间 namespace
       2.作者,版权,程序集信息
    不可更改的:
       1.此类名
       2.基本方法 GetPage GetThemeColor GetFont
     */
namespace LemonApp.Theme.FerrisWheel
{
    /// <summary>
    /// Drawe.xaml 的交互逻辑
    /// </summary>
    public partial class Drawer : ThemeBase
    {
        public Drawer(bool needDraw = true)
        {
            ThemeName = "梦幻摩天轮";
            ThemeColor = Color.FromArgb(255, 165, 38, 86);
            FontColor = "Black";
            InitializeComponent();
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.LowQuality);
            round.Background = new ImageBrush(Properties.Resources.round.ToBitmapImage());
            ship1.Background = new ImageBrush(Properties.Resources.ship1.ToBitmapImage()) {Stretch=Stretch.None};
            ship2.Background = new ImageBrush(Properties.Resources.ship2.ToBitmapImage()) { Stretch = Stretch.None };
            dress.Background = new ImageBrush(Properties.Resources.dress.ToBitmapImage()) { Stretch = Stretch.None };
            hair.Background = new ImageBrush(Properties.Resources.hair.ToBitmapImage()) { Stretch = Stretch.None };
            hat.Background = new ImageBrush(Properties.Resources.hat.ToBitmapImage()) { Stretch = Stretch.None };
            Haidai.Background = new ImageBrush(Properties.Resources.hatdai.ToBitmapImage()) { Stretch = Stretch.None };
            if (needDraw) Draw();
        }
        public static new string NameSpace = "LemonApp.Theme.FerrisWheel.Drawer";
        public override ThemeBase GetPage()
        {
            return new Drawer();
        }

        public override void Draw()
        {
            Storyboard RoundAni = Resources["RoundAni"] as Storyboard;
            Storyboard OtherAni = Resources["OtherAni"] as Storyboard;
            OtherAni.Begin();
            car.BeginAni();
            RoundAni.Begin();
        }
    }
}
