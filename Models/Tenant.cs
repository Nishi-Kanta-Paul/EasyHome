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
    
    public partial class Tenant
    {
        public Tenant()
        {
            this.Rentealseats = new HashSet<Rentealseat>();
            this.Users = new HashSet<User>();
        }
    
        public int id { get; set; }
    
        public virtual ICollection<Rentealseat> Rentealseats { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
