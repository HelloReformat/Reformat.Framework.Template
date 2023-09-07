namespace WebApi.Domain;

public class DemoEntity
{
    /// <summary>
    /// 日期
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// 数值1
    /// </summary>
    public int TemperatureC { get; set; }
    
    /// <summary>
    /// 数值2
    /// </summary>

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// 字符
    /// </summary>
    public string? Summary { get; set; }
}