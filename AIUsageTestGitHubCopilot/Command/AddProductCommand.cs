using AIUsageTestGitHubCopilot.Pages;
using AIUsageTestGitHubCopilot.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AIUsageTestGitHubCopilot.Command
{
    public class AddProductCommand : ICommand
    {
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
            _viewModel._navigation.PushAsync(new AddProductPage(_viewModel)); //replaced by hand
        }
    }
}
