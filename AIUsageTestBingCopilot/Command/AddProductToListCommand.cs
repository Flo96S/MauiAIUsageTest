﻿using AIUsageTestBingCopilot.Models;
using AIUsageTestBingCopilot.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AIUsageTestBingCopilot.Command
{
    public class AddProductToListCommand : ICommand
    {
        // Bing Copilot had trouble creating Commands. Maybe it was my incompetence or the lack of context.
        // I used the GitHub Copilot way for this class.
        private readonly ShoppingListViewModel viewModel;
        private readonly AddProductPageViewModel addViewModel;

        public AddProductToListCommand(ShoppingListViewModel viewModel, AddProductPageViewModel secondViewModel)
        {
            this.viewModel = viewModel;
            this.addViewModel = secondViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Add your logic here to determine if the command can be executed
            return true;
        }

        public void Execute(object parameter)
        {
            // Add your logic here to execute the command
            //viewModel.AddItem(addViewModel.NewItem); //Generated by GitHub Copilot Chat with bad prompt
            //viewModel.AddItem(addViewModel.ProductName, addViewModel.Count); //Generated by GitHub Copilot Completion function
            viewModel.Items.Add(new ShoppingListModel { Name = addViewModel.ProductName, Quantity = addViewModel.Amount }); //replaced by hand + GitHub Copilot Completion function

            //Generated by GitHub Copilot Chat
            // Pop the view from navigation
            // Assuming you are using a navigation service, you can call the Pop method to remove the current view from the navigation stack
            //navigationService.Pop();

            viewModel._navigation.PopAsync(); //replaced by hand
        }
    }
}
