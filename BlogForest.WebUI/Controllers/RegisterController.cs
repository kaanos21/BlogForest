﻿using BlogForest.DtoLayerr.RegisterDto;
using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateRegisterDto createRegisterDto)
        {
            AppUser appUser = new AppUser()
            {
                Name = createRegisterDto.Name,
                Surname=createRegisterDto.SurnName,
                Email=createRegisterDto.Email,
                ImageUrl = createRegisterDto.ImageUrl,
                Description = createRegisterDto.Description,
                UserName=createRegisterDto.Username
            };
            var result =await _userManager.CreateAsync(appUser, createRegisterDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
