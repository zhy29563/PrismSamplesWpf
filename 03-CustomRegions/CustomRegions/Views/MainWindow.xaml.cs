using System.Windows;

namespace CustomRegions.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
      public MainWindow(Prism.Regions.IRegionManager regionManager)
      {
         InitializeComponent();

         regionManager.RegisterViewWithRegion("ContentRegion", typeof(CustomedStackPanel));
      }
   }
}
