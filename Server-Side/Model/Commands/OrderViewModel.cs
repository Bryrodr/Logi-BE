using static Server_Side.Model.Order;

namespace Server_Side.Model.Commands
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public  OrderType  Type { get; set; }
    }
}
