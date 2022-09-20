using System;
using System.Collections.Generic;
using WareHousePickPack.Interfaces;

namespace WareHousePickPack.Service
{
    public class OrderService : IOrderService
    {
        /// <summary>
        /// Get All Pick Orders
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetAllOrderItems()
        {
            List<Models.Order> orders = new List<Models.Order>();
            orders.Add(new Models.Order()
            {
                Number = 100001,
                NoOfUniqueProductTypes = 2,
                WarehouseId = 1,
                IsPicked = false,
                Date = DateTime.Today.ToString("MM/dd/yy"),
                TotalQuantity = 3,
                Products = new List<Models.Product>()
                 {
                    new Models.Product()
                    {
                        Id=1,
                        Name = "iphone 14 pro",
                        Image = "https://www.apple.com/in/iphone-14-pro/images/overview/colors/gallery_deep_purple__eog5f5067tw2_large.jpg",
                        TotalQuantity = 2,
                        PriceUnit = 1500,
                        BinNumber = 3021486,
                        ProductDescription="ABX2012"
                    },
                    new Models.Product()
                    {
                        Id=2,
                        Name = "iphone 12 pro",
                        Image = "https://www.apple.com/in/iphone-14-pro/images/overview/colors/gallery_deep_purple__eog5f5067tw2_large.jpg",
                        TotalQuantity = 1,
                        PriceUnit = 1100,
                        BinNumber = 142578,
                        ProductDescription="BSH458"
                    }
                 }
            });

            orders.Add(new Models.Order()
            {
                Number = 100002,
                NoOfUniqueProductTypes = 2,
                WarehouseId = 1,
                IsPicked = false,
                TotalQuantity =2,
                Date = DateTime.Today.ToString("MM/dd/yy"),
                Products = new List<Models.Product>()
                 {
                    new Models.Product()
                    {
                        Id = 1,
                        Name = "iphone 6s Gold",
                        Image = "https://www.apple.com/in/iphone-14-pro/images/overview/colors/gallery_deep_purple__eog5f5067tw2_large.jpg",
                        TotalQuantity = 1,
                        PriceUnit = 500,
                        BinNumber = 632445,
                        ProductDescription="OUJWL854"
                    },
                    new Models.Product()
                    {
                        Id=2,
                        Name = "iphone 8 plus",
                        Image = "https://www.apple.com/in/iphone-14-pro/images/overview/colors/gallery_deep_purple__eog5f5067tw2_large.jpg",
                        TotalQuantity = 1,
                        PriceUnit = 800,
                        BinNumber = 965123,
                        ProductDescription="PJH9822"
                    }
                 }
            });

            orders.Add(new Models.Order()
            {
                Number = 100003,
                NoOfUniqueProductTypes = 2,
                WarehouseId = 2,
                IsPicked = false,
                TotalQuantity =2,
                Date = DateTime.Today.ToString("MM/dd/yy"),
                Products = new List<Models.Product>()
                 {
                    new Models.Product()
                    {
                        Id=1,
                        Name = "Dell laptop xps 450",
                        Image = "https://www.pngkey.com/png/full/262-2626769_laptops-dell-laptop-price-2018.png",
                        TotalQuantity = 1,
                        PriceUnit = 2500,
                        BinNumber = 023366,
                        ProductDescription="NHGT6325"
                    },
                    new Models.Product()
                    {
                        Id=2,
                        Name = "ASUS vivo book 15 inch xda512",
                        Image = "https://www.pngitem.com/pimgs/m/45-451027_transparent-asus-laptop-png-asus-vivobook-s15-2018.png",
                        TotalQuantity = 1,
                        PriceUnit = 2800,
                        BinNumber = 125546,
                        ProductDescription="QAY5201"
                    }
                 }
            });

            orders.Add(new Models.Order()
            {
                Number = 100004,
                NoOfUniqueProductTypes = 1,
                WarehouseId = 2,
                IsPicked = false,
                TotalQuantity =1,
                Date = DateTime.Today.ToString("MM/dd/yy"),
                Products = new List<Models.Product>()
                 {
                    new Models.Product()
                    {
                        Id=1,
                        Name = "Nike shoes",
                        Image = "https://png.pngitem.com/pimgs/s/555-5550642_nike-shoe-png-transparent-png.png",
                        TotalQuantity = 1,
                        PriceUnit = 7200,
                        BinNumber = 12121,
                        ProductDescription="FDSF7530"
                    }
                 }
            });
            return orders;
        }
    }
}
