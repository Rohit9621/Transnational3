//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TokenAuthenticationInWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThoughtDay
    {
        public int ThODId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string ThODText { get; set; }
        public Nullable<System.DateTime> SubmittedDate { get; set; }
        public Nullable<System.DateTime> DisplayDate { get; set; }
        public Nullable<bool> PostToWeb { get; set; }
        public string QuotedBy { get; set; }
        public Nullable<System.DateTime> DisplayDateTo { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
