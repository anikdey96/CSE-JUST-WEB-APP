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
    
    public partial class current_academic
    {
        public int user_id { get; set; }
        public int student_id { get; set; }
        public System.DateTime admission_date { get; set; }
        public string session { get; set; }
        public string dept { get; set; }
        public double last_semester_result { get; set; }
        public string current_year { get; set; }
        public string current_semester { get; set; }
    
        public virtual student student { get; set; }
        public virtual user user { get; set; }
    }
}
