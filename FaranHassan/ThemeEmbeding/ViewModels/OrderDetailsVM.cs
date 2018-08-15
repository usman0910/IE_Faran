using System.Collections.Generic;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.ViewModels
{
    public class OrderDetailsVM
    {
        public List<Products> Products { get; set; }
        public Customer Customer { get; set; }
    }
}