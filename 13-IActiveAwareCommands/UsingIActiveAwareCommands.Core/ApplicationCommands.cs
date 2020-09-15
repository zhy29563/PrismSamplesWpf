using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIActiveAwareCommands.Core
{
   public interface IApplicationCommands
   {
      Prism.Commands.CompositeCommand SaveCommand { get; }
   }

   public class ApplicationCommands : IApplicationCommands
   {
      private Prism.Commands.CompositeCommand _saveCommand = new Prism.Commands.CompositeCommand(true);
      public Prism.Commands.CompositeCommand SaveCommand
      {
         get { return _saveCommand; }
      }
   }
}
