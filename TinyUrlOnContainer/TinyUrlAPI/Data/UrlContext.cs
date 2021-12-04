using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyUrlAPI.Domains;

namespace TinyUrlAPI.Data
{
    public class UrlContext : DbContext
    {
        public UrlContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<URLData> urls  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<URLData>(e =>
            {
                e.Property(c => c.Id)
                 .IsRequired()
                 .ValueGeneratedOnAdd();

                e.Property(c => c.LongUrl)
                  .IsRequired()
                  .HasMaxLength(2048);

                e.Property(c => c.ShortUrl)
                 .IsRequired()
                 .HasMaxLength(7);
                e.Property(c => c.CreatedAt)
                 .IsRequired();

                e.Property(c => c.ExpiresAt)
                 .IsRequired();


            });
        }
    }
}
