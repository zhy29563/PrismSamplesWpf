using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForRegionMemberLifetime.ViewModels
{
   public class ViewAViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
   {
      public ViewAViewModel()
      {

      }

      public bool KeepAlive
      {
         get
         {
            return false;
         }
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
