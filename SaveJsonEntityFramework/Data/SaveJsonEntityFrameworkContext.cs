using Microsoft.EntityFrameworkCore;
using SaveJsonEntityFramework.Models;
using System.Text.Json;

namespace SaveJsonEntityFramework.Data
{
	public class SaveJsonEntityFrameworkContext : DbContext
    {
        public SaveJsonEntityFrameworkContext (DbContextOptions<SaveJsonEntityFrameworkContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(x => 
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Data)
                .HasConversion(j => j.GetRawText(), v => JsonDocument.Parse(v, default).RootElement);
            });
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
