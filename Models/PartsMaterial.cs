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
    
    public partial class PartsMaterial
    {
        public PartsMaterial()
        {
            this.SalesPersons = new HashSet<SalesPerson>();
        }
    
        public string MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string PartPartsID { get; set; }
    
        public virtual Part Part { get; set; }
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }
    }
}