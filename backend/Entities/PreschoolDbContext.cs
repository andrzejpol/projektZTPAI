﻿using Microsoft.EntityFrameworkCore;

namespace backend.Entities
{
    public class PreschoolDbContext : DbContext
    {
        private string _connectionString = "Host=localhost;Port=5432;Database=preschool;User Id=postgres;Password=paswd;";
        public DbSet<User>? Users { get; set; } 
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Preschool>? Preschools { get; set; }
        public DbSet<Child>? Children { get; set; }
        public DbSet<Opinion>? Opinions { get; set; }
        public DbSet<Group>? Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
    }
}
