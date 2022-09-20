using System.Collections.Generic;

namespace WareHousePickPack.Models
{
    public class Order : BaseModel
    {
        public int Number { get; set; }
        public int NoOfUniqueProductTypes { get; set; }
        public string Date { get; set; }
        public int WarehouseId { get; set; }
        public bool IsPicked { get; set; }
        public bool IsPacked { get; set; }
        public List<Product> Products { get; set; }
        public int TotalQuantity { get; set; }
    }
}
