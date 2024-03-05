using AIUsageTestGitHubCopilot.ViewModels;
using System.Diagnostics;

namespace AIUsageTestGitHubCopilot
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ShoppingListViewModel(Navigation);
        }
    }

}
