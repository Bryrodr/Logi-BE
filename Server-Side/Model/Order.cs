using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_Side.Model
{
    public class Order
    {
        
        public Order()
        {

        }

        public enum OrderType
        {
            Standard,
            SaleOrder,
            PurchaseOrder,
            TransferOrder,
            ReturnOrder
        }
        
        [Key]
        public Guid OrderId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Username")]
        public String CreatedByUsername { get; set; }
        public virtual User User { get; set; }
        [Required]
        public OrderType Type { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
