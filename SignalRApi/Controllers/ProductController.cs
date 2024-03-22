using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.FeatureDto;
using SignalR.DTOLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Concrete;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);



        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory() {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                CategoryName = y.Category.CategoryName,
                ProductDescription = y.ProductDescription,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus
            });
            return Ok(values.ToList());  

                
        
        
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                ProductDescription = createProductDto.ProductDescription,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus
            });

            return Ok("Product Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Product Silindi");
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductID = updateProductDto.ProductID,
               ProductDescription = updateProductDto.ProductDescription,
               ImageUrl = updateProductDto.ImageUrl,
               Price = updateProductDto.Price,
               ProductName = updateProductDto.ProductName,
               ProductStatus = updateProductDto.ProductStatus
               

            });
            return Ok("Product Güncellendi");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }
}
