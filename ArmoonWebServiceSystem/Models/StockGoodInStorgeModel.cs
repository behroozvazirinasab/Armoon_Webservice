using ArmoonWebServiceSystem.PersianDateExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmoonWebServiceSystem.Models
{
    public class StockGoodInStorgeModel
    {
        public class StockGoodInStorgeInputModel
        {
            public string GoodsCode { get; set; }
            public long StorageCode { get; set; }

            public long ItmID = 0;

            public string Date = DateTime.Now.ToPeString("yyyyMMdd");

            public bool ByNow = true;

            public bool CashMenuMode = false;
        }
        public class ResponseModel
        {
            public long? RealCount { get; set; }
            public long? UsableCount { get; set; }
        }

    }
}