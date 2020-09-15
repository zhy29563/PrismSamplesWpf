using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFilteringEvents.Core
{
    public class MessageSentEvent : Prism.Events.PubSubEvent<string>
   {
    }
}
