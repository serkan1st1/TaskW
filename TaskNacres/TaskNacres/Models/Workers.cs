//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskNacres.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workers
    {
        public int WorkerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int TC { get; set; }
        public Nullable<int> Company_CompanyID { get; set; }
        public string CompanyName { get; set; }
    
        public virtual Companies Companies { get; set; }
    }
}
