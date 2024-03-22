using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;
using System.Runtime.CompilerServices;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);   
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                ImageUrl = createTestimonialDto.ImageUrl,
                Name =  createTestimonialDto.Name,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title
            });
            return Ok("Testimonial Eklendi");
        }


        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
               TestimonialID = updateTestimonialDto.TestimonialID,
               Comment = updateTestimonialDto.Comment,
               ImageUrl = updateTestimonialDto.ImageUrl,
               Name= updateTestimonialDto.Name,
               Status = updateTestimonialDto.Status,
               Title =  updateTestimonialDto.Title
            });
            return Ok("Testimonial Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Testimonial Silindi");
        }
        [HttpGet("GetTestimonial/{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
