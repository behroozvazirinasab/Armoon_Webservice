using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static ArmoonWebServiceSystem.Models.ChangeGoodRateModel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class ChangeGoodRateController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/ChangeGoodRate")]
        public List<ResponseModel> Post([FromBody] ChangeGoodRateInputModel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.ChangeGoodRateService();
            var _res = ds.runChangeGoodRatesp(value.GoodCode, value.StorageCode, value.FiPrice1, value.OffPercent1, value.FiPrice2, value.OffPercent2, value.FiPrice3, value.OffPercent3,  value.UserIdRef);
            return _res.ToList();
        }
    }
}