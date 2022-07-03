using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ArmoonWebServiceSystem.Models
{
    public class Factordatamodel
    {
        public class Factorinputmodel
        {
            public long Createuser { get; set; }
            public string Createdate { get; set; }
            public string Createtime { get; set; }
            public long? VisitorId { get; set; }
            public decimal? VisitorPrice { get; set; }

            public List<Factormodel> Value { get; set; }
        }
        public class Factormodel
        {
            public string HID { get; set; }
            public string PC { get; set; }
            public string HDE { get; set; }
            public string FT { get; set; }
            public string MBL { get; set; }
            public string CN { get; set; }
            public string SF { get; set; }
            public string T2 { get; set; }
            public string SP { get; set; }
            public string DSC { get; set; }
            public string STP { get; set; }
            public string CC { get; set; }
            public string BOC { get; set; }
            public string CR { get; set; }
            public string UA { get; set; }
            public string HSC { get; set; }
            
            public List<FDmodel> FD { get; set; }

            public List<FBmodel> FB { get; set; }


        }
        public class FDmodel
        {
            public string HID { get; set; }
            public string IID { get; set; }
            public string GS { get; set; }
            public string GC { get; set; }
            public string FP { get; set; }
            public string IDE { get; set; }
            public string UPCR { get; set; }
            public string UPC { get; set; }
            public string OFR { get; set; }
            public string OP { get; set; }
            public string TAX { get; set; }
            public string PC { get; set; }
            public string TAS { get; set; }
            public string PER { get; set; }
            public string UPC1 { get; set; }
            public string UPC2 { get; set; }
            public string LV { get; set; }
            public string WV { get; set; }
            public string HV { get; set; }
            public string CV { get; set; }
            public string DV { get; set; }
            public string CFP { get; set; }
            public string CTP { get; set; }
            public string CRO { get; set; }
            public string CRT { get; set; }
            public string ITMS { get; set; }
        }

        public class FBmodel
        {
            public string HID { get; set; }
            public string BID { get; set; }
            public string DC { get; set; }
            public string WFEC { get; set; }
            public string WFLC { get; set; }
            public string FN { get; set; }
            public string WBB { get; set; }
            public string DG { get; set; }
            public string TFG { get; set; }
            public string POS { get; set; }
            public string POD { get; set; }
            public string DBL { get; set; }
            public string DP { get; set; }
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
            public List<xmlFModel> F { get; set; }
        }

        [XmlRoot]
        public class xmlFModel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string PC { get; set; }
            [XmlElement]
            public string HDE { get; set; }
            [XmlElement]
            public string FT { get; set; }
            [XmlElement]
            public string MBL { get; set; }
            [XmlElement]
            public string CN { get; set; }
            [XmlElement]
            public string SF { get; set; }
            [XmlElement]
            public string T2 { get; set; }
            [XmlElement]
            public string SP { get; set; }
            [XmlElement]
            public string DSC { get; set; }
            [XmlElement]
            public string STP { get; set; }
            [XmlElement]
            public string CC { get; set; }
            [XmlElement]
            public string BOC { get; set; }
            [XmlElement]
            public string CR { get; set; }
            [XmlElement]
            public string UA { get; set; }
            [XmlElement]
            public string HSC { get; set; }
            


            [XmlElement]
            public List<xmlFDmodel> FD { get; set; }

            [XmlElement]
            public List<xmlFBmodel> FB { get; set; }
        }

        [XmlRoot]
        public class xmlFDmodel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string IID { get; set; }
            [XmlElement]
            public string GS { get; set; }
            [XmlElement]
            public string GC { get; set; }
            [XmlElement]
            public string FP { get; set; }
            [XmlElement]
            public string IDE { get; set; }
            [XmlElement]
            public string UPCR { get; set; }
            [XmlElement]
            public string UPC { get; set; }
            [XmlElement]
            public string OFR { get; set; }
            [XmlElement]
            public string OP { get; set; }
            [XmlElement]
            public string TAX { get; set; }
            [XmlElement]
            public string PC { get; set; }
            [XmlElement]
            public string TAS { get; set; }
            [XmlElement]
            public string PER { get; set; }
            [XmlElement]
            public string UPC1 { get; set; }
            [XmlElement]
            public string UPC2 { get; set; }
            [XmlElement]
            public string LV { get; set; }
            [XmlElement]
            public string WV { get; set; }
            [XmlElement]
            public string HV { get; set; }
            [XmlElement]
            public string CV { get; set; }
            [XmlElement]
            public string DV { get; set; }
            [XmlElement]
            public string CFP { get; set; }
            [XmlElement]
            public string CTP { get; set; }
            [XmlElement]
            public string CRO { get; set; }
            [XmlElement]
            public string CRT { get; set; }
            [XmlElement]
            public string ITMS { get; set; }
        }

        public class xmlFBmodel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string BID { get; set; }
            [XmlElement]
            public string DC { get; set; }
            [XmlElement]
            public string WFEC { get; set; }
            [XmlElement]
            public string WFLC { get; set; }
            [XmlElement]
            public string FN { get; set; }
            [XmlElement]
            public string WBB { get; set; }
            [XmlElement]
            public string DG { get; set; }
            [XmlElement]
            public string TFG { get; set; }
            [XmlElement]
            public string POS { get; set; }
            [XmlElement]
            public string POD { get; set; }
            [XmlElement]
            public string DBL { get; set; }
            [XmlElement]
            public string DP { get; set; }
      
        }
    }
}