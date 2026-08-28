using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using MiCuadrado.models;

namespace MiCuadrado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TenisController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TenisController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            string connectionString = _configuration.GetConnectionString("SomeeDb")!;

            using (var connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Marca, Modelo, Talla, Precio, Stock FROM Tenis";
                var listaTenis = await connection.QueryAsync<Tenis>(sql);
                return Ok(listaTenis);
            }
        }
    }
}