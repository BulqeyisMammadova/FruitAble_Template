using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents
{
    public class BannerViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
