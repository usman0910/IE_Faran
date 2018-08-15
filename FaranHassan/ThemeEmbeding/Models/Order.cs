using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThemeEmbeding.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public string CartDetails { get; set; }
        public OrderStatus OrderStatus { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }

        public DateTime Date { get; set; }
    }
}