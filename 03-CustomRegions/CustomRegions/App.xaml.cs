using Prism.Ioc;
using Prism.Unity;

namespace CustomRegions
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App
   {
      protected override System.Windows.Window CreateShell()
      {
         return Container.Resolve<Views.MainWindow>();
      }

      protected override void RegisterTypes(Prism.Ioc.IContainerRegistry containerRegistry)
      {

      }

      protected override void ConfigureRegionAdapterMappings(Prism.Regions.RegionAdapterMappings regionAdapterMappings)
      {
         base.ConfigureRegionAdapterMappings(regionAdapterMappings);

         regionAdapterMappings.RegisterMapping(typeof(System.Windows.Controls.StackPanel), Container.Resolve<StackPanelRegionAdapter>());
      }
   }
}
