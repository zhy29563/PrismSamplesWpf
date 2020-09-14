using ModulesWithXaml.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace ModulesWithXaml
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
            // ModuleCatalog.xaml属性中需要编辑为资源
            // ModuleA.dll需要拷贝到当前运行路径下
            System.Uri uri = new System.Uri("pack://application:,,,/ModulesWithXaml;component/ModuleCatalog.xaml", System.UriKind.RelativeOrAbsolute);
            return ModuleCatalog.CreateFromXaml(uri);
        }
    }
}