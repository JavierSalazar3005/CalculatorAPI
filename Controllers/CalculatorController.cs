using Microsoft.AspNetCore.Mvc;
{ } using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace CalculatorAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new { a, b, result });
        }
    }
}
