using Fruitable.Data;
using Fruitable.Services.Interfaces;
using Fruitable.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace Fruitable.Services;

public class SliderService : ISliderService
{
    private readonly AppDbContext _context;
    public SliderService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<SliderUIVM>> GetAllAsync()
    {
        IEnumerable<SliderUIVM> slider = await _context.Sliders.Select(s => new SliderUIVM
        {
            Title = s.Title,
            Image = s.Image,
        }).ToListAsync();
        return slider;
    }
}





