using Server_Side.Model;
using Server_Side.Model.Commands;

namespace Server_Side.Interface
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetOrdersAsync();
        
        Task<Order> GetOrderAsync(Guid orderId);
        Task<Order> AddOrderAsync(CreateOrderCommand command);
        Task<Order> UpdateOrderAsync(OrderViewModel command);
        Task<Order> DeleteOrderAsync(Guid orderId);
        
    }
}
