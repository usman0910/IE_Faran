using System.Collections.Generic;
using ThemeEmbeding.Models;

namespace ThemeEmbeding.ViewModels
{
    public class CartProductsVM
    {
        public List<Products> Products { get; set; }
        public long TotalPrice { get; set; }
    }
}