using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcessToDispatchPage : ContentPage
    {
        #region Variables.
        ProcessToDispatchPageViewModel viewModel;
        #endregion

        #region Constructor.
        public ProcessToDispatchPage(Models.Order selectedOrderForDispatch)
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new ProcessToDispatchPageViewModel(this.Navigation);
            viewModel.SelectedOrderForDispatch = selectedOrderForDispatch;
            viewModel.ProcessToDispatchList = new System.Collections.ObjectModel.ObservableCollection<Models.Product>(selectedOrderForDispatch.Products);
            btnProcessToDispatch.IsEnabled = false;
        }
        #endregion

        private void OnFrameQualityCheckTapped(object sender, System.EventArgs e)
        {
            Frame control = sender as Frame;
            QualityCheckTapped(control.BindingContext as Models.Product);
        }

        private void OnLabelQualityCheckTapped(object sender, System.EventArgs e)
        {
            Label control = sender as Label;
            QualityCheckTapped(control.BindingContext as Models.Product);
        }

        void QualityCheckTapped(Models.Product product)
        {
            product.IsQualityCheck = !product.IsQualityCheck;
            Models.Product result = viewModel.ProcessToDispatchList.FirstOrDefault(x => x.IsQualityCheck == false);
            if (result != null)
                btnProcessToDispatch.IsEnabled = false;
            else
                btnProcessToDispatch.IsEnabled = true;
        }
    }
}