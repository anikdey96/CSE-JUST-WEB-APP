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
    
    public partial class activity
    {
        public int student_id { get; set; }
        public bool club_membership { get; set; }
        public string designation { get; set; }
        public string achievement { get; set; }
        public bool others_co_curricular_activities { get; set; }
        public string description { get; set; }
    
        public virtual student student { get; set; }
    }
}
