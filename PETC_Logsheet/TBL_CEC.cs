//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PETC_Logsheet
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CEC
    {
        public int ID { get; set; }
        public string PETC_CODE { get; set; }
        public string PETC_NAME { get; set; }
        public Nullable<System.DateTime> PETC_EXPIRY { get; set; }
        public Nullable<System.DateTime> PETC_ASSIGNED { get; set; }
        public string PETC_ASSIGNTO { get; set; }
    }
}
