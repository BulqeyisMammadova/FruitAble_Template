using Fruitable.Services.Interfaces;
using Fruitable.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;

namespace Fruitable.ViewComponents;

public class HeroViewComponent:ViewComponent
{
    private readonly ISliderService _sliderService;
    private readonly ISliderInfoService _sliderInfoService;
    public HeroViewComponent(ISliderInfoService sliderInfoService, ISliderService sliderService)
    {
        _sliderInfoService = sliderInfoService;
        _sliderService = sliderService;
    }
    public async  Task<IViewComponentResult> InvokeAsync()
    {
        var slider =await _sliderService.GetAllAsync();
        var sliderInfo =await _sliderInfoService.GetAllAsync();
        SliderVMVC model = new SliderVMVC()
        {
            SliderInfo = sliderInfo,
            Sliders = slider
        };
        return View(model);
    }
}

public class SliderVMVC
{
    public SliderInfoUIVM? SliderInfo {  get; set; }
    public IEnumerable<SliderUIVM>? Sliders {  get; set; }
}