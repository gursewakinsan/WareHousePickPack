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
		}
		#endregion
	}
}
