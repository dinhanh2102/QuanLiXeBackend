using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApp.Dtos;

namespace WebApp.Entities
{
    public class DonHang
    {
        [Key]
        public string Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public int SoLuong { get; set; }
    }
}
