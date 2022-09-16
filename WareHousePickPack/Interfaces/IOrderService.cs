using System.Collections.Generic;

namespace WareHousePickPack.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Get All Pick Orders
        /// </summary>
        /// <returns></returns>
        List<Models.Order> GetAllOrderItems();
    }
}
