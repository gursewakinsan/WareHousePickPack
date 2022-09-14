using SQLite;

namespace WareHousePickPack.Models
{
    public class PickPack : BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int OrderNumber { get; set; }
        public string ProductTypes { get; set; }
        public string Date { get; set; }
        
        public int TotelQuantity { get; set; }
        public string BinNumber { get; set; }
        public int PricePerUnit { get; set; }
        public int PickQuantity { get; set; }
        public int PackQuantity { get; set; }
        public bool IsPick { get; set; }

        private int pickedQuantity;
        public int PickedQuantity
        {
            get => pickedQuantity;
            set
            {
                pickedQuantity = value;
                OnPropertyChanged("PickedQuantity");
            }
        }

        private int total;
        public int Total
        {
            get => total;
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }
    }
}