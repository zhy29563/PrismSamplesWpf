using System.Windows;

namespace ActivationDeactivation.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      private Prism.Ioc.IContainerExtension _container;
      private Prism.Regions.IRegionManager _regionManager;
      private Prism.Regions.IRegion _region;
      private ViewA _viewA;
      private ViewB _viewB;
      public MainWindow(Prism.Ioc.IContainerExtension container, Prism.Regions.IRegionManager regionManager)
        {
            InitializeComponent();

         this._container = container;
         this._regionManager = regionManager;

         this.Loaded += MainWindow_Loaded;
        }

      private void MainWindow_Loaded(object sender, RoutedEventArgs e)
      {
         _viewA = (ViewA)_container.Resolve(typeof(ViewA));
         _viewB = (ViewB)_container.Resolve(typeof(ViewB));

         _region = _regionManager.Regions["ContentRegion"];

         _region.Add(_viewA);
         _region.Add(_viewB);
      }

      private void Button_Click(object sender, RoutedEventArgs e)
      {
         //activate view a
         _region.Activate(_viewA);
      }

      private void Button_Click_1(object sender, RoutedEventArgs e)
      {
         //deactivate view a
         _region.Deactivate(_viewA);
      }

      private void Button_Click_2(object sender, RoutedEventArgs e)
      {
         //activate view b
         _region.Activate(_viewB);
      }

      private void Button_Click_3(object sender, RoutedEventArgs e)
      {
         //deactivate view b
         _region.Deactivate(_viewB);
      }
   }
}
