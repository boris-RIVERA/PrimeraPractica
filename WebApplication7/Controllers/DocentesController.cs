using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Context;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        private readonly AplicacionContexto _context;

        public DocentesController(AplicacionContexto context)
        {
            _context = context;
        }

        // GET: api/Docentes
        [HttpGet]
        public async Task<IActionResult> GetDocentes()
        {
            var docentes = await _context.docentes.ToListAsync();
            return Ok(docentes);
        }

        // GET: api/Docentes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocente(int id)
        {
            var docente = await _context.docentes.FindAsync(id);

            if (docente == null)
            {
                return NotFound();
            }

            return Ok(docente);
        }

        // POST: api/Docentes
        [HttpPost]
        public async Task<IActionResult> PostDocente([FromBody] Docentes docente)
        {
            _context.docentes.Add(docente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocente", new { id = docente.iddocente }, docente);
        }

        // PUT: api/Docentes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocente(int id, [FromBody] Docentes docente)
        {
            if (id != docente.iddocente)
            {
                return BadRequest();
            }

            _context.Entry(docente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Docentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocente(int id)
        {
            var docente = await _context.docentes.FindAsync(id);
            if (docente == null)
            {
                return NotFound();
            }

            _context.docentes.Remove(docente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocenteExists(int id)
        {
            return _context.docentes.Any(d => d.iddocente == id);
        }
    }
}
