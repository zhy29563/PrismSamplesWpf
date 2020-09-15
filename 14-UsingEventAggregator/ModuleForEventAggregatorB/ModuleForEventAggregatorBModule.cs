using ModuleForEventAggregatorB.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForEventAggregatorB
{
   public class ModuleForEventAggregatorBModule : IModule
   {
      public void OnInitialized(IContainerProvider containerProvider)
      {
         var regionManager = containerProvider.Resolve<IRegionManager>();
         regionManager.RegisterViewWithRegion("RightRegion", typeof(MessageList));
      }

      public void RegisterTypes(IContainerRegistry containerRegistry)
      {

      }
   }
}