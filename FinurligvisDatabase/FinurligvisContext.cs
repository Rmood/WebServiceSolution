using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace FinurligvisDatabase
{
    public class FinurligvisContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;database=finurligvis;uid=Rmood;pwd=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Product Table
            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("category_id");

            //Client Table
            modelBuilder.Entity<Client>().ToTable("clients");
            modelBuilder.Entity<Client>().Property(x => x.FirstName).HasColumnName("first_name");
            modelBuilder.Entity<Client>().Property(x => x.LastName).HasColumnName("last_name");

            //Order Table
            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<Order>().Property(x => x.ClientId).HasColumnName("Client_id");

            //Category Table
            modelBuilder.Entity<Category>().ToTable("category");
            modelBuilder.Entity<Category>().Property(x => x.ParentId).HasColumnName("Parent_Id");
        }
    }
}
