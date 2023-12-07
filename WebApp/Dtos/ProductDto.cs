using System.ComponentModel.DataAnnotations;

namespace WebApp.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public string IdType { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string PhanKhuc { get; set; }
        public string Version { get; set; }
    }
}
