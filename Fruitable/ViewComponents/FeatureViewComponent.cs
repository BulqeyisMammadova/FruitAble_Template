using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class FeatureViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
