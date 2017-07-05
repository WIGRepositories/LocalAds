using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PakkaLocalAdsPortal.Models
{


    public class questions
    {
        public string flag { get; set; }
        public int id { get; set; }
        public string question { get; set; }

        public string option1 { get; set; }

        public string option2 { get; set; }

        public string option3 { get; set; }

        public string option4 { get; set; }
        public int locationId { get; set; }
        public int contestId { get; set; }
        public string answer { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

        public class contest
        {
            public string flag { get; set; }
            public int id { get; set; }
            public int qid { get; set; }
            public int locationid { get; set; }
            public string week { get; set; }
            public string fromdate { get; set; }
            public string todate { get; set; }
            public string month { get; set; }


        }
        public class ans
        {
            public string flag { get; set; }
            public int id { get; set; }
            public int qid { get; set; }
            public string answer { get; set; }
        }
        public class part
        {
            public string flag { get; set; }
            public int id { get; set; }
            public string firstname { get; set; }
            public string middlename { get; set; }
            public string lastname { get; set; }
            public string mobileno { get; set; }
            public string alternateno { get; set; }
            public string emailid { get; set; }
            public string address { get; set; }


        }
        public class winn
        {
            public string flag { get; set; }
            public int id { get; set; }
            public int pid { get; set; }
            public int cid { get; set; }
        }
        public class img
        {
            public string flag { get; set; }
            public int id { get; set; }
            public string FileContent { get; set; }
            public string imagename { get; set; }
            public string createdon { get; set; }
            public string date { get; set; }
            public int locationid { get; set; }
            public string description { get; set; }                  
        }
        public class child
        {
            public string flag { get; set; }
            public int id { get; set; }
            public string FileContent { get; set; }
            public int imgid { get; set; }
            public string imgname { get; set; }
            public string createdon { get; set; }
            public string date { get; set; }
            public int locationid { get; set; }
            public string description { get; set; }

        }
        public class location
        {
            public string flag { get; set; }
            public int id { get; set; }
            public string locationname { get; set; }

            public string description { get; set; }
        }
        public class panswer
        {
            public string flag { get; set; }
            public int id { get; set; }
            public int pid { get; set; }
            public int qid { get; set; }
            public string answer { get; set; }
        }
        public class user1
        {
            public string flag { get; set; }
            public int id { get; set; }
            public string firstname { get; set; }
            public string middlename { get; set; }
            public string lastname { get; set; }
            public int eid { get; set; }
            public string mobileno { get; set; }
            public string emailid { get; set; }
            public string address { get; set; }

        }
        public class userrole1
        {
            public string flag { get; set; }
            public int id { get; set; }
            public int userid { get; set; }
            public int roleid { get; set; }
        }
        public class TypeGroups
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Active { get; set; }
            public string insupddelflag { get; set; }
        }
        public class roles
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Active { get; set; }
            public string IsGlobal { get; set; }
            public string Company { get; set; }
            public int CompanyId { get; set; }
            public string insupddelflag { get; set; }
        }
        public class userroles
        {
            public int Id { set; get; }
            public int UserId { set; get; }
            public int? LocationId { set; get; }
            public int RoleId { set; get; }
            public string insupdflag { set; get; }

        }
        public class Location
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Active { get; set; }
            public string insupddelflag { get; set; }

        }
        public class Types
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Active { get; set; }



            public string TypeGroupId { get; set; }

            public string ListKey { get; set; }

            public string Listvalue { get; set; }
            public string insupddelflag { get; set; }
        }


        public class Users
        {
            public int Id { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string MiddleName { set; get; }
            public string UserName { set; get; }
            public string EmpNo { set; get; }
            public string Email { set; get; }
            public string ContactNo1 { set; get; }
            public string ContactNo2 { set; get; }
            public int? mgrId { set; get; }
            public int ManagerName { set; get; }
            public string Country { get; set; }
            public string ZipCode { get; set; }
            public string State { get; set; }
            public int StateId { set; get; }
            public int CountryId { set; get; }
            public int Active { get; set; }
            public int GenderId { get; set; }
            public string UserType { set; get; }
            public int UserTypeId { set; get; }
            public string Address { set; get; }
            public string AltAdress { set; get; }
            public string Photo { get; set; }
            public string Role { set; get; }
            public int RoleId { set; get; }
            public DateTime? RFromDate { get; set; }
            public DateTime? RToDate { get; set; }
            public string DUserName { get; set; }
            public string DPassword { get; set; }
            public string WUserName { get; set; }
            public string WPassword { get; set; }
            public string insupdflag { get; set; }
            public int companyId { set; get; }
            public string Company { set; get; }

        }

       
        public class reset
        {

            public string UserName { set; get; }
            public string OldPassword { set; get; }
            public string NewPassword { set; get; }
            public string ReenterNewPassword { set; get; }

        }

        public class Payment
        {
            public int Id { set; get; }
            public int PaymentTypeId { set; get; }
            public int Amount { set; get; }
            public DateTime date { set; get; }
            public int TransactionId { set; get; }
        }

        public class PaymentGatewaySettings
        {
            public int Id { get; set; }
            public DateTime enddate { get; set; }

            public string hashkey { get; set; }

            public string ClientId { get; set; }

            public string secretId { get; set; }

            public int PaymentGatewayTypeId { get; set; }

            public string providername { get; set; }

            public string pwd { get; set; }

            public string saltkey { get; set; }

            public DateTime startdate { get; set; }

            public string username { get; set; }
            public string insupdflag { get; set; }

        }
        public class Paymentgateway
        {

            public int Id { get; set; }
            public string ProviderName { get; set; }
            public string BTPOSGRPID { get; set; }
            public string Active { get; set; }
            public int UserId { get; set; }
            public string Passkey { get; set; }
            public string Url { get; set; }
            public string Testurl { get; set; }
            public string Salt { get; set; }
            public string Hash { get; set; }


        }
        public class Transactions
        {
            public int Id { get; set; }

            public string barcode { get; set; }

            public string BTPOSid { get; set; }

            public string busNumber { get; set; }

            public int busId { get; set; }

            public string change { get; set; }

            public string company { get; set; }

            public string companyId { get; set; }

            public string ConductorId { get; set; }

            public string ConductorName { get; set; }

            public DateTime Date { get; set; }

            public string destination { get; set; }

            public string fare { get; set; }

            public string greetingMessage { get; set; }

            public string luggageType { get; set; }

            public string passengerType { get; set; }

            public string passengerId { get; set; }

            public string paymentId { get; set; }

            public string printdataId { get; set; }

            public string route { get; set; }

            public string routecode { get; set; }

            public string routeId { get; set; }

            public string source { get; set; }

            public DateTime time { get; set; }

            public string ticketHolderId { get; set; }

            public string ticketHolderName { get; set; }

            public string TicketNumber { get; set; }

            public string ticketValidityPeriod { get; set; }

            public int totalamount { get; set; }

            public int amountpaid { get; set; }

            public string TransactionCode { get; set; }

            public string TransactionId { get; set; }

            public string transactionType { get; set; }

            public int userid { get; set; }

            public string ChangeRendered { get; set; }

        }
        public class LicensePricing
        {
            public int LicenseId { get; set; }
            public String RenewalFreqType { get; set; }
            public int RenewalFreqTypeId { get; set; }
            public int RenewalFreqUnit { get; set; }
            public string RenewalFreq { get; set; }
            public decimal UnitPrice { get; set; }
            public DateTime? fromdate { get; set; }
            public DateTime? todate { get; set; }
            public int Id { get; set; }

            public int categoryid { get; set; }
            public int Active { get; set; }
            public string insupddelflag { get; set; }
        }
        public class LicenseTypes
        {
            public int Id { set; get; }
            public string LicenseType { set; get; }
            public string LicenseCode { set; get; }
            public int LicenseCategoryId { set; get; }
            public int Active { set; get; }
            public string Desc { set; get; }
            public string LicenseCategory { set; get; }
            public DateTime? fromDate { get; set; }
            public DateTime? toDate { get; set; }
            public int LicenseId { get; set; }
            public int LicensePricingId { get; set; }
            public String RenewalFreqType { get; set; }
            public int RenewalFreqTypeId { get; set; }
            public int RenewalFreqUnit { get; set; }
            public string RenewalFreq { get; set; }
            public decimal UnitPrice { get; set; }
            public DateTime? Pfromdate { get; set; }
            public DateTime? Ptodate { get; set; }

            public int PActive { get; set; }
            public string insupddelflag { get; set; }

            //license pos      
            public int LPOSId { get; set; }
            public int BTPOSTypeId { get; set; }
            public int NoOfUnits { get; set; }
            public string POSType { get; set; }
            public String POSLabel { get; set; }
            public String POSLabelClass { get; set; }
            public DateTime? POSfromdate { get; set; }
            public DateTime? POStodate { get; set; }
            public int POSActive { get; set; }

            public List<LicenseDetails> licenseDetails { get; set; }
        }

        public class LicenseTypes1
        {
            // public List<licenses> lltypes { get; set; }
            public int Id { set; get; }
            public int Active { set; get; }
            public string LicenseType { set; get; }
            public string Desc { set; get; }
            public string LicenseCategory { set; get; }
            public int LicenseCategoryId { set; get; }
            public int LicenseId { set; get; }
            public int RenewalFreqTypeId { set; get; }

            public int RenewalFreq { set; get; }
            public Decimal UnitPrice { set; get; }
            public DateTime fromdate { set; get; }

            public DateTime todate { set; get; }

            public char insupddelflag { set; get; }
            public string FeatureName { set; get; }
            public string FeatureLabel { set; get; }
            public string FeatureValue { set; get; }
        }
        public class licenses
        {
            public int LicenseId { set; get; }
            public int RenewalFreqTypeId { set; get; }

            public int RenewalFreq { set; get; }
            public Decimal UnitPrice { set; get; }
            public DateTime fromdate { set; get; }

            public DateTime todate { set; get; }

            public char insupddelflag { set; get; }
            public string Featurename { set; get; }
            public string Featurelabel { set; get; }
            public string Featurevalue { set; get; }
        }
        public class LicenseDetails
        {
            public int Id { get; set; }
            public int LicenseTypeId { get; set; }
            public int LicenseCatId { get; set; }
            public int FeatureTypeId { get; set; }
            public string FeatureName { get; set; }
            public String FeatureLabel { get; set; }
            public String LicenseCode { get; set; }
            public String LicenseName { get; set; }
            public String FeatureValue { get; set; }
            public String LabelClass { get; set; }
            public int Active { get; set; }
            public DateTime? fromDate { get; set; }
            public DateTime? toDate { get; set; }
            public string insupddelflag { get; set; }
            public int LicenseTypeGroupId { get; set; }
        }
        public class UserLogin
        {
            public int Id { set; get; }
            public int UserId { set; get; }
            public string LoginInfo { set; get; }
            public string Passkey { set; get; }
            public string Salt { set; get; }
            public string Active { set; get; }

        }
        public class faqs
        {

            public string flag { get; set; }
            public int id { get; set; }
            public string question { get; set; }

            public string answer { get; set; }
            public string createdon { get; set; }
            public string createdby { get; set; }
            public string updatedon { get; set; }
            public string updatedby { get; set; }
            public int active { get; set; }
            public int category { get; set; }

        }
        public class ObjectTypes
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Active { get; set; }
            public string insupddelflag { get; set; }
            public int DataTypeId { get; set; }

        }

        public class Document
        {
            public int ID { get; set; }
            public int createdById { get; set; }
            public int UpdatedById { get; set; }
            public DateTime? createdDT { get; set; }
            public DateTime? UpdatedDT { get; set; }
            public int docCatId { get; set; }
            public int docTypeId { get; set; }
            public string docType { get; set; }
            public string FileName { get; set; }
            public int IsExpired { get; set; }
            public string FileContent { get; set; }
            public int LocationId { get; set; }
            public DateTime? exipryDate { get; set; }
            public DateTime? effectiveDate { get; set; } 
            public string insupddelflag { get; set; }
            public string Description { get; set; }
        }

        public class preview
        {
            public string flag { get; set; }
            public int Id { get; set;}
            
            public string x1 { get; set;}
            public string x2 { get; set; } 
            public string y1 { get; set; } 
            public string y2 { get; set; }

            public string width { get; set;}
            public string height { get; set;}

        }
}


