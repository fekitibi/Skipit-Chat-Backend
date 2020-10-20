using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkipitChat.Domain;

namespace SkipitChat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Accessibility> Accessiblities { get; set; }
        public DbSet<CityPass> CityPasses { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
