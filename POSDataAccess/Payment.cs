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
    
    public partial class Payment
    {
        public int ID { get; set; }
        public string Payment_For_Whom { get; set; }
        public Nullable<int> Payment_For_ID { get; set; }
        public Nullable<int> Journal_ID { get; set; }
    
        public virtual Journal Journal { get; set; }
    }
}
