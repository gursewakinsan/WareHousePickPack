using SQLite;
using System.IO;
using Xamarin.Forms;
using WareHousePickPack.Interfaces;
using System.Collections.Generic;
using WareHousePickPack.Models;

[assembly: Dependency(typeof(WareHousePickPack.Droid.Services.SQLiteAndroid))]
namespace WareHousePickPack.Droid.Services
{
    public class SQLiteAndroid : ISQLite
    {
        SQLiteConnection connection;
        public SQLiteConnection GetConnection()
        {
            connection = new SQLiteConnection(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "mydatabase.sqlite"));
            return connection;
        }

        public List<PickPack> GetAll()
        {
            string query = "SELECT * FROM PickPack";
            List<PickPack> list = connection.Query<PickPack>(query);
            return list;
        }

        public bool Insert(PickPack model)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(PickPack model)
        {
            string query = $"UPDATE PickPack SET ....";
            connection.Execute(query);
            return true;
        }

        public void FillMockData()
        {
            PickPack pickPack1 = new PickPack()
            {
                BinNumber = "3612871",
                Date = "01/09/22",
                IsPick=false,
                PricePerUnit=35,
                ProductTypes = "Product Types 1",
                TotelQuantity =10,
            };
            connection.Insert(pickPack1);

            PickPack pickPack2 = new PickPack()
            {
                BinNumber = "3612872",
                Date = "02/09/22",
                IsPick = false,
                PricePerUnit = 35,
                ProductTypes = "Product Types 2",
                TotelQuantity = 10,
            };
            connection.Insert(pickPack2);

            PickPack pickPack3 = new PickPack()
            {
                BinNumber = "3612873",
                Date = "03/09/22",
                IsPick = false,
                PricePerUnit = 35,
                ProductTypes = "Product Types 3",
                TotelQuantity = 10,
            };
            connection.Insert(pickPack3);

            PickPack pickPack4 = new PickPack()
            {
                BinNumber = "3612874",
                Date = "04/09/22",
                IsPick = false,
                PricePerUnit = 35,
                ProductTypes = "Product Types 4",
                TotelQuantity = 10,
            };
            connection.Insert(pickPack4);

            PickPack pickPack5 = new PickPack()
            {
                BinNumber = "3612875",
                Date = "05/09/22",
                IsPick = false,
                PricePerUnit = 35,
                ProductTypes = "Product Types 5",
                TotelQuantity = 10,
            };
            connection.Insert(pickPack5);
        }
    }
}