using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using WareHousePickPack.Helper;
using System.Collections.Generic;

namespace WareHousePickPack.ViewModels
{
    public class SelectedPickOrderPageViewModel : BaseViewModel
    {
		#region Constructor.
		public SelectedPickOrderPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
			PickOrderDetailInfo = new List<PickOrderDetails>();
			for (int i = 1; i < 5; i++)
				PickOrderDetailInfo.Add(new PickOrderDetails()
				{
					Id = i,
					BinNumber = $"361287{i}",
					TotalQuantity = 12,
					PriceUnit = 35
				});
		}
		#endregion

		#region Properties.
		private List<PickOrderDetails> pickOrderDetailInfo;
		public List<PickOrderDetails> PickOrderDetailInfo
		{
			get => pickOrderDetailInfo;
			set
			{
				pickOrderDetailInfo = value;
				OnPropertyChanged("PickOrderDetailInfo");
			}
		}
		#endregion
	}
}

public class PickOrderDetails : WareHousePickPack.Models.BaseModel
{
    public int Id { get; set; }
    public string BinNumber { get; set; }

	private int quantity;
	public int Quantity
	{
		get => quantity;
		set
		{
			quantity = value;
			OnPropertyChanged("Quantity");
		}
	}

	public int TotalQuantity { get; set; }
    public int PriceUnit { get; set; }
	
	private int total;
	public int Total
	{
		get => total;
		set
		{
			total = value;
			OnPropertyChanged("Total");
		}
	}
}
