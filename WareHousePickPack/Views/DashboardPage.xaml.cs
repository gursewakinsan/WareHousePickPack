using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        #region Variables.
        DashboardPageViewModel viewModel;
        #endregion

        #region Constructor.
        public DashboardPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new DashboardPageViewModel(this.Navigation);
            viewModel.GetAllWarehouseCommand.Execute(null);
        }
        #endregion

        #region On Appearing.
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetPickOrderItemsCommand.Execute(null);
        }
        #endregion

        #region On Pick Item Tapped.
        private async void OnPickItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Order order = e.Item as Models.Order; ;
            listPick.SelectedItem = null;
            await Navigation.PushAsync(new SelectedPickOrderPage(order));
        }
        #endregion

        #region On Pack Item Tapped.
        private async void OnPackItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Order order = e.Item as Models.Order; ;
            listPack.SelectedItem = null;
            await Navigation.PushAsync(new ProcessToDispatchPage(order));
        }
        #endregion

        #region On Warehouse Changed.
        private void OnWareHouseStackLayoutTapped(object sender, System.EventArgs e)
        {
            if (!pickerWarehouse.IsFocused)
                pickerWarehouse.Focus();
        }

        private void OnWareHouseLabelTapped(object sender, System.EventArgs e)
        {
            if (!pickerWarehouse.IsFocused)
                pickerWarehouse.Focus();
        }
        #endregion

        #region On Warehouse Selected Index Changed.
        private void OnPickerWarehouseSelectedIndexChanged(object sender, System.EventArgs e)
        {
            Controls.CustomPicker picker = sender as Controls.CustomPicker;
            if (picker.SelectedIndex == -1)
                return;

            if (viewModel.IsPicked)
                viewModel.GetPickOrderItemsCommand.Execute(null);
            else
                viewModel.GetPackOrderItemsCommand.Execute(null);
        }
        #endregion
    }
}