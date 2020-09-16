using ModuleForNavigationJournal.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForNavigationJournal
{
    public class ModuleForNavigationJournalModule : IModule
    {
      public void OnInitialized(IContainerProvider containerProvider)
      {
         var regionManager = containerProvider.Resolve<IRegionManager>();
         regionManager.RequestNavigate("ContentRegion", "PersonList");
      }

      public void RegisterTypes(IContainerRegistry containerRegistry)
      {
         containerRegistry.RegisterForNavigation<PersonList>();
         containerRegistry.RegisterForNavigation<PersonDetail>();
      }
   }
}