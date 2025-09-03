using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.IO;

namespace Database
{
    public class AppDbContext : DbContext
    {
     
        private readonly string  _dbPath;
        public AppDbContext(string dbPath){
            _dbPath = dbPath;
        }
        public AppDbContext()
        {
            _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "databasefile.db");
        }
        public AppDbContext(DbContextOptionsBuilder db) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={_dbPath}");
            }
            
        }
        public DbSet<DayIdentifier> DayIdentifiers { get; set; }
        public DbSet<Water_Specifics> Water_Specifics { get; set; }
     
    }
    
}
