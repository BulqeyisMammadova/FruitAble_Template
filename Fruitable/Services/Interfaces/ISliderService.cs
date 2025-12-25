using Fruitable.Data;
using Fruitable.ViewModels.Slider;

namespace Fruitable.Services.Interfaces;

public interface ISliderService
{
    Task<IEnumerable<SliderUIVM>> GetAllAsync();
}
