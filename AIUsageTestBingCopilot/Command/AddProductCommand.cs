using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AIUsageTestBingCopilot.ViewModels;
using AIUsageTestBingCopilot.Pages;

namespace AIUsageTestBingCopilot.Command
{
    public class AddProductCommand : ICommand
    {
        // Bing Copilot had trouble creating this class. Maybe it was my incompetence or the lack of context.
        // I used the GitHub Copilot way for this class.
        private readonly ShoppingListViewModel _viewModel;

        public AddProductCommand(ShoppingListViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Add your CanExecute logic here
            return true; // Replace with your own condition
        }

        public void Execute(object parameter)
        {
            // Add your Execute logic here
            //Debug.WriteLine("Button Clicked");
            _viewModel._navigation.PushAsync(new AddProductPage(_viewModel)); //replaced by hand
        }
    }
}
