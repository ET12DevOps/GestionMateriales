using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.Identity
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>(i => {
                i.Property(o => o.EmailConfirmed).HasConversion<int>();
                i.Property(o => o.LockoutEnabled).HasConversion<int>();
                i.Property(o => o.PhoneNumberConfirmed).HasConversion<int>();
                i.Property(o => o.TwoFactorEnabled).HasConversion<int>();
                i.Property(o => o.Habilitado).HasConversion<int>();
            });

            builder.Entity<ApplicationRole>(i => {
                i.Property(o => o.Habilitado).HasConversion<int>();
            });

            base.OnModelCreating(builder);
        }
    }
}
