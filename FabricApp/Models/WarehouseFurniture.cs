﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FabricApp.Models
{
    public partial class WarehouseFurniture
    {
        public long Id { get; set; }
        public long? FurnitureId { get; set; }
        public int? Amount { get; set; }

        public virtual Furniture Furniture { get; set; }
    }
}