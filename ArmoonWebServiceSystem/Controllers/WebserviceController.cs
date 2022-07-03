using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static ArmoonWebServiceSystem.Models.Servicedatamodel;
using static ArmoonWebServiceSystem.Services.DataServices;

namespace ArmoonWebServiceSystem.Controllers
{
    public class WebserviceController : ApiController
    {
        [HttpPost]
        [Route("api/webservice/iranhotelsetacc")]
        public List<returnmodel> Post([FromBody] iranhoteldatainputmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.DataServices();
            var _res = ds.runiranhotelsp(value.custcode, value.custname, value.custprice, value.custdesc,
                                         value.turnovercode, value.date, value.supplier, value.bank);
            return _res.ToList();
        }
        [Route("api/webservice/returnpass")]
        public string Post([FromUri] string value)
        {
            var ds = new ArmoonWebServiceSystem.Services.DataServices();
            return ds.returnpass(value);
        }
    }
}
