using Microsoft.AspNetCore.Mvc;

namespace DistributedCache.WebApi.Controllers.V1
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("v1/[controller]")]
    public class CacheController : DefaultControllerBase
    {
        private readonly ILogger<CacheController> _logger;

        public CacheController(ILogger<CacheController> logger) : base(logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index() => await AsyncResult(async () =>
        {
            _logger.LogInformation($"({nameof(CacheController)}) New request received");

            return Ok();
        });
    }
}
