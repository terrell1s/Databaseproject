﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class plantprojectEntities : DbContext
    {
        public plantprojectEntities()
            : base("name=plantprojectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<MaterialsSupplier> MaterialsSuppliers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PartLocation> PartLocations { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartsMaterial> PartsMaterials { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
    }
}