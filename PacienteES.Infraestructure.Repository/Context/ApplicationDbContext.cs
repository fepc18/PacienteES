using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using PacienteES.Infraestructure.Repository.EntityConfiguration;

namespace Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
       /* public ApplicationDbContext() : base("Name=ApplicationDbContext")
        {

        }*/
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
            new PacienteConfiguration(modelBuilder.Entity<Paciente>());
            /*    new MovimientoDetalleConfiguration(modelBuilder.Entity<MovimientoInventarioDetalle>());
             */
        }

    }
}
