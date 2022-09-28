﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FabricApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FabricApp.Models.Configurations
{
    public partial class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.ToTable("products");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Amount).HasColumnName("amount");

            entity.Property(e => e.Length).HasColumnName("length");

            entity.Property(e => e.Rotation).HasColumnName("rotation");

            entity.Property(e => e.Width).HasColumnName("width");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Product> entity);
    }
}