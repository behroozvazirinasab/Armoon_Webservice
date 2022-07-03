using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static ArmoonWebServiceSystem.Models.Persondatamodel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class PersonController : ApiController
    {
        
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/InsertPerson")]
        public List<ResponseModel> Post([FromBody] InsertPersonmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.PersonService();
            var _res = ds.runInsertPersonsp(value.Code, value.Name, value.Tel, value.Address, value.Persons, value.Expence, value.Bank, value.Cash, value.Tuner, value.PerType, value.KlCodeRef, value.MnCodeRef, value.Mobile, value.Fax, value.EconomicCode, value.NationalCode, value.RegisterNo, value.PostCode, value.NationalNo, value.Email, value.Description, value.GoodRequest, value.Addres2, value.Tel2, value.Mobile2, value.Email2, value.KlCashCodeRef, value.MnCashCodeRef, value.KlBankCodeRef, value.MnBankCodeRef, value.KlPayCodeRef, value.MnPayCodeRef, value.Craft, value.StateIdRef, value.CityIdRef, value.VisitorCodeRef, value.ActualType, value.TransactionTaxType, value.RateDefualt, value.BranchName, value.AccountType, value.AccountOwner, value.ShebaNo, value.CardNo, value.BranchTel, value.BranchFax, value.AccountNo, value.IsActive, value.FName, value.LName, value.CalcTax);
            return _res.ToList();
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/SearchPerson")]
        public List<ResponseModelSearch> Post([FromBody] SearchPersonmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.PersonService();
            var _res = ds.runSearchPersonsp(value.Code, value.Name, value.Tel, value.Address, value.Persons, value.Expence, value.Bank, value.Cash, value.Tuner, value.PerType, value.Mobile, value.Fax, value.EconomicCode, value.NationalCode, value.RegisterNo, value.PostCode, value.NationalNo,  value.Description, value.ISActive, value.FName, value.LName);
            return _res.ToList();
        }
    }
}