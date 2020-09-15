using System.Windows;
using System.Windows.Controls;

namespace ViewDiscovery.Views
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      // 该构造函数根据使用的内容的不同，添加不同的参数。是通过什么机制进行调用的？
      public MainWindow(Prism.Ioc.IContainerExtension container, Prism.Regions.IRegionManager regionManager)
      {
         InitializeComponent();

         // 方式一：指定已设计好的视图
         regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

         // 方式二：通过容器创建视图
         regionManager.RegisterViewWithRegion("ContentRegion", () => container.Resolve(typeof(ViewA)));

         // 方式三：通过代码创建视图
         regionManager.RegisterViewWithRegion("ContentRegion", () =>
         {
            Border border = new Border();
            border.BorderBrush = System.Windows.Media.Brushes.Orange;
            border.BorderThickness = new Thickness(5);
            border.Margin = new Thickness(3);

            return border;
         });


         // 如果为一个区域指定了多个视图，默认显示第一个。可通过Region的Active函数或Deactive()激活视图
      }
   }
}
