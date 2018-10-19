using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ApiValidacao.Model;

namespace ApiValidacao.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {      
        public DbSet<Usuario> Usuario { get; set; }        

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Usuario>().ToTable("Usuario");

            base.OnModelCreating(mb);           
        }
    }
}