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
        }
        #endregion
    }
}