using ModuleForCompositeCommands.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForCompositeCommands
{
   public class ModuleForCompositeCommandsModule : IModule
   {
      public void OnInitialized(IContainerProvider containerProvider)
      {
         // 获取区域
         var regionManager = containerProvider.Resolve<IRegionManager>();
         IRegion region = regionManager.Regions["ContentRegion"];

         // 主界面的区域容器必须支持包含多项
         var tabA = containerProvider.Resolve<ViewA>();
         SetTitle(tabA, "Tab A");
         region.Add(tabA);

         var tabB = containerProvider.Resolve<ViewA>();
         SetTitle(tabB, "Tab B");
         region.Add(tabB);

         var tabC = containerProvider.Resolve<ViewA>();
         SetTitle(tabC, "Tab C");
         region.Add(tabC);
      }

      public void RegisterTypes(IContainerRegistry containerRegistry)
      {

      }

      void SetTitle(ViewA tab, string title)
      {
         (tab.DataContext as ViewModels.ViewAViewModel).Title = title;
      }
   }
}