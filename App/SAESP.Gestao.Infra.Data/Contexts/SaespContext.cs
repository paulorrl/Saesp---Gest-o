using SAESP.Gestao.Infra.Data.Mapping;
using System.Data.Entity;

namespace SAESP.Gestao.Infra.Data.Contexts
{
    public class SaespContext : DbContext
    {
        public SaespContext()
            : base("")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Usuario.Domain.Entities.Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}