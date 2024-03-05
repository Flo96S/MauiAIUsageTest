using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AIUsageTestBingCopilot.Command;
using AIUsageTestBingCopilot.ViewModels;

namespace AIUsageTestBingCopilot.ViewModels
{
    // A class that represents the view model for the add product page
    public class AddProductPageViewModel : INotifyPropertyChanged
    {
        //Added by hand
        public ICommand AddProductCommand { get; set; }


        // A constructor that takes the shopping list view model as a parameter
        public AddProductPageViewModel(ShoppingListViewModel shoppingListViewModel)
        {
            // Assign the shopping list view model to the field
            _shoppingListViewModel = shoppingListViewModel;
            AddProductCommand = new AddProductToListCommand(shoppingListViewModel, this);
        }

        // A field that holds the shopping list view model
        private readonly ShoppingListViewModel _shoppingListViewModel;

        // A field that holds the product name
        private string _productName;

        // A field that holds the amount
        private int _amount;

        // An event that is raised when a property value changes
        public event PropertyChangedEventHandler PropertyChanged;

        // A property that gets or sets the product name
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        // A property that gets or sets the amount
        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        // A method that raises the PropertyChanged event
        private void OnPropertyChanged(string propertyName)
        {
            // Invoke the event handler if not null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
