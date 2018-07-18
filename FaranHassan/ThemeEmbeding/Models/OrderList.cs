using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models
{
    public class OrderList
    {
        public int Id { get; set; }
        
        public virtual List<Products> Products { get; set; }
        [ForeignKey("Products")]
        public List<int> ProductIDs { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public int TotalPrice { get; set; }

        public OrderStatus OrderStatus { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }


    }
}