﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FabricApp.Models
{
    public partial class Furniture
    {
        public Furniture()
        {
            WarehouseFurnitures = new HashSet<WarehouseFurniture>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Weight { get; set; }
        public byte[] Image { get; set; }
        public double? Price { get; set; }
        public long? TypeId { get; set; }

        public virtual FurnitureType Type { get; set; }
        public virtual ICollection<WarehouseFurniture> WarehouseFurnitures { get; set; }
    }
}