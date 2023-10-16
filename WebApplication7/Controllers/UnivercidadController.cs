using Microsoft.AspNetCore.Mvc;
using WebApplication7.Context;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversidadController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<UniversidadController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UniversidadController(
            ILogger<UniversidadController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [HttpPost(Name = "GetUniversidad")]
        public IActionResult Post(
            [FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Add(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //READ: Obtener lista de estudiantes
        [HttpGet(Name = "GetUniversidad")]
        public IEnumerable<Universidad> Get()
        {
            return _aplicacionContexto.Universidad.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Update(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //Delete: Eliminar estudiantes
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int universidadID)
        {
            _aplicacionContexto.Universidad.Remove(
             _aplicacionContexto.Universidad.ToList()
             .Where(x => x.iduniversidad == universidadID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(universidadID);
        }
    }
}