using ModuleForConfirmCancelNavigation.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForConfirmCancelNavigation
{
   public class ModuleForConfirmCancelNavigationModule : IModule
   {
      public void OnInitialized(IContainerProvider containerProvider)
      {

      }

      public void RegisterTypes(IContainerRegistry containerRegistry)
      {
         containerRegistry.RegisterForNavigation<ViewA>();
         containerRegistry.RegisterForNavigation<ViewB>();
      }
   }
}