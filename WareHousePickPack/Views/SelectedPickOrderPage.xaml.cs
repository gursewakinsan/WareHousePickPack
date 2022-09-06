using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedPickOrderPage : ContentPage
    {
        SelectedPickOrderPageViewModel viewModel;
        public SelectedPickOrderPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new SelectedPickOrderPageViewModel(this.Navigation);
        }
    }
}