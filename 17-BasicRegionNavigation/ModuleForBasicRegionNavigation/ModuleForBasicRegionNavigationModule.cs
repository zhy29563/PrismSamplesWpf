using ModuleForBasicRegionNavigation.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForBasicRegionNavigation
{
   public class ModuleForBasicRegionNavigationModule : IModule
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