using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForIActiveAwareCommands.ViewModels
{
    public class ViewAViewModel : BindableBase, Prism.IActiveAware
   {
        private string _message = "View A from your Prism Module";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

      public DelegateCommand UpdateCommand { get; private set; }
      private readonly UsingIActiveAwareCommands.Core.IApplicationCommands _applicationCommands;
      public ViewAViewModel(UsingIActiveAwareCommands.Core.IApplicationCommands applicationCommands)
      {
         // 获取复合命令
         _applicationCommands = applicationCommands;

         // 创建本地命令
         UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);

         // 将本地命令注册为复合命令
         _applicationCommands.SaveCommand.RegisterCommand(UpdateCommand);
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

      private void Update()
      {
         UpdateText = $"Updated: {DateTime.Now}";
      }

      bool _isActive;
      public bool IsActive
      {
         get { return _isActive; }
         set
         {
            _isActive = value;
            OnIsActiveChanged();
         }
      }
      private void OnIsActiveChanged()
      {
         UpdateCommand.IsActive = IsActive;

         IsActiveChanged?.Invoke(this, new EventArgs());
      }


      public event EventHandler IsActiveChanged;
   }
}
