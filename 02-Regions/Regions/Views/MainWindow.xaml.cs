using System.Windows;

namespace Regions.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public MainWindow(Prism.Regions.IRegionManager regionManager)
      {
         InitializeComponent();

         // 使用依赖注入的方式用视图填充命名区域
         regionManager.RegisterViewWithRegion("ContentRegion", typeof(UserControlView));
      }
   }
}
