using DotNetPractical.RestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPractical.RestAPI.Databases
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
