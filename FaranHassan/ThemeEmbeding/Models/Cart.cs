using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThemeEmbeding.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public virtual ICollection<Products> Products { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public int TotalPrice { get; set; }


    }
}