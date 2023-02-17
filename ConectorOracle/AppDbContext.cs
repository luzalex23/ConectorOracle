using ConectorOracle.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConectorOracle
{
    public class AppDbContext : DbContext
    {
        public DbSet<Developer>? Developer { get; set; }
        public DbSet<Skill>? Skill { get; set; }
        public DbSet<SkillDeveloper>? SkillDeveloper { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = "User Id=C##ALEXSANDRO;Password=12345;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST =localhost)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XE)))";
            optionsBuilder.UseOracle(stringConexao);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>();
            modelBuilder.Entity<Skill>();
            modelBuilder.Entity<SkillDeveloper>();
        }
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
