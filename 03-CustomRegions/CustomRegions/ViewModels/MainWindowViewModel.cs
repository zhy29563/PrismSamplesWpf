namespace CustomRegions.ViewModels
{
    public class MainWindowViewModel : Prism.Mvvm.BindableBase
   {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
