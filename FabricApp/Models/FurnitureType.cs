﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FabricApp.Models
{
    public partial class FurnitureType
    {
        public FurnitureType()
        {
            Furnitures = new HashSet<Furniture>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Furniture> Furnitures { get; set; }
    }
}