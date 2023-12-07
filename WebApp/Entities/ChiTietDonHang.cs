using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{
    public class ChiTietDonHang
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public int IdDonHang { get; set; }
        public string TenSanPham { get; set; }
        [Required]
        public string SoLuong { get; set; }
        [Required]
        public string TenKhachHang { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]

        public DateTime ThoiGian { get; set; }
    }
}
