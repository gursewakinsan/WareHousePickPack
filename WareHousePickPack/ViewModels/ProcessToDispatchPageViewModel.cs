using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using WareHousePickPack.Helper;
using System.Collections.Generic;

namespace WareHousePickPack.ViewModels
{
    public class ProcessToDispatchPageViewModel : BaseViewModel
	{
		#region Constructor.
		public ProcessToDispatchPageViewModel(INavigation navigation)
		{
			Navigation = navigation;
			ProcessToDispatchList = new List<int>();
            for (int i = 0; i < 3; i++)
				ProcessToDispatchList.Add(i);
		}
		#endregion

		#region Properties.
		private List<int> processToDispatchList;
		public List<int> ProcessToDispatchList
		{
			get => processToDispatchList;
			set
			{
				processToDispatchList = value;
				OnPropertyChanged("ProcessToDispatchList");
			}
		}
		#endregion
	}
}
