using ModuleForRegionMemberLifetime.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForRegionMemberLifetime
{
    public class ModuleForRegionMemberLifetimeModule : IModule
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