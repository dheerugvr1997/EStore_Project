using EStoreAdminModel.Models.Brands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreAdminRepository
{
    // This class becomes a Repository class once it inherits from DbContext class. This is the main class that coordinates Entity Framework functionality for a given data model.
    public class BrandRepository : DbContext
    {
        // Once the object of this class is created, it will create a table in the database with the name of the DbSet property.
        // In this case, it will create a table named "Brands" in the database.
        public BrandRepository(DbContextOptions<BrandRepository> options) : base(options)
        {
            
        }

        public DbSet<BrandModel> Brands { get; set; } // This property represents the "Brands" table in the database.


        // DbCOntext has a internla virtual method called OnModelCreating which is used to configure the model that was discovered by convention from the entity types exposed in DbSet properties on your derived context. T
        // he resulting model may be cached and re-used for subsequent instances of your derived context.
        // This is just required only for Migrations.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure the Brand entity
        //    modelBuilder.Entity<BrandModel>(entity =>
        //    {
        //        entity.ToTable("Brands"); // Map to the "Brands" table
        //        entity.HasKey(e => e.Id); // Set the primary key
        //        entity.Property(e => e.Name).IsRequired().HasMaxLength(100); // Set the Name property as required with a max length of 100
        //    });

        //    // Seed initial data
        //    modelBuilder.Entity<BrandModel>().HasData(
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Samsung" },
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Apple" },
        //        new BrandModel { Id = Guid.NewGuid(), Name = "Vivo" }
        //    );
        //}
    }
}
