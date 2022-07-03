using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmoonWebServiceSystem.Models
{
    public class Persondatamodel
    {
        public class SearchPersonmodel
        {
            public long? Code { get; set; }
            public string Name { get; set; }
            public string Tel { get; set; }
            public string Address { get; set; }
            public Boolean? Persons { get; set; }
            public Boolean? Expence { get; set; }
            public Boolean? Bank { get; set; }
            public Boolean? Cash { get; set; }
            public Boolean? Tuner { get; set; }
            public long? PerType { get; set; }
            public string Mobile { get; set; }
            public string Fax { get; set; }
            public string EconomicCode { get; set; }
            public string NationalCode { get; set; }
            public string RegisterNo { get; set; }
            public string PostCode { get; set; }
            public string NationalNo { get; set; }
            public string Description { get; set; }
            public string ISActive { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
        }



        public class InsertPersonmodel
        {
            public long? Code { get; set; }
            public string Name { get; set; }
            public string Tel { get; set; }
            public string Address { get; set; }
            public Boolean? Persons { get; set; }
            public Boolean? Expence { get; set; }
            public Boolean? Bank { get; set; }
            public Boolean? Cash { get; set; }
            public Boolean? Tuner { get; set; }
            public long? PerType { get; set; }
            public string KlCodeRef { get; set; }
            public string MnCodeRef { get; set; }
            public string Mobile { get; set; }
            public string Fax { get; set; }
            public string EconomicCode { get; set; }
            public string NationalCode { get; set; }
            public string RegisterNo { get; set; }
            public string PostCode { get; set; }
            public string NationalNo { get; set; }
            public string Email { get; set; }
            public string Description { get; set; }
            public string GoodRequest { get; set; }
            public string Addres2 { get; set; }
            public string Tel2 { get; set; }
            public string Mobile2 { get; set; }
            public string Email2 { get; set; }
            public string KlCashCodeRef { get; set; }
            public string MnCashCodeRef { get; set; }
            public string KlBankCodeRef { get; set; }
            public string MnBankCodeRef { get; set; }
            public string KlPayCodeRef { get; set; }
            public string MnPayCodeRef { get; set; }
            public string Craft { get; set; }
            public long? StateIdRef { get; set; }
            public long? CityIdRef { get; set; }
            public long? VisitorCodeRef { get; set; }
            public long? ActualType { get; set; }
            public long? TransactionTaxType { get; set; }
            public long? RateDefualt { get; set; }
            public string BranchName { get; set; }
            public string AccountType { get; set; }
            public string AccountOwner { get; set; }
            public string ShebaNo { get; set; }
            public string CardNo { get; set; }
            public string BranchTel { get; set; }
            public string BranchFax { get; set; }
            public string AccountNo { get; set; }
            public Boolean? IsActive { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public Boolean? CalcTax { get; set; }
        }



        public class ResponseModel
        {
            public long? ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }



        public class ResponseModelSearch
        {
            public long? Code { get; set; }
            public string Name { get; set; }
            public string Tel { get; set; }
            public string Address { get; set; }
            public string Acount { get; set; }
            public string KlName { get; set; }
            public string MnName { get; set; }
            public string PerTyoe { get; set; }
            public string Mobile { get; set; }
            public string Fax { get; set; }
            public string EconomicCode { get; set; }
            public string NationalCode { get; set; }
            public string RegisterNo { get; set; }
            public string PostCode { get; set; }
            public string NationalNo { get; set; }
            public string Email { get; set; }
            public string Description { get; set; }
            public string GoodRequest { get; set; }
            public string Address2 { get; set; }
            public string Tel2 { get; set; }
            public string Mobile2 { get; set; }
            public string Email2 { get; set; }
            public string KlCashName { get; set; }
            public string KlBank { get; set; }
            public string MnBank { get; set; }
            public string KlPay { get; set; }
            public string MnPay { get; set; }
            public string Craft { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Visitor { get; set; }
            public string ActualType { get; set; }
            public string TransactionTaxType { get; set; }
            public string RateDefualt { get; set; }
            public string BranchName { get; set; }
            public string AcoountType { get; set; }
            public string AccountOwner { get; set; }
            public string ShebaNo { get; set; }
            public string CardNo { get; set; }
            public string BranchTel { get; set; }
            public string BranchFax { get; set; }
            public string AccountNo { get; set; }
            public string ISActive { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
        }
    }
}