using Microsoft.EntityFrameworkCore;
using System.Drawing;
using WebApp.DbContexts;
using WebApp.Dtos;
using WebApp.Entities;
using WebApp.Models;
using WebApp.Services.Interfaces;

namespace WebApp.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProductDto> GetAll(SearchModel searchModel)
        {
            var results = new List<ProductDto>();
            var query = (from prod in _context.Products.AsNoTracking()
                         select new ProductDto
                         {
                             Name = prod.Name,
                             Price = prod.Price,
                             Color = prod.Color,
                             IdType = prod.IdType,
                             MaxPrice = prod.MaxPrice,
                             MinPrice = prod.MinPrice,
                             PhanKhuc = prod.PhanKhuc,
                             Version = prod.Version,
                             Year = prod.Year,
                         }).AsNoTracking().AsNoTracking();
            if (!string.IsNullOrEmpty(searchModel.Name))
            {
                query = query.Where(s => s.Name.ToUpper().Contains(searchModel.Name.ToUpper()));
            }
            if (!string.IsNullOrEmpty(searchModel.Version))
            {
                query = query.Where(s => s.Version.ToUpper().Equals(searchModel.Version.ToUpper()));
            }
            if (!string.IsNullOrEmpty(searchModel.IdType))
            {
                query = query.Where(s => s.IdType.ToUpper().Equals(searchModel.IdType.ToUpper()));
            }
            if (!string.IsNullOrEmpty(searchModel.Year))
            {
                query = query.Where(s => s.Year.ToUpper().Equals(searchModel.Year.ToUpper()));
            }
            if (!string.IsNullOrEmpty(searchModel.Color))
            {
                query = query.Where(s => s.Color.ToUpper().Equals(searchModel.Color.ToUpper()));
            }
            results = query.ToList();
            return results;
        }
        public void CreateProduct(CreateProductDto input)
        {
            try
            {
                _context.Products.Add(new Product
                {
                    Name = input.Name,
                    Price = input.Price,
                    Color = input.Color,
                    IdType = input.IdType,
                    MaxPrice = input.MaxPrice,
                    MinPrice = input.MinPrice,
                    PhanKhuc = input.PhanKhuc,
                    Version = input.Version,
                    Year = input.Year,
                });
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Thêm thất bại");
            }

        }

        public void DeleteProduct(int productId)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(u => u.Id == productId);
                if (product == null)
                {
                    throw new Exception("Không tìm thấy user");
                }
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Xóa thất bại");
            }
        }
        public void UpdateProduct(UpdateProductDto input)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(u => u.Id == input.Id);
                if (product == null)
                {
                    throw new Exception("Không tìm thấy user");
                }
                product.Name = input.Name;
                product.Price = input.Price;
                product.Color = input.Color;
                product.IdType = input.IdType;
                product.MaxPrice = input.MaxPrice;
                product.MinPrice = input.MinPrice;
                product.PhanKhuc = input.PhanKhuc;
                product.Version = input.Version;
                product.Year = input.Year;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Cập nhật thất bại");
            }

        }
        public List<ProductDto> GetToyota(string nameCar)
        {
            try
            {
                var product = (from a in _context.Products.AsNoTracking()
                               select new ProductDto
                               {
                                   Name = a.Name,
                                   Price = a.Price,
                                   Color = a.Color,
                                   IdType = a.IdType,
                                   MaxPrice = a.MaxPrice,
                                   MinPrice = a.MinPrice,
                                   PhanKhuc = a.PhanKhuc,
                                   Version = a.Version,
                                   Year = a.Year,
                               }).AsQueryable();
                if (product == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm");
                }

                product = product.Where(s => s.Name.Contains(nameCar));
                return product.ToList();

            }
            catch (Exception)
            {

                throw new Exception("Cập nhật thất bại");
            }


        }
        public ProductDto GetById(string id)
        {
            try
            {
                var product = (from a in _context.Products.AsNoTracking()
                               where a.Id.Equals(id)
                               select new ProductDto
                               {
                                   Name = a.Name,
                                   Price = a.Price,
                                   Color = a.Color,
                                   IdType = a.IdType,
                                   MaxPrice = a.MaxPrice,
                                   MinPrice = a.MinPrice,
                                   PhanKhuc = a.PhanKhuc,
                                   Version = a.Version,
                                   Year = a.Year,
                               }).FirstOrDefault();
                if (product == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm");
                }

                return product;

            }
            catch (Exception)
            {

                throw new Exception("Cập nhật thất bại");
            }


        }
    }
}
