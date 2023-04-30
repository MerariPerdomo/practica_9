using Microsoft.EntityFrameworkCore;

namespace practica_9.Models
{
    public class equiposDbcontext : DbContext
    {
        public equiposDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<estados_equipo> estados_equipos { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
    }
}
