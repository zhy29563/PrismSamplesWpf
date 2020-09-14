using Prism.Modularity;
using System.Windows;

namespace ModulesWithLoadManual.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly IModuleManager _moduleManager;
        public MainWindow(IModuleManager moduleManager)
        {
            InitializeComponent();

            this._moduleManager = moduleManager;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _moduleManager.LoadModule("ModuleAModule");
        }
    }
}
