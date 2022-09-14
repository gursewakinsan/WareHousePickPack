using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        DashboardPageViewModel viewModel;
        public DashboardPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new DashboardPageViewModel(this.Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetPickedDataCommand.Execute(null);
        }
        private async void OnPickedItemTapped(object sender, ItemTappedEventArgs e)
        {
            listPicked.SelectedItem = null;
            await Navigation.PushAsync(new SelectedPickOrderPage());
        }

        private async void OnPackedItemTapped(object sender, ItemTappedEventArgs e)
        {
            listPacked.SelectedItem = null;
            await Navigation.PushAsync(new SelectedPickOrderPage());
        }
    }
}