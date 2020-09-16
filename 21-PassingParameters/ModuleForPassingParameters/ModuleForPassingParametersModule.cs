using ModuleForPassingParameters.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleForPassingParameters
{
   public class ModuleForPassingParametersModule : IModule
   {
      public void OnInitialized(IContainerProvider containerProvider)
      {
         var regionManager = containerProvider.Resolve<IRegionManager>();
         regionManager.RegisterViewWithRegion("ContentRegion", typeof(PersonList));
      }

      public void RegisterTypes(IContainerRegistry containerRegistry)
      {
         containerRegistry.RegisterForNavigation<PersonDetail>();
      }
   }
}