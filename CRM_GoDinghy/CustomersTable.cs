//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_GoDinghy
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomersTable
    {
        public int ID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> PhoneNummer { get; set; }
        public string Mail { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual CompanyTable CompanyTable { get; set; }
    }
}
