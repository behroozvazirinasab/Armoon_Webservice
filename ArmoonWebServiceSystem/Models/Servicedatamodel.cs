using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ArmoonWebServiceSystem.Models
{
    public class Servicedatamodel
    {
        public class iranhoteldatainputmodel
        {
            public string custcode { get; set; }
            public string custname { get; set; }
            public string custprice { get; set; }
            public string custdesc { get; set; }
            public Int16 turnovercode { get; set; }
            public string date { get; set; }

            public List<iranhoteldatamodel> supplier { get; set; }

            public List<iranhoteldatamodel> bank { get; set; }
        }
        public class iranhoteldatamodel
        {
            public string code { get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public string desc { get; set; }
            //type = 1 بدهکار
            //type = 2 بستانکار
            public int Type { get; set; }
        }

        public class returnmodel
        {
            public Boolean HavingError { get; set; }
            public string Msg { get; set; }

        }

        [XmlRoot]
        public class rootmodel
        {
            [XmlElement]
            public RootObject root { get; set; }
        }

        [XmlRoot]
        public class RootObject
        {
            [XmlElement]
            public List<xmlModel> H { get; set; }
        }

        [XmlRoot]
        public class xmlModel
        {
            [XmlElement]
            public string Code { get; set; }

            [XmlElement]
            public string Name { get; set; }

            [XmlElement]
            public double Price { get; set; }

            [XmlElement]
            public string DE { get; set; }

            [XmlElement]
            public int Type { get; set; }
        }
    }
}