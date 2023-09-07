using Microsoft.AspNetCore.Mvc;
using Reformat.Framework.Core.Core;
using Reformat.Framework.Core.IOC.Attributes;
using Reformat.Framework.Core.IOC.Services;
using WebApi.Domain;
using WebApi.Services;

namespace WebApi.Controllers;

/// <summary>
/// 演示接口
/// </summary>
public class DemoController : BaseController
{
    [Autowired]
    private DemoService DemoService;
    
    public DemoController(IocScoped iocScoped) : base(iocScoped)
    {
    }
    
    /// <summary>
    /// 演示示例
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IEnumerable<DemoEntity> GetDemo()
    {
        return DemoService.GetForecast();
    }
}