//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marina.Ass1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lease
    {
        public int ID { get; set; }
        public int SlipID { get; set; }
        public int CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Slip Slip { get; set; }
    }
}
