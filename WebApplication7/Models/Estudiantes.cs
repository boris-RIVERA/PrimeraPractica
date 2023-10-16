using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class Estudiantes
    {
        [Key]
        public int idestudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }    
        public int edad { get; set; }
        public string sexo { get; set; }

        [ForeignKey("universidad")]
        public int iduniversidad { get; set; }
        public Universidad universidad { get; set; }


    }
}
