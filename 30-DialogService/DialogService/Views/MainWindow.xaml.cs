using Prism.Services.Dialogs;
using System.Windows;

namespace DialogService.Views
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private readonly Prism.Services.Dialogs.IDialogService _dialogService;
      public MainWindow(Prism.Services.Dialogs.IDialogService dialogService)
      {
         InitializeComponent();
         _dialogService = dialogService;
      }

      private void ShowDialog()
      {
         var message = "This is a message that should be shown in the dialog.";

         _dialogService.ShowDialog("NotificationDialog", new Prism.Services.Dialogs.DialogParameters($"message={message}"), r =>
         {
            if (r.Result == ButtonResult.None)
               Title = "Result is None";
            else if (r.Result == ButtonResult.OK)
               Title = "Result is OK";
            else if (r.Result == ButtonResult.Cancel)
               Title = "Result is Cancel";
            else
               Title = "I Don't know what you did!?";
         });
      }

      private void Button_Click(object sender, RoutedEventArgs e)
      {
         this.ShowDialog();
      }
   }
}
