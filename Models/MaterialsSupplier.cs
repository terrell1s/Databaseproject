//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MaterialsSupplier
    {
        public MaterialsSupplier()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ClientClientID { get; set; }
        public string ClientClientID1 { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Client Client1 { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
