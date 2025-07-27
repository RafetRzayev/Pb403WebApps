using Fiorelle.DataContext;
using Fiorelle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorelle.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logo = await _dbContext.Logo.FirstOrDefaultAsync();

            var headerViewModel = new HeaderViewModel
            {
                LogoUrl = logo?.ImageUrl
            };

            return View(headerViewModel);
        }
    }
}
