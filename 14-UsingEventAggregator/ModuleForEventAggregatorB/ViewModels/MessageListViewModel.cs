using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForEventAggregatorB.ViewModels
{
   public class MessageListViewModel : BindableBase
   {
      private string _message = "View A from your Prism Module";
      public string Message
      {
         get { return _message; }
         set { SetProperty(ref _message, value); }
      }


      Prism.Events.IEventAggregator _ea;

      private System.Collections.ObjectModel.ObservableCollection<string> _messages;
      public System.Collections.ObjectModel.ObservableCollection<string> Messages
      {
         get { return _messages; }
         set { SetProperty(ref _messages, value); }
      }

      public MessageListViewModel(Prism.Events.IEventAggregator ea)
      {
         _ea = ea;
         Messages = new System.Collections.ObjectModel.ObservableCollection<string>();

         _ea.GetEvent<UsingEventAggregator.Core.MessageSentEvent>().Subscribe(MessageReceived);
      }

      private void MessageReceived(string message)
      {
         Messages.Add(message);
      }
   }
}
