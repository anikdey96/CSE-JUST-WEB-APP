//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.results = new HashSet<result>();
            this.activities = new HashSet<activity>();
            this.current_academic = new HashSet<current_academic>();
            this.previous_academic = new HashSet<previous_academic>();
        }
    
        public int student_id { get; set; }
        public int user_id { get; set; }
        public int usertype_id { get; set; }
        public bool quota { get; set; }
        public string skills { get; set; }
        public string hobby { get; set; }
        public string fathers_name { get; set; }
        public string fathers_occupassion { get; set; }
        public string fathers_contact_no { get; set; }
        public string mothers_name { get; set; }
        public string mothers_occupassion { get; set; }
        public string mothers_contact_no { get; set; }
        public string guardians_name { get; set; }
        public string guardians_occupassion { get; set; }
        public string guardians_contact_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<result> results { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activity> activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<current_academic> current_academic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<previous_academic> previous_academic { get; set; }
    }
}
