using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double MinPrice { get; set; }
        [Required]
        public double MaxPrice { get; set; }
        [Required]
        public string IdType { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string PhanKhuc { get; set; }
        [Required]
        public string Version { get; set; }


    }
}
