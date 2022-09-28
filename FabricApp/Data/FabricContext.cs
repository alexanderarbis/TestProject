﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FabricApp.Data.Configurations;
using FabricApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
#nullable disable

namespace FabricApp.Data
{
    public partial class FabricContext : DbContext
    {
        public FabricContext()
        {
        }

        public FabricContext(DbContextOptions<FabricContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=localhost;Database=Fabric;User Id=sa;Password=231456zxqwerty;");

        public virtual DbSet<Cloth> Cloths { get; set; }
        public virtual DbSet<ClothMaterial> ClothMaterials { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<FurnitureType> FurnitureTypes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCloth> ProductCloths { get; set; }
        public virtual DbSet<ProductFurniture> ProductFurnitures { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WarehouseCloth> WarehouseCloths { get; set; }
        public virtual DbSet<WarehouseFurniture> WarehouseFurnitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.ClothConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ClothMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.FurnitureConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.FurnitureTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OrderConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OrderProductConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ProductConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ProductClothConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ProductFurnitureConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RoleConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.WarehouseClothConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.WarehouseFurnitureConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
