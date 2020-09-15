using CustomRegistrations.ViewModels;
using CustomRegistrations.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace CustomRegistrations
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

        }

      protected override void ConfigureViewModelLocator()
      {
         // Prism首先在注册的类型中查找合适的View与ViewModel的关联
         // 如何在注册的类型中未找到，才会使用命名转换
         base.ConfigureViewModelLocator();

         // type / type
         //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), typeof(MainWindowViewModel));

         // type / factory
         //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), () => Container.Resolve<MainWindowViewModel>());

         // generic factory
         //ViewModelLocationProvider.Register<MainWindow>(() => Container.Resolve<MainWindowViewModel>());

         // generic type
         Prism.Mvvm.ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
      }
   }
}
