using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomRequest.Views
{
   /// <summary>
   /// CustomPopupView.xaml 的交互逻辑
   /// </summary>
   public partial class CustomPopupView : UserControl, IInteractionRequestAware
   {
      public CustomPopupView()
      {
         InitializeComponent();
      }

      private void Button_Click(object sender, RoutedEventArgs e)
      {
         FinishInteraction?.Invoke();
      }

      public Action FinishInteraction { get; set; }
      public INotification Notification { get; set; }
   }
}
