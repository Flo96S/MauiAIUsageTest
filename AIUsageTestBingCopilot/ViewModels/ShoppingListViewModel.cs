using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Input;
using AIUsageTestBingCopilot.Models;
using AIUsageTestBingCopilot.Pages;

namespace AIUsageTestBingCopilot.ViewModels
{
    // A class that represents the view model for the shopping list page
    public class ShoppingListViewModel : INotifyPropertyChanged
    {
        // A field that holds the navigation service
        public readonly INavigation _navigation; //Changed access modifier to public by hand

        // A field that holds the collection of shopping list items
        private ObservableCollection<ShoppingListModel> _items;

        // A field that holds the command for adding a new item
        //private ICommand _addProductCommand; added by Bing Copilot
        public ICommand AddProductCommand { get; set; }

        // An event that is raised when a property value changes
        public event PropertyChangedEventHandler PropertyChanged;

        // A property that gets or sets the collection of shopping list items
        public ObservableCollection<ShoppingListModel> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        // A property that gets the command for adding a new item
        /*
        public ICommand AddProductCommand
        {
            get
            {
                if (_addProductCommand == null)
                {
                    _addProductCommand = new Command(AddProduct); //added by Bing Copilot
                }
                return _addProductCommand;
            }
        }
        */
        // A constructor that takes a navigation parameter
        public ShoppingListViewModel(INavigation navigation)
        {
            // Assign the navigation service
            _navigation = navigation;
            AddProductCommand = new Command.AddProductCommand(this); //added by hand
            // Load the items from the file
            LoadItems();
        }

        // A method that adds a new item to the collection
        private async void AddProduct()
        {
            // Navigate to the add product page
            await _navigation.PushAsync(new AddProductPage(this));
        }

        /*
         * Added by Bing Copilot Save/Load with BinaryFormatter is obsolete and not working!
         */
        // A method that saves the items to a file
        public void SaveItems()
        {
            // Create a binary formatter
            //BinaryFormatter formatter = new BinaryFormatter(); 

            // Create a file stream
            using (FileStream stream = File.Create("items.dat"))
            {
                // Serialize the items to the stream
                //formatter.Serialize(stream, Items);
            }
        }

        // A method that loads the items from a file
        public void LoadItems()
        {
            // Create a binary formatter
            //BinaryFormatter formatter = new BinaryFormatter();

            // Check if the file exists
            if (File.Exists("items.dat"))
            {
                // Create a file stream
                using (FileStream stream = File.OpenRead("items.dat"))
                {
                    // Deserialize the items from the stream
                    //Items = (ObservableCollection<ShoppingListModel>)formatter.Deserialize(stream);
                }
            }
            else
            {
                // Initialize the items with some sample data
                Items = new ObservableCollection<ShoppingListModel>
                {
                    //new ShoppingListModel("Milk", 2),  //Bing Copilot added this extra without asked for it
                    //new ShoppingListModel("Eggs", 12), //Bing Copilot added this extra without asked for it
                    //new ShoppingListModel("Bread", 1)  //Bing Copilot added this extra without asked for it
                };
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
