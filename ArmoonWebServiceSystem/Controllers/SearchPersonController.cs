using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static ArmoonWebServiceSystem.Models.SearchPersondatamodel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class SearchPersonController : ApiController
    {
        [HttpPost]
        [Route("api/webservice/SearchPerson")]
        public List<SearchPersonReturnmodel> Post([FromBody] SearchPersoninputmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.SearchPersonService();
            var _res = ds.runSearchPersonsp(value.Code, value.Name, value.Tel, value.Address, value.PerType, value.Expence, value.Bank, value.Cash, value.Tuner, value.Persons, value.Mobile, value.Fax, value.EconomicCode, value.NationalCode, value.RegisterNo, value.PostCode, value.NationalNo, value.Description, value.ISActive, value.FName, value.LName);
            return _res.ToList();
        }
    }
}