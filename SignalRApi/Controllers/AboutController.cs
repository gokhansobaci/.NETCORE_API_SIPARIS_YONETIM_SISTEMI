﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl,
                Title = createAboutDto.Title
               
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda kısmı başarıyla eklendi");   
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok("Hakkımda alanı silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutId = updateAboutDto.AboutId,   
                Description = updateAboutDto.Description,   
                ImageUrl= updateAboutDto.ImageUrl,
                Title = updateAboutDto.Title
            };

            _aboutService.TUpdate(about);
            return Ok("Hakkımda alanı güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id) {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        
        }

    }
}
