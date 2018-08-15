using System.ComponentModel.DataAnnotations.Schema;

namespace ThemeEmbeding.Models
{
    public class Brands
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Categories Categories { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
    }
}