using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ArmoonWebServiceSystem.Models
{
    public class RecivePaymentdatamodel
    {
        public class RecivePaymentinputmodel
        {
            public long Createuser { get; set; }
            public string Createdate { get; set; }
            public string Createtime { get; set; }
            

            public List<Recivepatmentdatamodel> Value { get; set; }
        }

        public class Recivepatmentdatamodel 
        {
            public string HID { get; set; }
            public string PC { get; set; }
            public string RPT { get; set; }
            public string RPC { get; set; }
            public string T2 { get; set; }
            public string ET { get; set; }


            public List<RDmodel> RD { get; set; }

        }

        public class RDmodel
        {
            public string HID { get; set; }
            public string IID { get; set; }
            public string PRC { get; set; }
            public string IDISC { get; set; }
            public string P { get; set; }
            public string TAX { get; set; }
            public string T2 { get; set; }
            public string PRC1 { get; set; }
            public string T21 { get; set; }

        }


        public class returnmodel
        {
            public Boolean HaveError { get; set; }
            public string Msg { get; set; }

        }


        //xml__________________________

        
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
            public List<xmlRmodel> R { get; set; }
        }

        [XmlRoot]
        public class xmlRmodel 
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string PC { get; set; }

            [XmlElement]
            public string RPT { get; set; }

            [XmlElement]
            public string RPC { get; set; }

            [XmlElement]
            public string T2 { get; set; }

            [XmlElement]
            public string ET { get; set; }

           

            [XmlElement]
            public List<xmlRDmodel> RD { get; set; }
        }

        [XmlRoot]
        public class xmlRDmodel 
        {

            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string IID { get; set; }

            [XmlElement]
            public string PRC { get; set; }

            [XmlElement]
            public string IDISC { get; set; }

            [XmlElement]
            public string P { get; set; }

            [XmlElement]
            public string TAX { get; set; }

            [XmlElement]
            public string T2 { get; set; }

            [XmlElement]
            public string PRC1 { get; set; }

            [XmlElement]
            public string T21 { get; set; }

        }
    }
}