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
    
    public partial class TBL_LOGSHEET_INQUIRY
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> LOG_DATE { get; set; }
        public string LOG_PETCCODE { get; set; }
        public string LOG_PETCNAME { get; set; }
        public string LOG_RECEIVEDVIA { get; set; }
        public string LOG_RECEIVEDBY { get; set; }
        public Nullable<System.DateTime> LOG_TMERECEIVE { get; set; }
        public string LOG_DTLINQUIRY { get; set; }
        public Nullable<System.DateTime> LOG_TMECMPLTED { get; set; }
        public string LOG_ACTTAKEN { get; set; }
        public string LOG_REMARKS { get; set; }
        public string LOG_RESPONSE { get; set; }
        public Nullable<System.DateTime> LOG_ENCODED { get; set; }
        public Nullable<System.DateTime> LOG_DATELOG { get; set; }
        public string LOG_REGISTRYCODE { get; set; }
    }
}
