using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.SocialMediaDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList() {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SignalR.EntityLayer.Entities.SocialMedia() {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url
            
            });

            return Ok("SocialMedia Eklendi");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto) {
            _socialMediaService.TUpdate(new SignalR.EntityLayer.Entities.SocialMedia() { 
            Icon = updateSocialMediaDto.Icon,
            Title = updateSocialMediaDto.Title,
            Url = updateSocialMediaDto.Url

            
            });

            return Ok("SocailMedia Güncellendi");
        
        }


        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id) { 
        
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(value);
            return Ok("SocialMedia Silindi");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
    }
}
