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
    
    public partial class material
    {
        public int materials_id { get; set; }
        public int user_id { get; set; }
        public string materials_topic { get; set; }
        public string arranged_by { get; set; }
        public string reference { get; set; }
        public System.DateTime publish_date { get; set; }
        public string specification { get; set; }
    
        public virtual user user { get; set; }
    }
}
