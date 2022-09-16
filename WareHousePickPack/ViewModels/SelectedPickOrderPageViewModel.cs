using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WareHousePickPack.ViewModels
{
    public class SelectedPickOrderPageViewModel : BaseViewModel
    {
		#region Constructor.
		public SelectedPickOrderPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion

		#region Pick Order Command.
		private ICommand pickOrderCommand;
		public ICommand PickOrderCommand
		{
			get => pickOrderCommand ?? (pickOrderCommand = new Command(async () => await ExecutePickOrderCommand()));
		}
		private async Task ExecutePickOrderCommand()
		{
			Helper.Helper.PickOrPackOrderItems.FirstOrDefault(x => x.Number == SelectedPickOrderDetailInfo.Number).IsPicked = true;
			await Navigation.PopToRootAsync();
		}
		#endregion

		#region Properties.
		private ObservableCollection<Models.Order> pickOrderDetailInfo;
		public ObservableCollection<Models.Order> PickOrderDetailInfo
		{
			get => pickOrderDetailInfo;
			set
			{
				pickOrderDetailInfo = value;
				OnPropertyChanged("PickOrderDetailInfo");
			}
		}

		private Models.Order selectedPickOrderDetailInfo;
		public Models.Order SelectedPickOrderDetailInfo
		{
			get => selectedPickOrderDetailInfo;
			set
			{
				selectedPickOrderDetailInfo = value;
				OnPropertyChanged("SelectedPickOrderDetailInfo");
			}
		}
		#endregion
	}
}