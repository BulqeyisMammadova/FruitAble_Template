using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class HeroViewComponent:ViewComponent
{
    public async  Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
