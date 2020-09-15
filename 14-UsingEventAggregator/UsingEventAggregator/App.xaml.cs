using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using UsingEventAggregator.Views;

namespace UsingEventAggregator
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : PrismApplication
   {
      protected override Window CreateShell()
      {
         return Container.Resolve<MainWindowView>();
      }

      protected override void RegisterTypes(IContainerRegistry containerRegistry)
      {

      }

      protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
      {
         // 配置模块
         moduleCatalog.AddModule<ModuleForEventAggregatorA.ModuleForEventAggregatorAModule>();
         moduleCatalog.AddModule<ModuleForEventAggregatorB.ModuleForEventAggregatorBModule>();
      }
   }
}
