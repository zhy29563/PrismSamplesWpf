using ChangeConvention.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using System;
using System.Reflection;
using System.Windows;

namespace ChangeConvention
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
         base.ConfigureViewModelLocator();

         ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(CustomedViewTypeToViewModelType);
      }

      private Type CustomedViewTypeToViewModelType(Type viewType)
      {
         var viewName = viewType.FullName;
         var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
         var viewModelName = $"{ viewName }ViewModel, {viewAssemblyName}";
         return Type.GetType(viewModelName);
      }
   }
}
