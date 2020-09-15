using Prism.Mvvm;

namespace UsingCompositeCommands.ViewModels
{
   public class MainWindowViewModel : BindableBase
   {
      private string _title = "Prism Application";
      public string Title
      {
         get { return _title; }
         set { SetProperty(ref _title, value); }
      }


      // 定义一个复合命令，并导出为属性以便于View绑定
      private Core.IApplicationCommands _applicationCommands;
      public Core.IApplicationCommands ApplicationCommands
      {
         get { return _applicationCommands; }
         set { SetProperty(ref _applicationCommands, value); }
      }

      public MainWindowViewModel(Core.IApplicationCommands applicationCommands)
      {
         ApplicationCommands = applicationCommands;
      }
   }
}
