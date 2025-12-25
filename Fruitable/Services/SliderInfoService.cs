using Fruitable.Data;
using Fruitable.Services.Interfaces;
using Fruitable.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace Fruitable.Services;

public class SliderInfoService : ISliderInfoService
{
    private readonly AppDbContext _context;
    public SliderInfoService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<SliderInfoUIVM> GetAllAsync()
    {
        SliderInfoUIVM? sliderInfo =await _context.SliderInfos.Select(s=>new SliderInfoUIVM
        {
            Title = s.Title,
            Description = s.Description
        }).FirstOrDefaultAsync();

        return sliderInfo;
    }
}
