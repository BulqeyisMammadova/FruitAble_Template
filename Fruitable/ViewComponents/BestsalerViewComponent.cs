using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class BestsalerViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
