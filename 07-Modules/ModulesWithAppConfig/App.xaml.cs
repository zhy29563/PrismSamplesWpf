using ModulesWithAppConfig.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace ModulesWithAppConfig
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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            // // ModuleA.dll需要拷贝到当前运行路径下
            return new ConfigurationModuleCatalog();
        }
    }
}
