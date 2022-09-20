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
            viewModel.PickOrderDetailInfo = new System.Collections.ObjectModel.ObservableCollection<Models.Product>(selectedOrder.Products);
            viewModel.SelectedPickOrderDetailInfo = selectedOrder;
            btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Minus Tapped.
        private void OnMinusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnMinusButtonClicked(pick);
        }

        private void OnMinusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnMinusButtonClicked(pick);
        }

        private void OnMinusButtonClicked(Models.Product pick)
        {
            if (pick.Quantity > 0)
            {
                pick.Quantity -= 1;
                pick.Total -= pick.PriceUnit;
                viewModel.TotalQuantity -= 1;
                viewModel.TotalPrice -= pick.PriceUnit;
            }
            if (btnPickOrder.IsEnabled)
                btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Plus Tapped.
        private void OnPlusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnPlusButtonClicked(pick);
        }

        private void OnPlusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnPlusButtonClicked(pick);
        }

        private void OnPlusButtonClicked(Models.Product pick)
        {
            if (pick.Quantity < pick.TotalQuantity)
            {
                pick.Quantity += 1;
                pick.Total += pick.PriceUnit;
                viewModel.TotalQuantity += 1;
                viewModel.TotalPrice += pick.PriceUnit;
            }
            if (viewModel.SelectedPickOrderDetailInfo.TotalQuantity == viewModel.TotalQuantity)
                btnPickOrder.IsEnabled = true;
            else
                btnPickOrder.IsEnabled = false;
        }
        #endregion

        #region On Clear Button Tapped.
        private void OnClearBoxTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnClearButtonClicked(pick);
        }

        private void OnClearLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            Models.Product pick = control.BindingContext as Models.Product;
            OnClearButtonClicked(pick);
        }

        private void OnClearButtonClicked(Models.Product pick)
        {
            if (pick.Quantity > 0)
            {
                viewModel.TotalQuantity -= pick.Quantity;
                viewModel.TotalPrice -= pick.Total;
                pick.Quantity = 0;
                pick.Total = 0;
            }
            btnPickOrder.IsEnabled = false;
        }
        #endregion
    }
}