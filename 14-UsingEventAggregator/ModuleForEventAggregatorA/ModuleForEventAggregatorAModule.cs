using ModuleForEventAggregatorA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForEventAggregatorA
{
    public class ModuleForEventAggregatorAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
         // 获取区域管理器
         var regionManager = containerProvider.Resolve<IRegionManager>();

         // 将指定名称的区域与特定类型的视图相关联
         regionManager.RegisterViewWithRegion("LeftRegion", typeof(MessageView));
      }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}