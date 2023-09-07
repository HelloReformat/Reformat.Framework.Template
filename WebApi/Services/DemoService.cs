using Reformat.Framework.Core.Core;
using Reformat.Framework.Core.IOC.Attributes;
using Reformat.Framework.Core.IOC.Services;
using WebApi.Domain;

namespace WebApi.Services;

[SingleService]
public class DemoService : BaseSingleService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public DemoService(IocSingle iocSingle) : base(iocSingle)
    {
    }

    public List<DemoEntity> GetForecast()
    {
        var weatherForecasts = Enumerable.Range(1, 5).Select(index => new DemoEntity
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToList();
        return weatherForecasts;
    }
}