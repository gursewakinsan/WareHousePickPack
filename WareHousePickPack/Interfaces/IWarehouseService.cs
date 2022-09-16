using System.Collections.Generic;

namespace WareHousePickPack.Interfaces
{
    public interface IWarehouseService
    {
        List<Models.Warehouse> GetAllWarehouse();
    }
}
