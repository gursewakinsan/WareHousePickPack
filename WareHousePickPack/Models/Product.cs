using Xamarin.Forms;

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

		private bool isQualityCheck = false;
		public bool IsQualityCheck
		{
			get => isQualityCheck;
			set
			{
				isQualityCheck = value;
				if (value)
					QualityCheckBg = Color.FromHex("#20A5E1");
				else
					QualityCheckBg = Color.FromHex("#D2D2D2");
				//OnPropertyChanged("IsQualityCheck");
			}
		}


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

		private Color qualityCheckBg;
		public Color QualityCheckBg
		{
			get => qualityCheckBg;
			set
			{
				qualityCheckBg = value;
				OnPropertyChanged("QualityCheckBg");
			}
		}
		public string DisplayGrandTotal => $"$ {TotalQuantity * PriceUnit}";
	}
}
