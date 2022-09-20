namespace WareHousePickPack.Models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public string Image { get; set; }
		public int TotalQuantity { get; set; }
		public int PriceUnit { get; set; }
        public int BinNumber { get; set; }
        public string ProductDescription { get; set; }

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
