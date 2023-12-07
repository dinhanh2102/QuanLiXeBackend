using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class SearchModel
    {
        public string Name { get; set; }
        public string IdType { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string PhanKhuc { get; set; }
        public string Version { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public double Price { get; set; }
    }
}
