using AIUsageTestBingCopilot.Models;
using System.Diagnostics;

namespace AIUsageTestBingCopilot.Views;

public partial class ShoppingItem : ContentView
{
	public ShoppingItem()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        Debug.WriteLine(BindingContext);
        if (BindingContext is ShoppingListModel model)
        {
            Debug.WriteLine($"ShoppingItem: {model.Name} - {model.Quantity}");
        }
    }
}