using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents
{
    public class FeatureSectionViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
