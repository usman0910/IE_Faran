using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models
{
    public class StockIn
    {
        public int Id { get; set; }

        public Products Products { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public long TotalCost { get; set; }

        public float UnitCost { get; set; }


    }
}