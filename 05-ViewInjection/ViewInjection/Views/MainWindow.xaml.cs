using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace ViewInjection.Views
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private readonly Prism.Ioc.IContainerExtension _container;
      private readonly Prism.Regions.IRegionManager _regionManager;
      public MainWindow(IContainerExtension container, IRegionManager regionManager)
      {
         InitializeComponent();

         this._container = container;
         this._regionManager = regionManager;
      }


      private void Button_Click(object sender, RoutedEventArgs e)
      {
         var view = _container.Resolve(typeof(ViewA));
         Prism.Regions.IRegion region = this._regionManager.Regions["ContentRegion"];
         region.Add(view);
      }
   }
}
