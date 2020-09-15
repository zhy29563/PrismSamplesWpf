using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForEventAggregatorA.ViewModels
{
   public class MessageViewModel : BindableBase
   {
      private string _message = "View A from your Prism Module";
      public string Message
      {
         get { return _message; }
         set { SetProperty(ref _message, value); }
      }

      public MessageViewModel(Prism.Events.IEventAggregator ea)
      {
         _ea = ea;
         this.SendMessageCommand = new DelegateCommand(SendMessage);
      }

      private readonly Prism.Events.IEventAggregator _ea;


      public DelegateCommand SendMessageCommand { get; private set; }


      private void SendMessage()
      {
         _ea.GetEvent<UsingEventAggregator.Core.MessageSentEvent>().Publish(Message);
      }
   }
}
