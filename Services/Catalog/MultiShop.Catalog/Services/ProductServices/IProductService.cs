using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string ProductId);
        Task<GetByIdProductDto> GetByIdProductAsync(string ProductId);
        Task<List<ResultProductDto>> GetAllProductAsync();
    }
}
