using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [Route("api/statusAPI")] //Rota base: /api/health
    [ApiController] //ativa validação automatica e outras funcionalidades da api


    public class HealthController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "UP",
                service = "primeira api",
                data = DateTime.Now
            }
                
                ); //retorna um simples 200 ok
        }
    }
}
