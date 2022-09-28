﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FabricApp.Models
{
    public partial class User
    {
        public User()
        {
            OrderCustomerNavigations = new HashSet<Order>();
            OrderManagerNavigations = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long? RoleId { get; set; }

        public virtual ICollection<Order> OrderCustomerNavigations { get; set; }
        public virtual ICollection<Order> OrderManagerNavigations { get; set; }
    }
}