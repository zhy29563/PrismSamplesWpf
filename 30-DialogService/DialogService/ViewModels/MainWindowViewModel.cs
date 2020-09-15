using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace DialogService.ViewModels
{
   public class MainWindowViewModel : BindableBase
   {
      private string _title = "Prism Application";
      public string Title
      {
         get { return _title; }
         set { SetProperty(ref _title, value); }
      }
   }
}
