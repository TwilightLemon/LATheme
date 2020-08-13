using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
namespace LemonApp.Theme.TechDMusic
{
    /// <summary>
    /// Drawe.xaml 的交互逻辑
    /// </summary>
    public partial class Drawer : ThemeBase
    {
        public Drawer(bool needDraw=true)
        {
            ThemeName = "科技电音";
            ThemeColor = Color.FromArgb(255, 64,227,251);
            FontColor = "White";
            InitializeComponent();
            //Load Images
            bg.Background = new ImageBrush(Properties.Resources.bg.ToBitmapImage());
            mainround.Background = new ImageBrush(Properties.Resources.mainround.ToBitmapImage());
            Light.Background = new ImageBrush(Properties.Resources.blur.ToBitmapImage());
            border.Background = new ImageBrush(Properties.Resources.db.ToBitmapImage()) { Stretch=Stretch.Uniform};
            bgAniOne.Background = new ImageBrush(Properties.Resources.bgAni1.ToBitmapImage());
            bgAniTwo.Background = new ImageBrush(Properties.Resources.bgAni2.ToBitmapImage());
            if (needDraw)Draw();
        }
        public static new string NameSpace = "LemonApp.Theme.TechDMusic.Drawer";
        public override ThemeBase GetPage()
        {
            return new Drawer();
        }

        public override void Draw()
        {
            (Resources["RoundAni"] as Storyboard).Begin();
            //Opacity 透明度的动画计算十分消耗GPU  所以将帧数降到了10fps
            Storyboard bgAni = Resources["bgAni"] as Storyboard;
            Timeline.SetDesiredFrameRate(bgAni,10);
            bgAni.Begin();
        }
    }
}
