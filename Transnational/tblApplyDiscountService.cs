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
    
    public partial class tblApplyDiscountService
    {
        public int DisServiceId { get; set; }
        public Nullable<int> ApplyDiscountId { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public string ADRate { get; set; }
        public string ADRateType { get; set; }
        public string ADdiscountId { get; set; }
        public Nullable<bool> Colection { get; set; }
        public Nullable<bool> Delivery { get; set; }
        public Nullable<System.DateTime> ADSCreatedDate { get; set; }
        public Nullable<System.DateTime> ADSUpdatedDate { get; set; }
        public Nullable<int> ADSCreatedBy { get; set; }
        public Nullable<int> ADSUpdatedBy { get; set; }
    }
}
