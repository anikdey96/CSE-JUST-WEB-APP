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
    
    public partial class carrier_t
    {
        public int teacher_id { get; set; }
        public System.DateTime joining_date { get; set; }
        public string phd_status { get; set; }
        public string phd_institute { get; set; }
        public string msc_status { get; set; }
        public string msc_institute { get; set; }
        public string msc_session { get; set; }
        public double msc_result { get; set; }
        public string bsc_status { get; set; }
        public string bsc_institute { get; set; }
        public string bsc_session { get; set; }
        public double bsc_result { get; set; }
        public string ex_institute { get; set; }
        public Nullable<System.DateTime> join_date { get; set; }
        public Nullable<System.DateTime> leave_date { get; set; }
    
        public virtual teacher teacher { get; set; }
    }
}
