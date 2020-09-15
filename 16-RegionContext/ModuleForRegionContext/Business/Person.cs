using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleForRegionContext.Business
{
   public class Person : System.ComponentModel.INotifyPropertyChanged
   {
      #region Properties

      private string _firstName;
      public string FirstName
      {
         get { return _firstName; }
         set
         {
            _firstName = value;
            OnPropertyChanged();
         }
      }

      private string _lastName;
      public string LastName
      {
         get { return _lastName; }
         set
         {
            _lastName = value;
            OnPropertyChanged();
         }
      }

      private int _age;
      public int Age
      {
         get { return _age; }
         set
         {
            _age = value;
            OnPropertyChanged();
         }
      }

      private DateTime? _lastUpdated;
      public DateTime? LastUpdated
      {
         get { return _lastUpdated; }
         set
         {
            _lastUpdated = value;
            OnPropertyChanged();
         }
      }

      #endregion //Properties

      #region INotifyPropertyChanged

      public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyname = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
      }

      #endregion //INotifyPropertyChanged

      public override string ToString()
      {
         return String.Format("{0}, {1}", LastName, FirstName);
      }
   }
}
