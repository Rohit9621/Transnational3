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
    
    public partial class tblSupplierDocument
    {
        public int DocumentId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string FileName { get; set; }
        public string FileOrignalName { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string FileDescription { get; set; }
        public Nullable<int> FileTypeId { get; set; }
        public Nullable<int> UploadedBy { get; set; }
    }
}
