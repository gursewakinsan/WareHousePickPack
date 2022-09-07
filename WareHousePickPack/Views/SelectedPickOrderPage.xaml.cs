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


        private void OnMinusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            PickOrderDetails pick = control.BindingContext as PickOrderDetails;
            if (pick.Quantity > 0)
            {
                pick.Quantity -= 1;
                pick.Total -= pick.PriceUnit;
            }
        }

        private void OnMinusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            PickOrderDetails pick = control.BindingContext as PickOrderDetails;
            if (pick.Quantity > 0)
            {
                pick.Quantity -= 1;
                pick.Total -= pick.PriceUnit;
            }
        }

        private void OnPlusBoxViewTapped(object sender, System.EventArgs e)
        {
            BoxView control = (BoxView)sender;
            PickOrderDetails pick = control.BindingContext as PickOrderDetails;
            if (pick.Quantity < pick.TotalQuantity)
            {
                pick.Quantity += 1;
                pick.Total += pick.PriceUnit;
            }
        }

        private void OnPlusLabelTapped(object sender, System.EventArgs e)
        {
            Label control = (Label)sender;
            PickOrderDetails pick = control.BindingContext as PickOrderDetails;
            if (pick.Quantity < pick.TotalQuantity)
            {
                pick.Quantity += 1;
                pick.Total += pick.PriceUnit;
            }
        }
    }
}