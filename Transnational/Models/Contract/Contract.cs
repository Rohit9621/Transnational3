﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transnational.Models
{
    public class Contracts
    {
        public int ContractId { get; set; }
        public int CompanyId { get; set; }
        public int ContactId { get; set; }
        public string ContractNo { get; set; }
        public string BillingCycle { get; set; }
        public string Address1 { get; set; }
        public string ATendorNo { get; set; }
        public Nullable<int> MainBusId { get; set; }
        public Nullable<int> SubBusId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string FreezeDetails { get; set; }
        public Nullable<int> PTermId { get; set; }
        public Nullable<int> DTermId { get; set; }
        public Nullable<int> TaxId { get; set; }
        public Nullable<double> MinChargeAmount { get; set; }
        public Nullable<int> MinOrderQty { get; set; }
        public Nullable<int> MaxOrderQty { get; set; }
        public Nullable<double> FMonthlyFee { get; set; }
        public string FileOriginalName { get; set; }
        public string FileNewName { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LUDate { get; set; }
        public Nullable<int> LUBy { get; set; }
        public string BillTo { get; set; }
        public Nullable<int> MaxContacts { get; set; }
        public string ContractDescription { get; set; }
        public Nullable<int> ApprovalLevel { get; set; }
        public string CreatedByType { get; set; }
        public string UpdatedByType { get; set; }
        public string BillingName { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> BillingCountry { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<bool> EstimatedCost { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public Nullable<double> Credit { get; set; }
        public Nullable<double> Deposit { get; set; }
        public string ContractRef { get; set; }
        public string ContractStatus { get; set; }
        public Nullable<bool> Invoice_Rounding { get; set; }
        public Nullable<bool> Surcharge_Contract { get; set; }
        public Nullable<bool> Rate_Comparison { get; set; }
        public Nullable<bool> Discount_Contract { get; set; }
        public Nullable<bool> SConfirm { get; set; }
        public Nullable<bool> CWindowPeriod { get; set; }
       


    }

    public class  GetContractBillingDetails
    {
        public string CD { get; set; }
        public int CompanyId { get; set; }
        public int ContactId { get; set; }
      



    }
}