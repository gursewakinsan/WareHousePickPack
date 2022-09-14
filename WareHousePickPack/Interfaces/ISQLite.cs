using System.Collections.Generic;

namespace WareHousePickPack.Interfaces
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
        bool Insert(Models.PickPack model);
        bool Update(Models.PickPack model);
        List<Models.PickPack> GetAll();
        void FillMockData();
    }
}
