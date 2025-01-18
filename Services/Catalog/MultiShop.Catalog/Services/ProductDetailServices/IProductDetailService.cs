using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string ProductDetailId);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string ProductDetailId);
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();

    }
}
