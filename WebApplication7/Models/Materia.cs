using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class Materia
    {
        public int idmateria { get; set; }
        public string nombre { get; set; }

        [ForeignKey("docente")]
        public int iddocente { get; set; }
        public Docentes docente { get; set; }
    }
}
