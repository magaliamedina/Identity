using IdentityUsuario.Configurations.Entities;
using IdentityUsuario.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityUsuario.Data
{
    public class DatabaseContext : IdentityDbContext<AppUser>
    {
        //para hacer la migration hay que bajar tools

        public DatabaseContext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //para usar hay que descargar el paquete sqlserver
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=IdentityUsuario;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //configuracion de entidad para role. se puede implementar de la misma para todas las entidades
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
