using UsingIActiveAwareCommands.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace UsingIActiveAwareCommands
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App
   {
      protected override Window CreateShell()
      {
         return Container.Resolve<MainWindow>();
      }

      protected override void RegisterTypes(IContainerRegistry containerRegistry)
      {
         containerRegistry.RegisterSingleton<Core.IApplicationCommands, Core.ApplicationCommands>();
      }

      protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
      {
         moduleCatalog.AddModule<ModuleForIActiveAwareCommands.ModuleForIActiveAwareCommandsModule>();
      }
   }
}
