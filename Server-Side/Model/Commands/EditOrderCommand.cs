using static Server_Side.Model.Order;

namespace Server_Side.Model.Commands
{
    public class EditOrderCommand
    {
        public Guid OrderId { get; set; }
        public OrderType Type { get; set; }
        public string CustomerName { get; set; }
    }
}
