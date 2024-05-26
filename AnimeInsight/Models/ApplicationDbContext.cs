using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AnimeInsight.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, one can rename the ASP.NET Identity table names and more.
            // Add customizations after calling base.OnModelCreating(builder);

            builder.Entity<IdentityUser>(entity =>
            {
                entity.Property(e => e.EmailConfirmed).HasConversion<int>().HasColumnType("NUMBER(1)");
                entity.Property(e => e.PhoneNumberConfirmed).HasConversion<int>().HasColumnType("NUMBER(1)");
                entity.Property(e => e.TwoFactorEnabled).HasConversion<int>().HasColumnType("NUMBER(1)");
                entity.Property(e => e.LockoutEnabled).HasConversion<int>().HasColumnType("NUMBER(1)");
            });
        }

        public DbSet<Anime> Animes { get; set; }
    }
}
