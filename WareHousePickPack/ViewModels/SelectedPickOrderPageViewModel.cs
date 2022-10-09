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
		private ObservableCollection<Models.Product> pickOrderDetailInfo;
		public ObservableCollection<Models.Product> PickOrderDetailInfo
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

		private int totalPrice;
		public int TotalPrice
		{
			get => totalPrice;
			set
			{
				totalPrice = value;
				OnPropertyChanged("TotalPrice");
				DisplayTotalPrice = value.ToString("N2");
			}
		}

		private string displayTotalPrice = "0.00";
		public string DisplayTotalPrice
		{
			get => displayTotalPrice;
			set
			{
				displayTotalPrice = value;
				OnPropertyChanged("DisplayTotalPrice");
			}
		}

		public int TotalQuantity { get; set; }
		#endregion
	}
}
