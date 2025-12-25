using Fruitable.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class HeaderViewComponent:ViewComponent
{
    private readonly ILayoutService _layoutService;
    public HeaderViewComponent(ILayoutService layoutService)
    {
        _layoutService = layoutService;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var setting = await _layoutService.GetAllSettingAsync();
        return View(setting);
    }
}
