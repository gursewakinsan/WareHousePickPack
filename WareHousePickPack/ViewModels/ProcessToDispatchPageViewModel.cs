using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WareHousePickPack.ViewModels
{
    public class ProcessToDispatchPageViewModel : BaseViewModel
	{
		#region Constructor.
		public ProcessToDispatchPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion

		#region Process To Dispatch Command.
		private ICommand processToDispatchCommand;
		public ICommand ProcessToDispatchCommand
		{
			get => processToDispatchCommand ?? (processToDispatchCommand = new Command(async () => await ExecuteProcessToDispatchCommand()));
		}
		private async Task ExecuteProcessToDispatchCommand()
		{
			Helper.Helper.PickOrPackOrderItems.FirstOrDefault(x => x.Number == SelectedOrderForDispatch.Number).IsPacked = true;
			await Navigation.PopToRootAsync();
		}
		#endregion

		#region Properties.
		private ObservableCollection<Models.Order> processToDispatchList;
		public ObservableCollection<Models.Order> ProcessToDispatchList
		{
			get => processToDispatchList;
			set
			{
				processToDispatchList = value;
				OnPropertyChanged("ProcessToDispatchList");
			}
		}

		private Models.Order selectedOrderForDispatch;
		public Models.Order SelectedOrderForDispatch
		{
			get => selectedOrderForDispatch;
			set
			{
				selectedOrderForDispatch = value;
				OnPropertyChanged("SelectedOrderForDispatch");
			}
		}
		#endregion
	}
}
