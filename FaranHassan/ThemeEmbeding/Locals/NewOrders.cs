using System;
using System.Collections.Generic;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.Locals
{
    public class NewOrders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public List<Products> Products { get; set; }

        public DateTime Date { get; set; }

        public int OrderStatusId { get; set; }
    }
}