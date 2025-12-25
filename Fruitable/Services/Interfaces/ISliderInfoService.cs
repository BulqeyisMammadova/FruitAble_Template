using Fruitable.ViewModels.Slider;

namespace Fruitable.Services.Interfaces;

public interface ISliderInfoService
{
    Task<SliderInfoUIVM> GetAllAsync();
}
