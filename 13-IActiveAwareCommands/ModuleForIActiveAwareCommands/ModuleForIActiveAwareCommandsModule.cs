using ModuleForIActiveAwareCommands.ViewModels;
using ModuleForIActiveAwareCommands.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForIActiveAwareCommands
{
   public class ModuleForIActiveAwareCommandsModule : IModule
   {
      public void OnInitialized(IContainerProvider containerProvider)
      {
         var regionManager = containerProvider.Resolve<IRegionManager>();
         IRegion region = regionManager.Regions["ContentRegion"];

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
         (tab.DataContext as ViewAViewModel).Title = title;
      }
   }
}