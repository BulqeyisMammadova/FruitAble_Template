using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents
{
    public class TastimonialViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
