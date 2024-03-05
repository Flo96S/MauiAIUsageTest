using AIUsageTestGitHubCopilot.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AIUsageTestGitHubCopilot.ViewModels
{
    public class AddProductPageViewModel : INotifyPropertyChanged
    {
        private string _productName;
        private int _count = 1; // variable replaced by hand [0]
        private ShoppingListViewModel _shoppingListViewModel;
        public ICommand SubmitButtonCommand { get; set; } // replaced by hand GitHub Copilot generated this as a private ICommand

        public AddProductPageViewModel(ShoppingListViewModel shoppingListViewModel)
        {
            _shoppingListViewModel = shoppingListViewModel;
            //_submitButtonCommand = new RelayCommand(SubmitButtonCommandExecute, SubmitButtonCommandCanExecute); GitHub Copilot generated this line
            SubmitButtonCommand = new AddProductToListCommand(_shoppingListViewModel, this); //replaced by hand
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    OnPropertyChanged();
                }
            } // Github Copilot wanted to assign number here [0]
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
