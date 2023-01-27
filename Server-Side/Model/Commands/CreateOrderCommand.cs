using static Server_Side.Model.Order;
using System.ComponentModel.DataAnnotations;

namespace Server_Side.Model.Commands
{
    public class CreateOrderCommand
    {

        [Required]
        public string CreatedByUsername { get; set; }
        [Required]
        public OrderType Type { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
