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
    
    public partial class tblSendEmailOrder
    {
        public int EmailOrderID { get; set; }
        public string ServiceID { get; set; }
        public string OrderID { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public Nullable<bool> IsEmail { get; set; }
        public string OrderStatus { get; set; }
    }
}
