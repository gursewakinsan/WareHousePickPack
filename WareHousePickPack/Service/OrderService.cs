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
                Name = "iphone 14 pro",
                Image = "https://www.apple.com/in/iphone-14-pro/images/overview/colors/gallery_deep_purple__eog5f5067tw2_large.jpg",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 1,
                TotalQuantity = 10,
                PriceUnit = 500
            });

            orders.Add(new Models.Order()
            {
                Number = 100002,
                Name = "iphone 13 pro",
                Image = "https://i.pngimg.me/thumb/f/720/cf080317b43245b4ada7.jpg",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 2,
                TotalQuantity = 10,
                PriceUnit = 500
            });

            orders.Add(new Models.Order()
            {
                Number = 100003,
                Name = "Dell laptop xps 450",
                Image = "https://www.pngkey.com/png/full/262-2626769_laptops-dell-laptop-price-2018.png",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 1,
                TotalQuantity = 5,
                PriceUnit = 200
            });

            orders.Add(new Models.Order()
            {
                Number = 100004,
                Name = "ASUS vivo book 15 inch xda512",
                Image = "https://www.pngitem.com/pimgs/m/45-451027_transparent-asus-laptop-png-asus-vivobook-s15-2018.png",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 2,
                TotalQuantity = 5,
                PriceUnit = 200
            });

            orders.Add(new Models.Order()
            {
                Number = 100005,
                Name = "Nike shoes",
                Image = "https://png.pngitem.com/pimgs/s/555-5550642_nike-shoe-png-transparent-png.png",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 1,
                TotalQuantity = 2,
                PriceUnit = 900
            });

            orders.Add(new Models.Order()
            {
                Number = 100006,
                Name = "Adidas shoes",
                Image = "https://www.transparentpng.com/thumb/adidas-shoes/a4xO3G-adidas-shoes-adidas-shoe-kids-superstar-daddy-grade.png",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 2,
                TotalQuantity = 3,
                PriceUnit = 1200
            });

            orders.Add(new Models.Order()
            {
                Number = 100007,
                Name = "Dollar Shave Club’s",
                Image = "https://upload.wikimedia.org/wikipedia/commons/7/76/Dollar_Shave_Club_logo_%282020%29.png?20210724181704",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 1,
                TotalQuantity = 2,
                PriceUnit = 121
            });

            orders.Add(new Models.Order()
            {
                Number = 100008,
                Name = "GoPro’s Product",
                Image = "https://w7.pngwing.com/pngs/874/504/png-transparent-gopro-hero5-black-gopro-hero6-action-camera-4k-resolution-gopro-electronics-camera-lens-video-camera-thumbnail.png",
                Date = DateTime.Today.ToString("MM/dd/yy"),
                IsPicked = false,
                WarehouseId = 2,
                TotalQuantity = 3,
                PriceUnit = 110
            });

            return orders;
        }
    }
}
