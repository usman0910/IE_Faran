using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Categories { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }

        public string Brand { get; set; }

        public float Weight { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public string Description { get; set; }

        public float Height { get; set; }

        public long TotalQuantity { get; set; }

    }
}