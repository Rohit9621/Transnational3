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
    
    public partial class tblInvoiceGift
    {
        public int IGiftId { get; set; }
        public string InvoiceId { get; set; }
        public Nullable<System.DateTime> GiftLetterSent { get; set; }
        public Nullable<System.DateTime> GiftCourier { get; set; }
        public Nullable<System.DateTime> GiftCollected { get; set; }
        public string OrderNo { get; set; }
    }
}
