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
    
    public partial class tblPromotion
    {
        public int PromotionId { get; set; }
        public string PromoationName { get; set; }
        public Nullable<System.DateTime> PromotionFromDate { get; set; }
        public Nullable<System.DateTime> PromotionToDate { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
