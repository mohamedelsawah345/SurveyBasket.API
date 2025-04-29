using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SurveyBasket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelpmentController : ControllerBase
    {   private readonly ILogger _logger;
        private readonly IOperationTransiente _OperationTransiente;
        private readonly IOperationScoped _OperationScoped;
        private readonly IOperationSingelton _OperationSingelton;


        public DevelpmentController(IOperationTransiente operationTransiente, IOperationScoped operationScoped, IOperationSingelton operationSingelton, ILogger<DevelpmentController> logger)
        {

            _OperationTransiente = operationTransiente;
            _OperationScoped = operationScoped;
            _OperationSingelton = operationSingelton;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult RunApp()
        {
            _logger.LogInformation("Transitent {0}", _OperationTransiente.OperationId);
            //_logger.LogWarning("Scoped {0}", _OperationScoped.OperationId);
            //_logger.LogError("Singelton{0}", _OperationSingelton.OperationId);

            return Ok();
        }
    }
}
