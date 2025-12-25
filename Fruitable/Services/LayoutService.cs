using Fruitable.Data;
using Fruitable.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fruitable.Services;

public class LayoutService : ILayoutService
{
    private readonly AppDbContext _context;
    public LayoutService(AppDbContext context)
    {
       _context = context;
    }
    public async Task<Dictionary<string, string>> GetAllSettingAsync()
    {
        var setting = await _context.Settings.ToDictionaryAsync(s=>s.Key, s=>s.Value);
        return setting;
    }
}
