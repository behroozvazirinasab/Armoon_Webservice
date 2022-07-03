using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static ArmoonWebServiceSystem.Models.Gooddatamodel;

namespace ArmoonWebServiceSystem.Controllers
{
    public class GoodController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/InsertGood")]
        public List<ResponseModel> Post([FromBody] InsertGoodmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.GoodService();
            var _res = ds.runInsertGoodsp(value.Code, value.Name, value.Type, value.UnitIdRef, value.MainGroupCodeRef, value.SecondGroupCodeRef,value.Pic, value.IsAdded, value.ImageData, value.IsBuyAdded, value.Serial, value.FiPrice1, value.OffPercent1, value.FiPrice2, value.OffPercent2, value.FiPrice3, value.OffPercent3, value.SaleName, value.UnitPackingCodeRef, value.TaxPercent, value.lengthValue, value.WidthValue, value.HeightValue, value.GoodCategoryIdRef, value.IsActive, value.DiameterValue, value.SerialsControl, value.PatternIdRef, value.NationalCode, value.WeightPack, value.WeightGoods, value.CriterionWeight, value.DimensionsLengthPack, value.DimensionsWidthPack, value.DimensionsHeightPack, value.DimensionsLengthGoods, value.DimensionsWidthGoods, value.DimensionsHeightGoods, value.CriterionDimensions);
            return _res.ToList();
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/webservice/SearchGood")]
        public List<ResponseModelSearch> Post([FromBody] SearchGoodmodel value)
        {
            var ds = new ArmoonWebServiceSystem.Services.GoodService();
            var _res = ds.runSearchGoodsp(value.Code, value.Name, value.Type, value.UnitsName, value.MainGroupName, value.SecondGroupName, value.Serial, value.FiPrice1, value.OffPercent1, value.FiPrice2, value.OffPercent2, value.FiPrice3, value.OffPercent3, value.SaleName, value.UnitPackingName, value.TaxPercent, value.lengthValue, value.WidthValue, value.HeightValue, value.GoodCategoryName, value.IsActive, value.DiameterValue, value.GoodPatternName, value.NationalCode, value.WeightPack, value.WeightGoods);            
            return _res.ToList();
        }
    }
}