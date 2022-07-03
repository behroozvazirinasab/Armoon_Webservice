using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static ArmoonWebServiceSystem.Models.Factordatamodel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class FactorController : ApiController
    {
        // GET: AccTransaction
        [HttpPost]
        [Route("api/webservice/Factor")]
        public List<returnmodel> Post([FromBody] Factorinputmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.FactorService();
            var _res = ds.runFactorsp(value.Value, value.Createuser, value.Createdate, value.Createtime, value.VisitorId, value.VisitorPrice );
            return _res.ToList();
        }
    }
}