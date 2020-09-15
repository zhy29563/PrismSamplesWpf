using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForFilterEventsA.ViewModels
{
   public class MessageViewModel : BindableBase
   {

      public MessageViewModel(Prism.Events.IEventAggregator ea)
      {
         _ea = ea;
         SendMessageCommand = new DelegateCommand(SendMessage);
      }

      Prism.Events.IEventAggregator _ea;

      private string _message = "Message to Send";
      public string Message
      {
         get { return _message; }
         set { SetProperty(ref _message, value); }
      }

      public DelegateCommand SendMessageCommand { get; private set; }


      private void SendMessage()
      {
         _ea.GetEvent<UsingFilteringEvents.Core.MessageSentEvent>().Publish(Message);
      }
   }
}
