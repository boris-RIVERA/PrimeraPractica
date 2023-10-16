using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class Docentes
    {
        [Key]
        public int iddocente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ubicacion { get; set; }
        public string sexo { get; set; }
        public string ci { get; set; }

        [ForeignKey("Universidad")]
        public int iduniversidad { get; set; }
        public Universidad universidad { get; set; }
    }
}
