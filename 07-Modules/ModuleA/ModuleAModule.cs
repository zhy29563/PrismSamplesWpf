using Prism.Ioc;

namespace ModuleA
{
    public class ModuleAModule : Prism.Modularity.IModule
    {
        // 其次调用该方法，通常用于关联区域与视图
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // 获取区域管理器
            var regionManager = containerProvider.Resolve<Prism.Regions.IRegionManager>();

            // 关联命名区域与特定视图类型
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.ViewA));
        }

        // 首先调用该方法，通常用于注册服务
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
