using WebApp.Dtos;
using WebApp.Models;

namespace WebApp.Services.Interfaces
{
    public interface IProductService
    {
        void CreateProduct(CreateProductDto input);
        void DeleteProduct(int productId);
        List<ProductDto> GetAll(SearchModel searchModel);
        ProductDto GetById(string id);
        List<ProductDto> GetToyota(string nameCar);
        void UpdateProduct(UpdateProductDto input);
    }
}
