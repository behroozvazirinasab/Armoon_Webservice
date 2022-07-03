using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmoonWebServiceSystem.Models
{
    public class ChangeGoodRateModel
    {
        public class ChangeGoodRateInputModel
        {
            public string GoodCode { get; set; }
            public long? StorageCode { get; set; }
            public decimal? FiPrice1 { get; set; }
            public decimal? OffPercent1 { get; set; }
            public decimal? FiPrice2 { get; set; }
            public decimal? OffPercent2 { get; set; }
            public decimal? FiPrice3 { get; set; }
            public decimal? OffPercent3 { get; set; }
            public long? UserIdRef { get; set; }
        }


        public class ResponseModel
        {
            public long? Code { get; set; }
            public string Msg { get; set; }
        }
    }
}