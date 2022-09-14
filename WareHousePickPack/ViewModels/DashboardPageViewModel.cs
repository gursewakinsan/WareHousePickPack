using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using WareHousePickPack.Helper;
using System.Collections.Generic;
using WareHousePickPack.Interfaces;

namespace WareHousePickPack.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
		#region Constructor.
		public DashboardPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion

		#region Get Picked Data Command.
		private ICommand getPickedDataCommand;
		public ICommand GetPickedDataCommand
		{
			get => getPickedDataCommand ?? (getPickedDataCommand = new Command(async () => await ExecuteGetPickedDataCommand()));
		}
		private async Task ExecuteGetPickedDataCommand()
		{
			IsEmptyListMessage = false;
			IsPicked = true;
			PickedTabColor = Color.Black;
			PackedTabColor = Color.FromHex("#B5B5B5");
			var pickItems = DependencyService.Get<ISQLite>().GetAll();
			PickItems = pickItems.Where(x=>x.IsPick ==false).ToList();
			if (PickItems.Count == 0)
			{
				IsEmptyListMessage = true;
				EmptyListMessage = "No item found for pick.";
			}
			await Task.CompletedTask;
		}
		#endregion

		#region Get Packed Data Command.
		private ICommand getPackedDataCommand;
		public ICommand GetPackedDataCommand
		{
			get => getPackedDataCommand ?? (getPackedDataCommand = new Command(async () => await ExecuteGetPackedDataCommand()));
		}
		private async Task ExecuteGetPackedDataCommand()
		{
			IsEmptyListMessage = false;
			IsPicked = false;
			PickedTabColor = Color.FromHex("#B5B5B5");
			PackedTabColor = Color.Black;
			var packItems = DependencyService.Get<ISQLite>().GetAll();
			PackItems = packItems.Where(x => x.IsPick == true).ToList();
			if (PackItems.Count == 0)
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
					GetPickedDataCommand.Execute(null);
					break;
				case "Pack":
					GetPackedDataCommand.Execute(null);
					break;
			}
        }
		#endregion

		#region Properties.
		private List<Models.PickPack> pickItems;
		public List<Models.PickPack> PickItems
		{
			get => pickItems;
			set
			{
				pickItems = value;
				OnPropertyChanged("PickItems");
			}
		}

		private List<Models.PickPack> packItems;
		public List<Models.PickPack> PackItems
		{
			get => packItems;
			set
			{
				packItems = value;
				OnPropertyChanged("PackItems");
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



