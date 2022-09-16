using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedPickOrderPage : ContentPage
    {
        #region Variables.
        SelectedPickOrderPageViewModel viewModel;
        #endregion

        #region Constructor.
        public SelectedPickOrderPage(Models.Order selectedOrder)
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new SelectedPickOrderPageViewModel(this.Navigation);
            viewModel.PickOrderDetailInfo = new System.Collections.ObjectModel.ObservableCollection<Models.Order>();
            viewModel.PickOrderDetailInfo.Add(selectedOrder);
            viewModel.SelectedPickOrderDetailInfo = selectedOrder;
            btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Minus Tapped.
        private void OnMinusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            Models.Order pick = control.BindingContext as Models.Order;
            if (pick.Quantity > 0)
            {
                pick.Quantity -= 1;
                pick.Total -= pick.PriceUnit;
            }
            if (btnPickOrder.IsEnabled)
                btnPickOrder.IsEnabled = false;
        }

        private void OnMinusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Order pick = control.BindingContext as Models.Order;
            if (pick.Quantity > 0)
            {
                pick.Quantity -= 1;
                pick.Total -= pick.PriceUnit;
            }
            if (btnPickOrder.IsEnabled)
                btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Plus Tapped.
        private void OnPlusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            Models.Order pick = control.BindingContext as Models.Order;
            if (pick.Quantity < pick.TotalQuantity)
            {
                pick.Quantity += 1;
                pick.Total += pick.PriceUnit;
            }
            if (pick.Quantity == pick.TotalQuantity)
                btnPickOrder.IsEnabled = true;
            else
                btnPickOrder.IsEnabled = false;
        }

        private void OnPlusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Order pick = control.BindingContext as Models.Order;
            if (pick.Quantity < pick.TotalQuantity)
            {
                pick.Quantity += 1;
                pick.Total += pick.PriceUnit;
            }
            if (pick.Quantity == pick.TotalQuantity)
                btnPickOrder.IsEnabled = true;
            else
                btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Clear Button Tapped.
        private void OnClearButtonTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Order pick = control.BindingContext as Models.Order;
            if (pick.Quantity > 0)
            {
                pick.Quantity = 0;
                pick.Total = 0;
            }
            btnPickOrder.IsEnabled = false;
        }
        #endregion
    }
}