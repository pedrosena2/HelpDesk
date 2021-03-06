using Microsoft.EntityFrameworkCore;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Ambiente> Ambientes {get; set;}
        public DbSet<Incidente> Incidentes {get; set;}
        public DbSet<Inventario> Inventarios {get; set;}
        public DbSet<Login> Login {get; set;}
        public DbSet<MantenimientoC> MantenimientosC {get; set;}
        public DbSet<MantenimientoP> MantenimientosP {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=ProyectoFinalADSI2207208; Data Source=MANAPRRCLFSD803\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}