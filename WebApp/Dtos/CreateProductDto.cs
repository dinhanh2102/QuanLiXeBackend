using System.ComponentModel.DataAnnotations;

namespace WebApp.Dtos
{
    public class CreateProductDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên sản phẩm không được bỏ trống")]
        [MaxLength(255, ErrorMessage = "tên sản phẩm không được quá 255 ký tự")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "không được để trống")]
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
