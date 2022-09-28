﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FabricApp.Data;
using FabricApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FabricApp.Data.Configurations
{
    public partial class ProductFurnitureConfiguration : IEntityTypeConfiguration<ProductFurniture>
    {
        public void Configure(EntityTypeBuilder<ProductFurniture> entity)
        {
            entity.HasNoKey();

            entity.ToTable("product_furnitures");

            entity.HasIndex(e => e.ProductId, "IX_product_furnitures_and_furnitures");

            entity.HasIndex(e => e.ProductId, "IX_product_furnitures_and_products");

            entity.Property(e => e.FurnitureId).HasColumnName("furniture_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Furniture)
                .WithMany()
                .HasForeignKey(d => d.FurnitureId)
                .HasConstraintName("FK_product_furnitures_furniture");

            entity.HasOne(d => d.Product)
                .WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_product_furnitures_products");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductFurniture> entity);
    }
}
