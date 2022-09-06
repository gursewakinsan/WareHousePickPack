using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using WareHousePickPack.Helper;
using System.Collections.Generic;

namespace WareHousePickPack.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
		#region Constructor.
		public DashboardPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
			GetPickedDataCommand.Execute(null);
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
			IsPicked = true;
			PickedTabColor = Color.Black;
			PackedTabColor = Color.FromHex("#B5B5B5");
			var pickList = new List<Picked>();
			for (int i = 0; i < 10; i++)
				pickList.Add(new Picked() { Id = $"98652415{i}" });
			PickedList = pickList;
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
			IsPicked = false;
			PickedTabColor = Color.FromHex("#B5B5B5");
			PackedTabColor = Color.Black;
			var packedList = new List<Packed>();
			for (int i = 0; i < 10; i++)
				packedList.Add(new Packed() { Id = $"98652412{i}" });
			PackedList = packedList;
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
		private List<Picked> pickedList;
		public List<Picked> PickedList
		{
			get => pickedList;
			set
			{
				pickedList = value;
				OnPropertyChanged("PickedList");
			}
		}

		private List<Packed> packedList;
		public List<Packed> PackedList
		{
			get => packedList;
			set
			{
				packedList = value;
				OnPropertyChanged("PackedList");
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
		#endregion
	}
}

public class Picked
{
    public string Id { get; set; }
}

public class Packed
{
	public string Id { get; set; }
}


