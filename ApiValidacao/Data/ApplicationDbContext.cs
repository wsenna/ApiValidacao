using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ApiValidacao.Model;

namespace ApiValidacao.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //public DbSet<Usuarios> Usuarios { get; set; }        

        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Usuarios>().ToTable("Usuario");

        //    base.OnModelCreating(mb);            
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}