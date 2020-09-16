using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleForRegionMemberLifetime.ViewModels
{
   public class ViewBViewModel : BindableBase, INavigationAware
   {
      public ViewBViewModel()
      {

      }

      public bool IsNavigationTarget(NavigationContext navigationContext)
      {
         return false;
      }

      public void OnNavigatedFrom(NavigationContext navigationContext)
      {

      }

      public void OnNavigatedTo(NavigationContext navigationContext)
      {

      }
   }
}
