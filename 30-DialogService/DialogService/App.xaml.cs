using DialogService.ViewModels;
using DialogService.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace DialogService
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App
   {
      protected override Window CreateShell()
      {
         return Container.Resolve<MainWindow>();
      }

      protected override void RegisterTypes(IContainerRegistry containerRegistry)
      {
         containerRegistry.RegisterDialog<NotificationDialog, NotificationDialogViewModel>();
      }
   }
}
