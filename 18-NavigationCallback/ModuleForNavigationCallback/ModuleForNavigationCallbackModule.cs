using ModuleForNavigationCallback.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForNavigationCallback
{
   public class ModuleForNavigationCallbackModule : IModule
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