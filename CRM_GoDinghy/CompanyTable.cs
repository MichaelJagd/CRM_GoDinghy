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
    
    public partial class CompanyTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyTable()
        {
            this.CustomersTables = new HashSet<CustomersTable>();
        }
    
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersTable> CustomersTables { get; set; }
    }
}