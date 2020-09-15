using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace BootstrapperShell
{
   class Bootstrapper : Prism.Unity.UnityBootstrapper
   {
      protected override DependencyObject CreateShell()
      {
         return (Views.MainWindow)Container.Resolve(typeof(Views.MainWindow));
      }

      protected override void InitializeShell()
      {
         Application.Current.MainWindow.Show();
      }
   }
}
