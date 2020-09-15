using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForFilterEventsB.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private string _message = "MessageListViewModel";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MessageListViewModel(Prism.Events.IEventAggregator ea)
        {
         _ea = ea;
         Messages = new System.Collections.ObjectModel.ObservableCollection<string>();

         _ea.GetEvent<UsingFilteringEvents.Core.MessageSentEvent>().Subscribe(MessageReceived, Prism.Events.ThreadOption.PublisherThread, false, (filter) => filter.Contains("Brian"));
      }


      Prism.Events.IEventAggregator _ea;

      private System.Collections.ObjectModel.ObservableCollection<string> _messages;
      public System.Collections.ObjectModel.ObservableCollection<string> Messages
      {
         get { return _messages; }
         set { SetProperty(ref _messages, value); }
      }


      private void MessageReceived(string message)
      {
         Messages.Add(message);
      }
   }
}
