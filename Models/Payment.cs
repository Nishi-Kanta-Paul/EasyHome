//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectsd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int id { get; set; }
        public Nullable<int> senderId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<int> recieverid { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}