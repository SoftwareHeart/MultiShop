using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _productDetailsService;
        public ProductDetailsController(IProductDetailService productDetailsService)
        {
            _productDetailsService = productDetailsService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var result = await _productDetailsService.GetAllProductDetailAsync();
            return Ok(result);
        }
        [HttpGet("{productDetailId}")]
        public async Task<IActionResult> GetProductDetailById(string productDetailId)
        {
            var result = await _productDetailsService.GetByIdProductDetailAsync(productDetailId);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _productDetailsService.CreateProductDetailAsync(createProductDetailDto);
            return Ok("Ürün detayı başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string productDetailId)
        {
            await _productDetailsService.DeleteProductDetailAsync(productDetailId);
            return Ok("Ürün detayı başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _productDetailsService.UpdateProductDetailAsync(updateProductDetailDto);
            return Ok("Ürün detayı başarıyla güncellendi");
        }
    }
}
