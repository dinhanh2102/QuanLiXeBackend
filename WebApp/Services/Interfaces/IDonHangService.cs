using WebApp.Dtos;
using WebApp.Entities.Dtos;

namespace WebApp.Services.Interfaces
{
    public interface IDonHangService
    {
        string CreateDonHang(DonHangCreateModel donHangDto);
    }
}
