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
    
    public partial class tblProject
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int CustomerId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<bool> Continue { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> EnquiryId { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<int> QuotationId { get; set; }
    }
}
