using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ArmoonWebServiceSystem.Models
{
    public class AccTransactiondatamodel
    {
        public class AccTransactioninputmodel
        {
            public long Createuser { get; set; }
            public string Createdate { get; set; }
            public string Createtime { get; set; }

            public List<AccTransactionmodel> Value { get; set; }
        }
        public class AccTransactionmodel
        {
            public string HID { get; set; }
            public string ANO { get; set; }
            public string HDEC { get; set; }


            public List<ADmodel> AD { get; set; }

        }
        public class ADmodel
        {
            public string HID { get; set; }
            public string IID { get; set; }
            public string ROW { get; set; }
            public string KL { get; set; }
            public string MN { get; set; }
            public string TC { get; set; }
            public string IDE { get; set; }
            public string D { get; set; }
            public string C { get; set; }
            public string T2 { get; set; }
        }

        public class returnmodel
        {
            public Boolean HaveError { get; set; }
            public string Msg { get; set; }

        }


        //xml____________________


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
            public List<xmlAmodel> A { get; set; }
        }

        [XmlRoot]
        public class xmlAmodel
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string ANO { get; set; }

            [XmlElement]
            public string HDEC { get; set; }


            [XmlElement]
            public List<xmlADmodel> AD { get; set; }
        }

        [XmlRoot]
        public class xmlADmodel
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string IID { get; set; }

            [XmlElement]
            public string ROW { get; set; }

            [XmlElement]
            public string KL { get; set; }

            [XmlElement]
            public string MN { get; set; }

            [XmlElement]
            public string TC { get; set; }

            [XmlElement]
            public string IDE { get; set; }

            [XmlElement]
            public string D { get; set; }

            [XmlElement]
            public string C { get; set; }

            [XmlElement]
            public string T2 { get; set; }
        }


    }
}