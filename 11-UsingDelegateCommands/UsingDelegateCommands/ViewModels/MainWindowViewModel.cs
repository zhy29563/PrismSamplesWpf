using Prism.Commands;
using Prism.Mvvm;
using System.Threading;
using System.Threading.Tasks;

namespace UsingDelegateCommands.ViewModels
{
   public class MainWindowViewModel : BindableBase
   {
      // 用于更新窗体标题
      private string _title = "Prism Application";
      public string Title
      {
         get { return _title; }
         set { SetProperty(ref _title, value); }
      }


      // 用于指示命令是否可以执行
      private bool _isEnabled;
      public bool IsEnabled
      {
         get { return _isEnabled; }
         set
         {
            SetProperty(ref _isEnabled, value);

            // 强制更新界面元素
            ExecuteDelegateCommand.RaiseCanExecuteChanged();
         }
      }

      // 命令的显示结果
      private string _updateText;
      public string UpdateText
      {
         get { return _updateText; }
         set { SetProperty(ref _updateText, value); }
      }


      public Prism.Commands.DelegateCommand ExecuteDelegateCommand { get; private set; }

      public Prism.Commands.DelegateCommand<string> ExecuteGenericDelegateCommand { get; private set; }

      public Prism.Commands.DelegateCommand DelegateCommandObservesProperty { get; private set; }

      public Prism.Commands.DelegateCommand DelegateCommandObservesCanExecute { get; private set; }

      public DelegateCommand AsyncMethodCommandOne { get; private set; }

      public DelegateCommand AsyncMethodCommandTwo { get; private set; }


      public MainWindowViewModel()
      {
         ExecuteDelegateCommand = new Prism.Commands.DelegateCommand(Execute, CanExecute);

         // 指定监视属性，当该属性发生变化时，自动调用RaiseCanExecuteChanged方法通知界面状态已改变
         DelegateCommandObservesProperty = new Prism.Commands.DelegateCommand(Execute, CanExecute).ObservesProperty(() => IsEnabled);

         // 如果程序中的CanExcute委托的结果是简单的布尔值，可以省去CanExcute委托的声明。不仅能够通过UI状态改变，而且使用与真实的CanExcute委托相同的属性
         DelegateCommandObservesCanExecute = new Prism.Commands.DelegateCommand(Execute).ObservesCanExecute(() => IsEnabled);

         // 为命令指定参数
         ExecuteGenericDelegateCommand = new Prism.Commands.DelegateCommand<string>(ExecuteGeneric).ObservesCanExecute(() => IsEnabled);



         AsyncMethodCommandOne = new DelegateCommand(ExecuteCommandNameOne, CanExecute).ObservesProperty(() => IsEnabled);

         AsyncMethodCommandTwo = new DelegateCommand(async () => await ExecuteCommandName(), CanExecute).ObservesProperty(() => IsEnabled);
      }

      private void Execute()
      {
         UpdateText = $"Updated: {System.DateTime.Now}";
      }

      private void ExecuteGeneric(string parameter)
      {
         UpdateText = parameter; 
      }

      private string commandParameter = "DefaultParameter";
      public string CommandParameter
      {
         get { return commandParameter; }
         set { SetProperty(ref commandParameter, value); }
      }

      private bool CanExecute()
      {
         return IsEnabled; 
      }


      async void ExecuteCommandNameOne()
      {
         await Task.Factory.StartNew(() =>
         {
            Thread.Sleep(3000);
         });

         Execute();
      }

      

      Task ExecuteCommandName()
      {
         return Task.Factory.StartNew(() =>
         {
            Thread.Sleep(3000);
            Execute();
         });
      }

   }
}
