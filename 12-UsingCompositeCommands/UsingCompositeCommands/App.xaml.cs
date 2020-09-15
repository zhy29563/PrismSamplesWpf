using UsingCompositeCommands.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace UsingCompositeCommands
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
         // 注册一个命令服务
         // 关联的命令接口与接口实现
         containerRegistry.RegisterSingleton<Core.IApplicationCommands, Core.ApplicationCommands>();
      }

      protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
      {
         // 通过代码增加模块
         moduleCatalog.AddModule<ModuleForCompositeCommands.ModuleForCompositeCommandsModule>();
      }
   }
}
