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
    
    public partial class tblCompanyAccessRight
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public Nullable<bool> Read { get; set; }
        public Nullable<bool> Write { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
