using DistributedCache.WebApi.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DistributedCache.WebApi.Controllers
{
    public class DefaultControllerBase : ControllerBase
    {
        private readonly ILogger _logger;

        public DefaultControllerBase(ILogger logger)
        {
            _logger = logger;
        }

        protected async Task<IActionResult> AsyncResult(Func<Task<IActionResult>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request. Try again later.");

                return StatusCode(500, new BaseResponse { Message = "An error occurred while processing the request. Try again later." });
            }
        }
    }
}
