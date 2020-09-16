using ModuleForNavigationParticipation.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForNavigationParticipation
{
    public class ModuleForNavigationParticipationModule : IModule
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