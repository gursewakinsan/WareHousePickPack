using Xamarin.Forms;
using WareHousePickPack.Interfaces;

namespace WareHousePickPack
{
    public partial class App : Application
    {
        SQLite.SQLiteConnection conn;
        public App()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            var tableInfo = conn.GetTableInfo("PickPack");
            if (tableInfo.Count == 0)
            {
                conn.CreateTable<Models.PickPack>();
                DependencyService.Get<ISQLite>().FillMockData();
            }
            MainPage = new NavigationPage(new Views.DashboardPage());
        }
    }
}
