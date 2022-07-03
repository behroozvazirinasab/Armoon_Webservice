using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static ArmoonWebServiceSystem.Models.SearchPersondatamodel;

namespace ArmoonWebServiceSystem.Services
{
    public class SearchPersonService
    {
        private readonly SqlConnection connection;

        public SearchPersonService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            connection = new SqlConnection(connStr);
        }

        public List<SearchPersonReturnmodel> runSearchPersonsp(long Code, string Name, string Tel, string Address, Boolean Persons, Boolean Expence, Boolean Bank, Boolean Cash, Boolean Tuner, string PerType, string Mobile, string Fax, string EconomicCode, string NationalCode, string RegisterNo, string PostCode, string NationalNo, string Description, string ISActive, string FName, string LName)
        {
            var query = "sp_Insert_RecivePayment_FromXml";

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
                ISActive = ISActive,
                FName = FName,
                LName= LName,
            };
            var _res = connection.Query<SearchPersonReturnmodel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }
}