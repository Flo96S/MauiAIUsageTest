using AIUsageTestBingCopilot.ViewModels;

namespace AIUsageTestBingCopilot.Pages;

public partial class AddProductPage : ContentPage
{
	public AddProductPage(ShoppingListViewModel model)
	{
		InitializeComponent();
		BindingContext = new AddProductPageViewModel(model); //added by hand
	}
}