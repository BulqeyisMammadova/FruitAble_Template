using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class FruitViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
