using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArmoonWebServiceSystem.Models;
using ArmoonWebServiceSystem.Services;
using System.Threading.Tasks;
using Dapper;
using static ArmoonWebServiceSystem.Models.Persondatamodel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace ArmoonWebServiceSystem.Services
{
    ///Person Service
    public class PersonService 
    {

        private readonly SqlConnection connection;

        public PersonService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            connection = new SqlConnection(connStr);
        }



        /// service insert person
        public List<ResponseModel> runInsertPersonsp(long? Code, string Name, string Tel, string Address, Boolean? Persons, Boolean? Expence, Boolean? Bank, Boolean? Cash, Boolean? Tuner, long? PerType, string KlCodeRef, string MnCodeRef, string Mobile, string Fax, string EconomicCode, string NationalCode, string RegisterNo, string PostCode, string NationalNo, string Email, string Description, string GoodRequest, string Addres2, string Tel2, string Mobile2, string Email2, string KlCashCodeRef, string MnCashCodeRef, string KlBankCodeRef, string MnBankCodeRef, string KlPayCodeRef, string MnPayCodeRef, string Craft, long? StateIdRef, long? CityIdRef, long? VisitorCodeRef, long? ActualType, long? TransactionTaxType, long? RateDefualt, string BranchName, string AccountType, string AccountOwner, string ShebaNo, string CardNo, string BranchTel, string BranchFax, string AccountNo, Boolean? IsActive, string FName, string LName, Boolean? CalcTax)
        {

            var query = "InsertPerson";

            var queryparams = new
            {
                Code = Code,
                Name = Name,
                Tel = Tel,
                Address = Address,
                Persons = Persons,
                Expence = Expence,
                Bank = Bank,
                Cash = Cash,
                Tuner = Tuner,
                KlCodeRef = KlCodeRef,
                MnCodeRef = MnCodeRef,
                PerType = PerType,
                Mobile = Mobile,
                Fax = Fax,
                EconomicCode = EconomicCode,
                NationalCode = NationalCode,
                RegisterNo = RegisterNo,
                PostCode = PostCode,
                NationalNo = NationalNo,
                Email = Email,
                Description = Description,
                GoodRequest = GoodRequest,
                Address2 = Addres2,
                Tel2 = Tel2,
                Mobile2 = Mobile2,
                Email2 = Email2,
                KlCashCodeRef = KlCashCodeRef,
                MnCashCodeRef = MnCashCodeRef,
                KlBankCodeRef = KlBankCodeRef,
                MnBankCodeRef = MnBankCodeRef,
                KlPayCodeRef = KlPayCodeRef,
                MnPayCodeRef = MnPayCodeRef,
                Craft = Craft,
                StateIdRef = StateIdRef,
                CityIdRef = CityIdRef,
                VisitorCodeRef = VisitorCodeRef,
                ActualType = ActualType,
                TransactionTaxType = TransactionTaxType,
                RateDefualt = RateDefualt,
                BranchName = BranchName,
                AccountType = AccountType,
                AccountOwner = AccountOwner,
                ShebaNo = ShebaNo,
                CardNo = CardNo,
                BranchTel = BranchTel,
                BranchFax = BranchFax,
                AccountNo = AccountNo,
                IsActive = IsActive,
                FName = FName,
                LName = LName,
                CalcTax = CalcTax

            };

            var _res = connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }



        /// service search person
        public List<ResponseModelSearch> runSearchPersonsp(long? Code, string Name, string Tel, string Address, Boolean? Persons, Boolean? Expence, Boolean? Bank, Boolean? Cash, Boolean? Tuner, long? PerType, string Mobile, string Fax, string EconomicCode, string NationalCode, string RegisterNo, string PostCode, string NationalNo, string Description, string ISActive, string FName, string LName)
        {

            var query = "SearchPerson";

            var queryparams = new
            {
                Code = Code,
                Name = Name,
                Tel = Tel,
                Address = Address,
                Persons = Persons,
                Expence = Expence,
                Bank = Bank,
                Cash = Cash,
                Tuner = Tuner,
                PerType = PerType,
                Mobile = Mobile,
                Fax = Fax,
                EconomicCode = EconomicCode,
                NationalCode = NationalCode,
                RegisterNo = RegisterNo,
                PostCode = PostCode,
                NationalNo = NationalNo,
                Description = Description,
                IsActive = ISActive,
                FName = FName,
                LName = LName

            };

            var _res = connection.Query<ResponseModelSearch>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }


    }



    
}