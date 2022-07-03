using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static ArmoonWebServiceSystem.Models.AccTransactiondatamodel;
using static ArmoonWebServiceSystem.Services.AccTransactionService;

namespace ArmoonWebServiceSystem.Controllers
{
    public class AccTransactionController : ApiController
    {
        // GET: AccTransaction
        [HttpPost]
        [Route("api/webservice/acctransaction")]
        public List<returnmodel> Post([FromBody] AccTransactioninputmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.AccTransactionService();
            var _res = ds.runAccTransactionsp(value.Value,value.Createuser, value.Createdate, value.Createtime );
            return _res.ToList();
        }
        
    }
}