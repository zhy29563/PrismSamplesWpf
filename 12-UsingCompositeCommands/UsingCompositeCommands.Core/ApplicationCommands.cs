using Prism.Commands;

namespace UsingCompositeCommands.Core
{
   

   public class ApplicationCommands : IApplicationCommands
   {
      private readonly CompositeCommand _saveCommand = new CompositeCommand();
      public CompositeCommand SaveCommand
      {
         get { return _saveCommand; }
      }
   }
}
