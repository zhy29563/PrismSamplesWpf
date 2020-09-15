using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCompositeCommands.Core
{
   public interface IApplicationCommands
   {
      Prism.Commands.CompositeCommand SaveCommand { get; }
   }
}
