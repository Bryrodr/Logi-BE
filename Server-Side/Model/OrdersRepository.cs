using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Server_Side.Interface;
using Server_Side.Model.Commands;

namespace Server_Side.Model
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly OrderDbContext _dbContext;
        private readonly IMapper _mapper;
        public OrdersRepository(OrderDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
         public async  Task<List<Order>> GetOrdersAsync()
        {
                return await _dbContext.Orders.ToListAsync();
        }
        
        public async Task<Order> GetOrderAsync(Guid orderId)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);   
        }
       
        public async  Task<Order> AddOrderAsync(CreateOrderCommand command)
        {
            var order = new Order();
            _mapper.Map(command, order);
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }
       

        public async Task<Order> UpdateOrderAsync(OrderViewModel command)
        {   
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == command.OrderId);
            if (order == null)
            {
                return null;
            }
            _mapper.Map(command, order);
            _dbContext.Orders.Update(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<Order> DeleteOrderAsync(Guid orderId)
        {      
                var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);
                _dbContext.Orders.Remove(order);
                await _dbContext.SaveChangesAsync();
                return order; 
        }
        
    }
       
}
