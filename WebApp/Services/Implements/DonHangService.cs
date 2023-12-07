using WebApp.DbContexts;
using WebApp.Dtos;
using WebApp.Entities;
using WebApp.Entities.Dtos;
using WebApp.Services.Interfaces;

namespace WebApp.Services.Implements
{
    public class DonHangService : IDonHangService
    {
        private readonly ApplicationDbContext _context;
        public DonHangService(ApplicationDbContext context)
        {
            _context = context;
        }
        public string CreateDonHang(DonHangCreateModel donHangDto)
        {
            try
            {
                var donHang = new DonHang
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = donHangDto.Name,
                    SoLuong = donHangDto.SoLuong,
                };
                _context.DonHangs.Add(donHang);
                _context.SaveChanges();
                return donHang.Name;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
