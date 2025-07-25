using attendance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Context
{
   public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
      
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "efcb.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
