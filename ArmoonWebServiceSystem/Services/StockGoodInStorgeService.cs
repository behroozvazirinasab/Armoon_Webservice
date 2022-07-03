using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static ArmoonWebServiceSystem.Models.StockGoodInStorgeModel;

namespace ArmoonWebServiceSystem.Services
{
    public class StockGoodInStorgeService
    {
        private readonly SqlConnection connection;

        public StockGoodInStorgeService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            connection = new SqlConnection(connStr);
        }


        public List<ResponseModel> runStockGoodInStorgesp(StockGoodInStorgeInputModel stockGoodInStorgeModel)
        {

            var query = "sp_StockGoodInStorge";

            var queryparams = new
            {
                GoodsCode = stockGoodInStorgeModel.GoodsCode,
                StorageCode = stockGoodInStorgeModel.StorageCode,
                ItmID = stockGoodInStorgeModel.ItmID,
                Date = stockGoodInStorgeModel.Date,
                ByNow = stockGoodInStorgeModel.ByNow,
                CashMenuMode = stockGoodInStorgeModel.CashMenuMode


            };

            var _res = connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }
}