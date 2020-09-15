using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForCompositeCommands.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message = "View A from your Prism Module";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

      private string _title;
      public string Title
      {
         get { return _title; }
         set { SetProperty(ref _title, value); }
      }

      private bool _canUpdate = true;
      public bool CanUpdate
      {
         get { return _canUpdate; }
         set { SetProperty(ref _canUpdate, value); }
      }

      private string _updatedText;
      public string UpdateText
      {
         get { return _updatedText; }
         set { SetProperty(ref _updatedText, value); }
      }

      public DelegateCommand UpdateCommand { get; private set; }

      private readonly UsingCompositeCommands.Core.IApplicationCommands _applicationCommands;

      public ViewAViewModel(UsingCompositeCommands.Core.IApplicationCommands applicationCommands)
      {
         _applicationCommands = applicationCommands;

         // 创建本地命令
         UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);

         // 将本地命令注册为复合命令
         _applicationCommands.SaveCommand.RegisterCommand(UpdateCommand);
      }

      private void Update()
      {
         UpdateText = $"Updated: {DateTime.Now}";
      }
   }
}
