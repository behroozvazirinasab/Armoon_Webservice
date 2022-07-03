using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static ArmoonWebServiceSystem.Models.StockGoodInStorgeModel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class stockGoodInStorgeController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/StockGoodInStorge")]
        public List<ResponseModel> Post([FromBody] StockGoodInStorgeInputModel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.StockGoodInStorgeService();
            var _res = ds.runStockGoodInStorgesp(value);
            return _res.ToList();
        }
    }
}