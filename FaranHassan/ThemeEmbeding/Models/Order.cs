using System.ComponentModel.DataAnnotations.Schema;

namespace ThemeEmbeding.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Cart Cart { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
    }
}