namespace WareHousePickPack.Models
{
    public class Order : BaseModel
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public bool IsPicked { get; set; }
		public bool IsPacked { get; set; }
		public int WarehouseId { get; set; }
		public int TotalQuantity { get; set; }
		public int PriceUnit { get; set; }

		private int quantity;
		public int Quantity
		{
			get => quantity;
			set
			{
				quantity = value;
				OnPropertyChanged("Quantity");
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

		public string DisplayGrandTotal => $"$ {TotalQuantity * PriceUnit}";
	}
}
