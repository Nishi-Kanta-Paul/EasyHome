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
    
    public partial class rentrev
    {
        public int id { get; set; }
        public string review { get; set; }
        public Nullable<int> reveiewerid { get; set; }
        public Nullable<int> rentid { get; set; }
    
        public virtual Rentealseat Rentealseat { get; set; }
        public virtual User User { get; set; }
    }
}