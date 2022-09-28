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
    public partial class ClothConfiguration : IEntityTypeConfiguration<Cloth>
    {
        public void Configure(EntityTypeBuilder<Cloth> entity)
        {
            entity.ToTable("cloths");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Color)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("color");

            entity.Property(e => e.Image).HasColumnName("image");

            entity.Property(e => e.Length).HasColumnName("length");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.Property(e => e.Pattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pattern");

            entity.Property(e => e.Price).HasColumnName("price");

            entity.Property(e => e.Width).HasColumnName("width");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Cloth> entity);
    }
}
