using JobBoard.API.Entities;
using Microsoft.EntityFrameworkCore;
namespace JobBoard.API.Data
{
    public class JobBoardContext: DbContext
    {
        public JobBoardContext(DbContextOptions<JobBoardContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany()
                .HasForeignKey(u => u.IdRol);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Empresa)
                .WithMany()
                .HasForeignKey(u => u.IdEmpresa);
        }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<ModalidadTrabajo> ModalidadesTrabajo { get; set; }
        public DbSet<TipoContrato> TiposContrato { get; set; }
        public DbSet<NivelEducativo> NivelesEducativos { get; set; }
        public DbSet<Habilidad> Habilidades { get; set; }
        public DbSet<Vacante> Vacantes { get; set; }
        public DbSet<UsuarioHabilidad> UsuarioHabilidades { get; set; }
        public DbSet<VacanteAplicada> VacantesAplicadas { get; set; }
        public DbSet<VacanteHabilidad> VacanteHabilidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
    }
}
