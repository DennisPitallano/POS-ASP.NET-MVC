//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Supplier
    {
        public int ID { get; set; }
        public string Ref_Number { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
        public Nullable<int> Journal_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Journal Journal { get; set; }
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
