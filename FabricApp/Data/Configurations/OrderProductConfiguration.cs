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
    public partial class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> entity)
        {
            entity.HasNoKey();

            entity.ToTable("order_products");

            entity.HasIndex(e => e.OrderId, "IX_order_id_and_orders");

            entity.HasIndex(e => e.OrderId, "IX_product_id_and_products");

            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Order)
                .WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_order_products_orders");

            entity.HasOne(d => d.Product)
                .WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_order_products_products");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrderProduct> entity);
    }
}
