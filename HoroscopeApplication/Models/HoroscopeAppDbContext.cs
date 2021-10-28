using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class HoroscopeAppDbContext : DbContext
    {
        public HoroscopeAppDbContext(DbContextOptions<HoroscopeAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Sunsign> Sunsigns { get; set; }
        //public DbSet<HoroscopeCache> HoroscopeCaches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

        }
    }
}
