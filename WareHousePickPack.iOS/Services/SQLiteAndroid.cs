using SQLite;
using System.IO;
using Xamarin.Forms;
using WareHousePickPack.Interfaces;

[assembly: Dependency(typeof(WareHousePickPack.iOS.Services.SQLiteAndroid))]
namespace WareHousePickPack.iOS.Services
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "mydatabase.sqlite"));
        }
    }
}