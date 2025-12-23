using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class VesitableViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
