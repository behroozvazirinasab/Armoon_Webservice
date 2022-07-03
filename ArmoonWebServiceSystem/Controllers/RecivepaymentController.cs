using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static ArmoonWebServiceSystem.Models.RecivePaymentdatamodel;
using static ArmoonWebServiceSystem.Services.RecivePaymentDataService;
namespace ArmoonWebServiceSystem.Controllers
{
    public class RecivepaymentController : ApiController
    {
        // GET:Recivepayment
        [HttpPost]
        [Route("api/webservice/Recivepayment")]
        public List<returnmodel> Post([FromBody] RecivePaymentinputmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.RecivePaymentDataService();
            var _res = ds.runRecivePaymentsp(value.Value,value.Createuser, value.Createdate, value.Createtime);
            return _res.ToList();
        }
    }
}