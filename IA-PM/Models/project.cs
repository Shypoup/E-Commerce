//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IA_PM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            this.hirings = new HashSet<hiring>();
            this.projrequests = new HashSet<projrequest>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string descreption { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> customerid { get; set; }
        public Nullable<int> progressid { get; set; }
        public Nullable<int> MDId { get; set; }
        public Nullable<int> MTLId { get; set; }
        public Nullable<int> MT1Id { get; set; }
        public Nullable<int> MT2id { get; set; }
        public Nullable<int> MT3id { get; set; }
        public Nullable<int> MT4id { get; set; }
        public Nullable<int> MT5id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hiring> hirings { get; set; }
        public virtual progress progress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projrequest> projrequests { get; set; }
    }
}
