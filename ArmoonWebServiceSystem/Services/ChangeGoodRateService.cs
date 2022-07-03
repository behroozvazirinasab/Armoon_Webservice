using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static ArmoonWebServiceSystem.Models.ChangeGoodRateModel;

namespace ArmoonWebServiceSystem.Services
{
    public class ChangeGoodRateService
    {
        private readonly SqlConnection connection;

        public ChangeGoodRateService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            connection = new SqlConnection(connStr);
        }

        public List<ResponseModel> runChangeGoodRatesp(string GoodCode, long? StorageCode, decimal? FiPrice1, decimal? OffPercent1, decimal? FiPrice2, decimal? OffPercent2, decimal? FiPrice3, decimal? OffPercent3, long? UserIdRef)
        {

            var query = "SP_ChangeGoodRate";

            var queryparams = new
            {
                GoodCode = GoodCode,
                StorageCode = StorageCode,
                FiPrice1 = FiPrice1,
                OffPercent1 = OffPercent1,
                FiPrice2 = FiPrice2,
                OffPercent2 = OffPercent2,
                FiPrice3 = FiPrice3,
                OffPercent3 = OffPercent3,
                UserIdRef = UserIdRef

            };

            var _res = connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

    }  
}