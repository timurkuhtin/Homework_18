using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_18.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Homework_18
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Application;Integrated Security=True";

        public DbSet<Office> Offices { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public DbSet<Title> Titles { get; set; }

        public ApplicationContext()
        {       
        }

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }
    }
}
