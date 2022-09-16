using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using WareHousePickPack.Service;
using System.Collections.Generic;
using WareHousePickPack.Interfaces;
using System.Collections.ObjectModel;

namespace WareHousePickPack.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
		#region Constructor.
		public DashboardPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
			IsPicked = true;
		}
		#endregion

		#region Get All Warehouse Command.
		private ICommand getAllWarehouseCommand;
		public ICommand GetAllWarehouseCommand
		{
			get => getAllWarehouseCommand ?? (getAllWarehouseCommand = new Command(() => ExecuteGetAllWarehouseCommand()));
		}
		private void ExecuteGetAllWarehouseCommand()
		{
			IOrderService orderService = new OrderService();
			Helper.Helper.PickOrPackOrderItems = orderService.GetAllOrderItems();

			IWarehouseService warehouseService = new WarehouseService();
			WarehouseList = warehouseService.GetAllWarehouse();
			SelectedWarehouse = WarehouseList[0];
		}
		#endregion

		#region Get Pick Order Items Command.
		private ICommand getPickOrderItemsCommand;
		public ICommand GetPickOrderItemsCommand
		{
			get => getPickOrderItemsCommand ?? (getPickOrderItemsCommand = new Command( () =>  ExecuteGetPickOrderItemsCommand()));
		}
		private void ExecuteGetPickOrderItemsCommand()
		{
			IsEmptyListMessage = false;
			IsPicked = true;
			PickedTabColor = Color.Black;
			PackedTabColor = Color.FromHex("#B5B5B5");
			var pickOrderItems = Helper.Helper.PickOrPackOrderItems.Where(x => x.IsPicked == false && x.WarehouseId == SelectedWarehouse.Id).ToList();
			PickOrderItems = new ObservableCollection<Models.Order>(pickOrderItems);
			if (PickOrderItems.Count == 0)
			{
				IsEmptyListMessage = true;
				EmptyListMessage = $"No item found for pick.{System.Environment.NewLine}Please click here to reload the data.";
			}
		}
		#endregion

		#region Get Pack Order Items Command.
		private ICommand getPackOrderItemsCommand;
		public ICommand GetPackOrderItemsCommand
		{
			get => getPackOrderItemsCommand ?? (getPackOrderItemsCommand = new Command(async () => await ExecuteGetPackOrderItemsCommand()));
		}
		private async Task ExecuteGetPackOrderItemsCommand()
		{
			IsEmptyListMessage = false;
			IsPicked = false;
			PickedTabColor = Color.FromHex("#B5B5B5");
			PackedTabColor = Color.Black;
			var packOrderItems = Helper.Helper.PickOrPackOrderItems.Where(x => x.IsPicked == true && x.IsPacked == false && x.WarehouseId == SelectedWarehouse.Id).ToList();
			PackOrderItems = new ObservableCollection<Models.Order>(packOrderItems);
			if (PackOrderItems.Count == 0)
			{
				IsEmptyListMessage = true;
				EmptyListMessage = "No item found for pack.";
			}
			await Task.CompletedTask;
		}
		#endregion

		#region Selected Tab Command.
		private ICommand selectedTabCommand;
		public ICommand SelectedTabCommand
		{
			get => selectedTabCommand ?? (selectedTabCommand = new Command<string>((selectedTab) => ExecuteSelectedTabCommand(selectedTab)));
		}
		private void ExecuteSelectedTabCommand(string selectedTab)
		{
            switch (selectedTab)
            {
				case "Pick":
					GetPickOrderItemsCommand.Execute(null);
					break;
				case "Pack":
					GetPackOrderItemsCommand.Execute(null);
					break;
			}
        }
		#endregion

		#region Reload Data Command.
		private ICommand reloadDataCommand;
		public ICommand ReloadDataCommand
		{
			get => reloadDataCommand ?? (reloadDataCommand = new Command(() => ExecuteReloadDataCommand()));
		}
		private void ExecuteReloadDataCommand()
		{
			IOrderService orderService = new OrderService();
			Helper.Helper.PickOrPackOrderItems = orderService.GetAllOrderItems();
			GetPickOrderItemsCommand.Execute(null);
		}
		#endregion

		#region Properties.
		private List<Models.Warehouse> warehouseList;
		public List<Models.Warehouse> WarehouseList
		{
			get => warehouseList;
			set
			{
				warehouseList = value;
				OnPropertyChanged("WarehouseList");
			}
		}

		private Models.Warehouse selectedWarehouse;
		public Models.Warehouse SelectedWarehouse
		{
			get => selectedWarehouse;
			set
			{
				selectedWarehouse = value;
				OnPropertyChanged("SelectedWarehouse");
			}
		}

		private ObservableCollection<Models.Order> pickOrderItems;
		public ObservableCollection<Models.Order> PickOrderItems
		{
			get => pickOrderItems;
			set
			{
				pickOrderItems = value;
				OnPropertyChanged("PickOrderItems");
			}
		}

		private ObservableCollection<Models.Order> packOrderItems;
		public ObservableCollection<Models.Order> PackOrderItems
		{
			get => packOrderItems;
			set
			{
				packOrderItems = value;
				OnPropertyChanged("PackOrderItems");
			}
		}

		private bool isPicked;
		public bool IsPicked
		{
			get => isPicked;
			set
			{
				isPicked = value;
				OnPropertyChanged("IsPicked");
			}
		}

		private Color pickedTabColor;
		public Color PickedTabColor
		{
			get => pickedTabColor;
			set
			{
				pickedTabColor = value;
				OnPropertyChanged("PickedTabColor");
			}
		}

		private Color packedTabColor;
		public Color PackedTabColor
		{
			get => packedTabColor;
			set
			{
				packedTabColor = value;
				OnPropertyChanged("PackedTabColor");
			}
		}

		private bool isEmptyListMessage =false;
		public bool IsEmptyListMessage
		{
			get => isEmptyListMessage;
			set
			{
				isEmptyListMessage = value;
				OnPropertyChanged("IsEmptyListMessage");
			}
		}

		private string emptyListMessage;
		public string EmptyListMessage
		{
			get => emptyListMessage;
			set
			{
				emptyListMessage = value;
				OnPropertyChanged("EmptyListMessage");
			}
		}
		#endregion
	}
}



