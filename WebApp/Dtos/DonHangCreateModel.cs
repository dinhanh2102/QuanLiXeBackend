using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApp.Dtos;

namespace WebApp.Entities.Dtos
{
    public class DonHangCreateModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int SoLuong { get; set; }
    }
}
