using System.ComponentModel.DataAnnotations.Schema;

namespace ThemeEmbeding.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Categories { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }

        public Brands Brands { get; set; }
        [ForeignKey("Brands")]
        public int BrandId { get; set; }

        public float Weight { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public string Description { get; set; }

        public string OverView { get; set; }

        public string AdditionalInfo { get; set; }

        public string VideoLink { get; set; }

        public long Price { get; set; }

        public string Image { get; set; }

        public float Height { get; set; }
        public long TotalQuantity { get; set; }


    }
}