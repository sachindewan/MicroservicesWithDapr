using OrdersApi.Models;
using System;
using System.Threading.Tasks;

namespace OrdersApi.Persistence
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync(Guid id);
        public Task RegisterOrder(Order order);
    }
}
