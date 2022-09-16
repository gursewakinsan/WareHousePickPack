using System.Collections.Generic;
using WareHousePickPack.Interfaces;

namespace WareHousePickPack.Service
{
    public class WarehouseService : IWarehouseService
    {
        public List<Models.Warehouse> GetAllWarehouse()
        {
            List<Models.Warehouse> warehouses = new List<Models.Warehouse>();
            warehouses.Add(new Models.Warehouse()
            {
                Id = 1,
                Name= "Warehouse 1",
                Address = "3620 des Grandes Tourelles Avenue, US"
            });

            warehouses.Add(new Models.Warehouse()
            {
                Id = 2,
                Name = "Warehouse 2",
                Address = "2390 Orchard Street Minneapolis, Canada"
            });

            return warehouses;
        }
    }
}
