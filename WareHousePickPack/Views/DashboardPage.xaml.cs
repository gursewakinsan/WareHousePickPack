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

        private void OnPickedItemTapped(object sender, ItemTappedEventArgs e)
        {
            listPicked.SelectedItem = null;
        }

        private void OnPackedItemTapped(object sender, ItemTappedEventArgs e)
        {
            listPacked.SelectedItem = null;
        }
    }
}