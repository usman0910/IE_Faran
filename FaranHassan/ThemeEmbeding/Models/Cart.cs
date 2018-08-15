using System.Collections.Generic;

namespace ThemeEmbeding.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public List<int> ProductsIds { get; set; }

        public int TotalPrice { get; set; }


    }
}