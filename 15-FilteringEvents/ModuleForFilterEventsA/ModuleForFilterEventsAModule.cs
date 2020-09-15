using ModuleForFilterEventsA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForFilterEventsA
{
    public class ModuleForFilterEventsAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
         var regionManager = containerProvider.Resolve<IRegionManager>();
         regionManager.RegisterViewWithRegion("LeftRegion", typeof(MessageView));
      }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}