using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Universidad
    {
        [Key]
        public int iduniversidad { get; set; }
        public string nombre { get; set; }
    }
}
