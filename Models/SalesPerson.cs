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
    
    public partial class SalesPerson
    {
        public string StatusID { get; set; }
        public string SalesPersonID { get; set; }
        public string PartsMaterialMaterialID { get; set; }
    
        public virtual PartsMaterial PartsMaterial { get; set; }
    }
}
