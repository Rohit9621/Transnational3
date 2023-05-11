﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        internal object aspnet;

        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCountry> tbCountries { get; set; }
        public virtual DbSet<tblActivity> tblActivities { get; set; }
        public virtual DbSet<tblActivityDocument> tblActivityDocuments { get; set; }
        public virtual DbSet<tblApplyDiscount> tblApplyDiscounts { get; set; }
        public virtual DbSet<tblApplyDiscountService> tblApplyDiscountServices { get; set; }
        public virtual DbSet<tblApplySurchargeHeader> tblApplySurchargeHeaders { get; set; }
        public virtual DbSet<tblApplySurHeaderDetail> tblApplySurHeaderDetails { get; set; }
        public virtual DbSet<tblAttachment> tblAttachments { get; set; }
        public virtual DbSet<tblbankbranch> tblbankbranches { get; set; }
        public virtual DbSet<tblBatch> tblBatches { get; set; }
        public virtual DbSet<tblBranch> tblBranches { get; set; }
        public virtual DbSet<tblBusinessUnitBranch> tblBusinessUnitBranches { get; set; }
        public virtual DbSet<tblBusinessUnitHoliday> tblBusinessUnitHolidays { get; set; }
        public virtual DbSet<tblBusinessUnitTiming> tblBusinessUnitTimings { get; set; }
        public virtual DbSet<tblCallBooking> tblCallBookings { get; set; }
        public virtual DbSet<tblCityMaster> tblCityMasters { get; set; }
        public virtual DbSet<tblCompany> tblCompanies { get; set; }
        public virtual DbSet<tblCompanyAccessRight> tblCompanyAccessRights { get; set; }
        public virtual DbSet<tblCompanyAddress> tblCompanyAddresses { get; set; }
        public virtual DbSet<tblCompanyAddressBook> tblCompanyAddressBooks { get; set; }
        public virtual DbSet<tblCompanyBranch> tblCompanyBranches { get; set; }
        public virtual DbSet<tblCompanyCompetitor> tblCompanyCompetitors { get; set; }
        public virtual DbSet<tblCompanyContactAddress> tblCompanyContactAddresses { get; set; }
        public virtual DbSet<tblCompanyDocument> tblCompanyDocuments { get; set; }
        public virtual DbSet<tblCompanyOEM> tblCompanyOEMs { get; set; }
        public virtual DbSet<tblCompanyPartner> tblCompanyPartners { get; set; }
        public virtual DbSet<tblCompanyProduct> tblCompanyProducts { get; set; }
        public virtual DbSet<tblCompanyProfile> tblCompanyProfiles { get; set; }
        public virtual DbSet<tblcontactaddress> tblcontactaddresses { get; set; }
        public virtual DbSet<tblContactBDayMsg> tblContactBDayMsgs { get; set; }
        public virtual DbSet<tblContactBranch> tblContactBranches { get; set; }
        public virtual DbSet<tblContactCategory> tblContactCategories { get; set; }
        public virtual DbSet<tblContactCategoryMaster> tblContactCategoryMasters { get; set; }
        public virtual DbSet<tblContactCostCentre> tblContactCostCentres { get; set; }
        public virtual DbSet<tblContactFixAddress> tblContactFixAddresses { get; set; }
        public virtual DbSet<tblContactOrderAccessRight> tblContactOrderAccessRights { get; set; }
        public virtual DbSet<tblContactParameterMaster> tblContactParameterMasters { get; set; }
        public virtual DbSet<tblContactParameter> tblContactParameters { get; set; }
        public virtual DbSet<tblContactRole> tblContactRoles { get; set; }
        public virtual DbSet<tblContact> tblContacts { get; set; }
        public virtual DbSet<tblContactType> tblContactTypes { get; set; }
        public virtual DbSet<tblContract> tblContracts { get; set; }
        public virtual DbSet<tblContractAccessRight> tblContractAccessRights { get; set; }
        public virtual DbSet<tblContractCostCentre> tblContractCostCentres { get; set; }
        public virtual DbSet<tblContractMService> tblContractMServices { get; set; }
        public virtual DbSet<tblContractServiceRateMatrix> tblContractServiceRateMatrices { get; set; }
        public virtual DbSet<tblContractService> tblContractServices { get; set; }
        public virtual DbSet<tblCostCenter> tblCostCenters { get; set; }
        public virtual DbSet<tblCreditTermMaster> tblCreditTermMasters { get; set; }
        public virtual DbSet<tblCSUserAccessRight> tblCSUserAccessRights { get; set; }
        public virtual DbSet<tblCurrency> tblCurrencies { get; set; }
        public virtual DbSet<tblCurrencyMaster> tblCurrencyMasters { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblCustomerBranchTiming> tblCustomerBranchTimings { get; set; }
        public virtual DbSet<tblCustomerCategoryMaster> tblCustomerCategoryMasters { get; set; }
        public virtual DbSet<tblCustomerHistory> tblCustomerHistories { get; set; }
        public virtual DbSet<tblCustomerHistoryExpens> tblCustomerHistoryExpenses { get; set; }
        public virtual DbSet<tblCustomerHistoryTeam> tblCustomerHistoryTeams { get; set; }
        public virtual DbSet<tblCustomerStatusMaster> tblCustomerStatusMasters { get; set; }
        public virtual DbSet<tblCustomerTiming> tblCustomerTimings { get; set; }
        public virtual DbSet<tblCustomerTypeMaster> tblCustomerTypeMasters { get; set; }
        public virtual DbSet<tblDeliveryTerm> tblDeliveryTerms { get; set; }
        public virtual DbSet<tblDemoGraphicalTag> tblDemoGraphicalTags { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblDesignation> tblDesignations { get; set; }
        public virtual DbSet<tblDictionary> tblDictionaries { get; set; }
        public virtual DbSet<tblDiscountmaster> tblDiscountmasters { get; set; }
        public virtual DbSet<tblDistrictPostalCode> tblDistrictPostalCodes { get; set; }
        public virtual DbSet<tblDocumentAccessRight> tblDocumentAccessRights { get; set; }
        public virtual DbSet<tblEnquiry> tblEnquiries { get; set; }
        public virtual DbSet<tblEnquirySourceMaster> tblEnquirySourceMasters { get; set; }
        public virtual DbSet<tblExchangeRateMaster> tblExchangeRateMasters { get; set; }
        public virtual DbSet<tblExpensesHeadMaster> tblExpensesHeadMasters { get; set; }
        public virtual DbSet<tblFileTypeMaster> tblFileTypeMasters { get; set; }
        public virtual DbSet<tblGroupMaster> tblGroupMasters { get; set; }
        public virtual DbSet<tblHelp> tblHelps { get; set; }
        public virtual DbSet<tblHelpSubject> tblHelpSubjects { get; set; }
        public virtual DbSet<tblHoliday> tblHolidays { get; set; }
        public virtual DbSet<tblHubmaster> tblHubmasters { get; set; }
        public virtual DbSet<tblIndustry> tblIndustries { get; set; }
        public virtual DbSet<tblIndustryApplication> tblIndustryApplications { get; set; }
        public virtual DbSet<tblIndustryMarketSegment> tblIndustryMarketSegments { get; set; }
        public virtual DbSet<tblInstallation> tblInstallations { get; set; }
        public virtual DbSet<tblInventoryPrice> tblInventoryPrices { get; set; }
        public virtual DbSet<tblInvoiceAddress> tblInvoiceAddresses { get; set; }
        public virtual DbSet<tblInvoiceAddressOrder> tblInvoiceAddressOrders { get; set; }
        public virtual DbSet<tblInvoiceDeliveryAddress> tblInvoiceDeliveryAddresses { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<tblInvoiceHeader> tblInvoiceHeaders { get; set; }
        public virtual DbSet<tblInvoiceHeadertemp> tblInvoiceHeadertemps { get; set; }
        public virtual DbSet<tblInvoiceHeaderTempDoc> tblInvoiceHeaderTempDocs { get; set; }
        public virtual DbSet<tblInvoiceSalesPerson> tblInvoiceSalesPersons { get; set; }
        public virtual DbSet<tblInvoiceSalesPersonTeam> tblInvoiceSalesPersonTeams { get; set; }
        public virtual DbSet<tblInvoiceSource> tblInvoiceSources { get; set; }
        public virtual DbSet<tblIPaymentDetail> tblIPaymentDetails { get; set; }
        public virtual DbSet<tblIssue> tblIssues { get; set; }
        public virtual DbSet<tblJobFunctionKRA> tblJobFunctionKRAs { get; set; }
        public virtual DbSet<tblKRAMaster> tblKRAMasters { get; set; }
        public virtual DbSet<tblMaintenace> tblMaintenaces { get; set; }
        public virtual DbSet<tblMarketSegment> tblMarketSegments { get; set; }
        public virtual DbSet<tblMassEmail> tblMassEmails { get; set; }
        public virtual DbSet<tblMasterApplication> tblMasterApplications { get; set; }
        public virtual DbSet<tblMiscellaneou> tblMiscellaneous { get; set; }
        public virtual DbSet<tblMiscellaneousOrder> tblMiscellaneousOrders { get; set; }
        public virtual DbSet<tblMLevel> tblMLevels { get; set; }
        public virtual DbSet<tblMonthlyTarget> tblMonthlyTargets { get; set; }
        public virtual DbSet<tblMRateMatrix> tblMRateMatrices { get; set; }
        public virtual DbSet<tblNode> tblNodes { get; set; }
        public virtual DbSet<tblNodeGroup> tblNodeGroups { get; set; }
        public virtual DbSet<tblNodesAccess> tblNodesAccesses { get; set; }
        public virtual DbSet<tblOrderConfirm> tblOrderConfirms { get; set; }
        public virtual DbSet<tblOrderDiscount> tblOrderDiscounts { get; set; }
        public virtual DbSet<tblOrderEmail> tblOrderEmails { get; set; }
        public virtual DbSet<tblOrderMaster> tblOrderMasters { get; set; }
        public virtual DbSet<tblOrderpackageContent> tblOrderpackageContents { get; set; }
        public virtual DbSet<tblOrderSM> tblOrderSMS { get; set; }
        public virtual DbSet<tblOrderStatu> tblOrderStatus { get; set; }
        public virtual DbSet<tblorderSurcharge> tblorderSurcharges { get; set; }
        public virtual DbSet<tblOrderTracking> tblOrderTrackings { get; set; }
        public virtual DbSet<tblOrderType> tblOrderTypes { get; set; }
        public virtual DbSet<tblOrdType> tblOrdTypes { get; set; }
        public virtual DbSet<tblOrganisationTree> tblOrganisationTrees { get; set; }
        public virtual DbSet<tblPartsUsed> tblPartsUseds { get; set; }
        public virtual DbSet<tblPasswordChangeAuditLog> tblPasswordChangeAuditLogs { get; set; }
        public virtual DbSet<tblPasswordSetting> tblPasswordSettings { get; set; }
        public virtual DbSet<tblPaymentDetail> tblPaymentDetails { get; set; }
        public virtual DbSet<tblPaymentMode> tblPaymentModes { get; set; }
        public virtual DbSet<tblPaymentSubMode> tblPaymentSubModes { get; set; }
        public virtual DbSet<tblPotentiality> tblPotentialities { get; set; }
        public virtual DbSet<tblPriceTypeMaster> tblPriceTypeMasters { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductEnquiry> tblProductEnquiries { get; set; }
        public virtual DbSet<tblProductLedger> tblProductLedgers { get; set; }
        public virtual DbSet<tblProductMonthlyTarget> tblProductMonthlyTargets { get; set; }
        public virtual DbSet<tblProductMonthlyTargetCustomer> tblProductMonthlyTargetCustomers { get; set; }
        public virtual DbSet<tblProductMonthlyTargetList> tblProductMonthlyTargetLists { get; set; }
        public virtual DbSet<tblProductPicture> tblProductPictures { get; set; }
        public virtual DbSet<tblProductPrice> tblProductPrices { get; set; }
        public virtual DbSet<tblproductpriceFlag> tblproductpriceFlags { get; set; }
        public virtual DbSet<tblProductStatu> tblProductStatus { get; set; }
        public virtual DbSet<tblProductTree> tblProductTrees { get; set; }
        public virtual DbSet<tblProductTypeMaster> tblProductTypeMasters { get; set; }
        public virtual DbSet<tblProject> tblProjects { get; set; }
        public virtual DbSet<tblPromotion> tblPromotions { get; set; }
        public virtual DbSet<tblPromotionUpload> tblPromotionUploads { get; set; }
        public virtual DbSet<tblQuantityUom> tblQuantityUoms { get; set; }
        public virtual DbSet<tblQuotationDetail> tblQuotationDetails { get; set; }
        public virtual DbSet<tblQuotationHeader> tblQuotationHeaders { get; set; }
        public virtual DbSet<tblRaceMaster> tblRaceMasters { get; set; }
        public virtual DbSet<tblRegionMaster> tblRegionMasters { get; set; }
        public virtual DbSet<tblReligionMaster> tblReligionMasters { get; set; }
        public virtual DbSet<tblRenewalList> tblRenewalLists { get; set; }
        public virtual DbSet<tblReport> tblReports { get; set; }
        public virtual DbSet<tblReportAccessRight> tblReportAccessRights { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblRole1> tblRoles1 { get; set; }
        public virtual DbSet<tblSalesCycleMaster> tblSalesCycleMasters { get; set; }
        public virtual DbSet<tblSalesPersonBalance> tblSalesPersonBalances { get; set; }
        public virtual DbSet<tblSalesPersonBalanceDetail> tblSalesPersonBalanceDetails { get; set; }
        public virtual DbSet<tblSendEmailOrder> tblSendEmailOrders { get; set; }
        public virtual DbSet<tblSpecialCode1> tblSpecialCode1 { get; set; }
        public virtual DbSet<tblSpecialCode2> tblSpecialCode2 { get; set; }
        public virtual DbSet<tblStateMaster> tblStateMasters { get; set; }
        public virtual DbSet<tblStateMasterNew> tblStateMasterNews { get; set; }
        public virtual DbSet<tblStockIN> tblStockINs { get; set; }
        public virtual DbSet<tblStockLedger> tblStockLedgers { get; set; }
        public virtual DbSet<tblStrength> tblStrengths { get; set; }
        public virtual DbSet<tblSupplier> tblSuppliers { get; set; }
        public virtual DbSet<tblSupplierAddress> tblSupplierAddresses { get; set; }
        public virtual DbSet<tblSupplierContactParameter> tblSupplierContactParameters { get; set; }
        public virtual DbSet<tblSupplierContact> tblSupplierContacts { get; set; }
        public virtual DbSet<tblSupplierDocument> tblSupplierDocuments { get; set; }
        public virtual DbSet<tblSupplierHistory> tblSupplierHistories { get; set; }
        public virtual DbSet<tblSupplierHistoryExpens> tblSupplierHistoryExpenses { get; set; }
        public virtual DbSet<tblSupplierHistoryTeam> tblSupplierHistoryTeams { get; set; }
        public virtual DbSet<tblSupplierOEM> tblSupplierOEMs { get; set; }
        public virtual DbSet<tblSupplierPartner> tblSupplierPartners { get; set; }
        public virtual DbSet<tblSupplierProduct> tblSupplierProducts { get; set; }
        public virtual DbSet<tblSupplierTypeMaster> tblSupplierTypeMasters { get; set; }
        public virtual DbSet<tblSurchargeitem> tblSurchargeitems { get; set; }
        public virtual DbSet<tblSurchargeMaster> tblSurchargeMasters { get; set; }
        public virtual DbSet<tblTaskGroup> tblTaskGroups { get; set; }
        public virtual DbSet<tblTaskPriority> tblTaskPriorities { get; set; }
        public virtual DbSet<tblTask> tblTasks { get; set; }
        public virtual DbSet<tblTasksAssignedTo> tblTasksAssignedToes { get; set; }
        public virtual DbSet<tblTaxMaster> tblTaxMasters { get; set; }
        public virtual DbSet<tblTechnologyMaster> tblTechnologyMasters { get; set; }
        public virtual DbSet<tblTerm> tblTerms { get; set; }
        public virtual DbSet<tblTermConditionsDetail> tblTermConditionsDetails { get; set; }
        public virtual DbSet<tblTermConditionsHeader> tblTermConditionsHeaders { get; set; }
        public virtual DbSet<tblTiming> tblTimings { get; set; }
        public virtual DbSet<tblTree> tblTrees { get; set; }
        public virtual DbSet<tblTypeMaster> tblTypeMasters { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserAccess> tblUserAccesses { get; set; }
        public virtual DbSet<tblUserCategory> tblUserCategories { get; set; }
        public virtual DbSet<tblUserDepartment> tblUserDepartments { get; set; }
        public virtual DbSet<tblUserKRAObjective> tblUserKRAObjectives { get; set; }
        public virtual DbSet<tblUserType> tblUserTypes { get; set; }
        public virtual DbSet<tblUserTypeNodesAccess> tblUserTypeNodesAccesses { get; set; }
        public virtual DbSet<tblweekMaster> tblweekMasters { get; set; }
        public virtual DbSet<tblWindowPeriod> tblWindowPeriods { get; set; }
        public virtual DbSet<tblWindowPeriodProduct> tblWindowPeriodProducts { get; set; }
        public virtual DbSet<tblZoneMaster> tblZoneMasters { get; set; }
        public virtual DbSet<ThoughtDay> ThoughtDays { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<dbo_tblDemoGraphicalTag> dbo_tblDemoGraphicalTag { get; set; }
        public virtual DbSet<Paste_Error> Paste_Errors { get; set; }
        public virtual DbSet<tbCMember> tbCMembers { get; set; }
        public virtual DbSet<tblActivityComment> tblActivityComments { get; set; }
        public virtual DbSet<tblBankMaster> tblBankMasters { get; set; }
        public virtual DbSet<tblCallAttendedDate> tblCallAttendedDates { get; set; }
        public virtual DbSet<tblCart> tblCarts { get; set; }
        public virtual DbSet<tblCompanyAddress2> tblCompanyAddress2 { get; set; }
        public virtual DbSet<tblCompanyApplication> tblCompanyApplications { get; set; }
        public virtual DbSet<tblCompanyGroup> tblCompanyGroups { get; set; }
        public virtual DbSet<tblCompanyImported> tblCompanyImporteds { get; set; }
        public virtual DbSet<tblCompanyIndustry> tblCompanyIndustries { get; set; }
        public virtual DbSet<tblCompanyMarketSegment> tblCompanyMarketSegments { get; set; }
        public virtual DbSet<tblCustomerHistoryCustomerContact> tblCustomerHistoryCustomerContacts { get; set; }
        public virtual DbSet<tblDepartmentJobFunction> tblDepartmentJobFunctions { get; set; }
        public virtual DbSet<tblEmployeeGroup> tblEmployeeGroups { get; set; }
        public virtual DbSet<tblEnquiryTechnology> tblEnquiryTechnologies { get; set; }
        public virtual DbSet<tblHelpTip> tblHelpTips { get; set; }
        public virtual DbSet<tblInvoiceGift> tblInvoiceGifts { get; set; }
        public virtual DbSet<tblIPublisherRequirement> tblIPublisherRequirements { get; set; }
        public virtual DbSet<tblLevel> tblLevels { get; set; }
        public virtual DbSet<tblLevels1> tblLevels1 { get; set; }
        public virtual DbSet<tblMarketSegment1> tblMarketSegment1 { get; set; }
        public virtual DbSet<tblMarketSegment2> tblMarketSegment2 { get; set; }
        public virtual DbSet<tblMarketSegment3> tblMarketSegment3 { get; set; }
        public virtual DbSet<tblNationalServiceMaster> tblNationalServiceMasters { get; set; }
        public virtual DbSet<tblProductClassification> tblProductClassifications { get; set; }
        public virtual DbSet<tblProductTree1> tblProductTree1 { get; set; }
        public virtual DbSet<tblProjects1> tblProjects1 { get; set; }
        public virtual DbSet<tblPromotion2> tblPromotion2 { get; set; }
        public virtual DbSet<tblReceivedBook> tblReceivedBooks { get; set; }
        public virtual DbSet<tblReceivedVoid> tblReceivedVoids { get; set; }
        public virtual DbSet<tblSupplierApplication> tblSupplierApplications { get; set; }
        public virtual DbSet<tblSupplierContactCategory> tblSupplierContactCategories { get; set; }
        public virtual DbSet<tblSupplierHistorySupplierContact> tblSupplierHistorySupplierContacts { get; set; }
        public virtual DbSet<tblSupplierIndustry> tblSupplierIndustries { get; set; }
        public virtual DbSet<tblSupplierMarketSegment> tblSupplierMarketSegments { get; set; }
        public virtual DbSet<tblTaskG> tblTaskGs { get; set; }
        public virtual DbSet<tblTaskHistory> tblTaskHistories { get; set; }
        public virtual DbSet<tblTimeSheet> tblTimeSheets { get; set; }
        public virtual DbSet<tblUserKRA> tblUserKRAs { get; set; }
        public virtual DbSet<tblUserStrength> tblUserStrengths { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }
    }
}
