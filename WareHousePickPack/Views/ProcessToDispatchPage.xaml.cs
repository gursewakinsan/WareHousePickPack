using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WareHousePickPack.ViewModels;

namespace WareHousePickPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcessToDispatchPage : ContentPage
    {
        ProcessToDispatchPageViewModel viewModel;
        public ProcessToDispatchPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new ProcessToDispatchPageViewModel(this.Navigation);
        }
    }
}