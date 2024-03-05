using AIUsageTestBingCopilot.ViewModels;

namespace AIUsageTestBingCopilot
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
