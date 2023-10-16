using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Estudiantes> estudiantes { get; set; }
        public DbSet<Docentes> docentes { get; set; }
        public DbSet<Universidad> Universidad { get; set; }
    }
}