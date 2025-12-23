using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class FactViewComponent:ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
