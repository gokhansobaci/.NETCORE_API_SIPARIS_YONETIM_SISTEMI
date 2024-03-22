using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.DiscountDto;
using SignalR.EntityLayer.Entities;
using System.Security.Cryptography.X509Certificates;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList() {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Description = createDiscountDto.Description,
                Amount = createDiscountDto.Amount,
                ImageUrl = createDiscountDto.ImageUrl,
                Title = createDiscountDto.Title,
            });
            return Ok("Discount Eklendi");
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Description = updateDiscountDto.Description,
                DiscountID = updateDiscountDto.DiscountID,
                Amount = updateDiscountDto.Amount,
                ImageUrl= updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title,
            });
            return Ok("Discount Güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);  
            _discountService.TDelete(value);
            return Ok("Discount Silindi");
        }

        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
    }
}
