﻿using Microsoft.AspNetCore.Mvc;
using PodCast.DataContext;
using PodCast.Models;

namespace PodCast.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socials = _dbContext.Socials.ToList();
            var bio = _dbContext.Bios.FirstOrDefault();

            var model = new FooterViewModel
            {
                Socials = socials,
                Bio = bio
            };

            return View(model);
        }
    }
}
