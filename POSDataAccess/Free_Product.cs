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
    
    public partial class Free_Product
    {
        public int ID { get; set; }
        public int Invoice_ID { get; set; }
        public int Product_ID { get; set; }
    
        public virtual Sale Sale { get; set; }
        public virtual Product Product { get; set; }
    }
}
