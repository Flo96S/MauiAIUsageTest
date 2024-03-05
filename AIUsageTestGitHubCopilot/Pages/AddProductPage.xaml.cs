using AIUsageTestGitHubCopilot.ViewModels;

namespace AIUsageTestGitHubCopilot.Pages;

public partial class AddProductPage : ContentPage
{
    public AddProductPage(ShoppingListViewModel shoppingListViewModel)
    {
        InitializeComponent();
        BindingContext = new AddProductPageViewModel(shoppingListViewModel);
    }
}
