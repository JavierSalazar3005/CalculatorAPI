{ } using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace CalculatorAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
    }
}
