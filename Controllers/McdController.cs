using Microsoft.AspNetCore.Mvc;
using MiApiCuadrado.Services;

namespace MiApiCuadrado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class McdController : ControllerBase
    {
        private readonly MathService _mathService;

        public McdController(MathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet("{dividendo}/{divisor}")]
        public IActionResult GetMcd(int dividendo, int divisor)
        {
            int resultado = _mathService.CalcularMcd(dividendo, divisor);
            
            return Ok(new { 
                Dividendo = dividendo, 
                Divisor = divisor, 
                Mcd = resultado 
            });
        }
    }
}