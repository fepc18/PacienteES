using Microsoft.EntityFrameworkCore;
using PacienteES.Domain.Entities;

namespace Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Paciente> Paciente { get; set; }
      //  public DbSet<MovimientoInventarioDetalle> MovimientoInventarioDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Model Contraints
            ModelConfig(modelBuilder);
        }
        private void ModelConfig(ModelBuilder modelBuilder)
        {
          /*  new MovimientoInventarioConfiguration(modelBuilder.Entity<MovimientoInventario>());
            new MovimientoDetalleConfiguration(modelBuilder.Entity<MovimientoInventarioDetalle>());
            */


        }    
    }
}
