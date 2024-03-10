using Mango.Website.Models;

namespace Mango.Website.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetAllProductsAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductAsync(ProductDto ProductDto);
        Task<ResponseDto?> UpdateProductAsync(ProductDto ProductDto);
        Task<ResponseDto?> RemoveProductAsync(int id);
    }
}
