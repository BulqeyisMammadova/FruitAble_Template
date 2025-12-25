namespace Fruitable.Services.Interfaces;

public interface ILayoutService
{
    Task<Dictionary<string, string>> GetAllSettingAsync();
}
