using ArmoonWebServiceSystem.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using static ArmoonWebServiceSystem.Models.Factordatamodel;

namespace ArmoonWebServiceSystem.Services
{
    public class FactorService
    {
        private readonly SqlConnection connection;

        public FactorService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;


            connection = new SqlConnection(connStr);
        }

        public List<returnmodel> runFactorsp(List<Factormodel> Value,long Createuser, string Createdate, string Createtime, long? VisitorId, decimal? VisitorPrice )
        {
            var query = "sp_Insert_Factor_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = Createuser,
                CreateDate = Createdate,
                CreateTime = Createtime,
                VisitorId = VisitorId,
                VisitorPrice = VisitorPrice,
                
            };
            var _res = connection.Query<returnmodel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

        //______________

        public string getxml(List<Factormodel> data)
        {
            var dc3 = new List<xmlFBmodel>();

            var dc2 = new List<xmlFDmodel>();

            var dc = new List<xmlFModel>();


            foreach (var item in data)
            {
                int i = 0;
                while (i < item.FB.Count)
                {
                    dc3.Add(new xmlFBmodel()
                    {
                        HID = item.FB[i].HID,
                        BID = item.FB[i].BID,
                        DC = item.FB[i].DC,
                        WFEC = item.FB[i].WFEC,
                        WFLC = item.FB[i].WFLC,
                        FN = item.FB[i].FN,
                        WBB = item.FB[i].WBB,
                        DG = item.FB[i].DG,
                        TFG = item.FB[i].TFG,
                        POS = item.FB[i].POS,
                        POD = item.FB[i].POD,
                        DBL = item.FB[i].DBL,
                        DP = item.FB[i].DP


                    }); i++;
                }
            }

            foreach (var item in data)
            {
                int i = 0;
                while (i < item.FD.Count)
                {
                    dc2.Add(new xmlFDmodel()
                    {
                        HID = item.FD[i].HID,
                        IID = item.FD[i].IID,
                        GS = item.FD[i].GS,
                        GC = item.FD[i].GC,
                        FP = item.FD[i].FP,
                        IDE = item.FD[i].IDE,
                        UPCR = item.FD[i].UPCR,
                        UPC = item.FD[i].UPC,
                        OFR = item.FD[i].OFR,
                        OP = item.FD[i].OP,
                        TAX = item.FD[i].TAX,
                        PC = item.FD[i].PC,
                        TAS = item.FD[i].TAS,
                        PER = item.FD[i].PER,
                        UPC1 = item.FD[i].UPC1,
                        UPC2 = item.FD[i].UPC2,
                        LV = item.FD[i].LV,
                        WV = item.FD[i].WV,
                        HV = item.FD[i].HV,
                        CV = item.FD[i].CV,
                        DV = item.FD[i].DV,
                        CFP = item.FD[i].CFP,
                        CTP = item.FD[i].CTP,
                        CRO = item.FD[i].CRO,
                        CRT = item.FD[i].CRT,
                        ITMS = item.FD[i].ITMS



                    }); i++;
                }
            }

            foreach (var item in data)
            {
                dc.Add(new xmlFModel()
                {
                    HID = item.HID,
                    PC = item.PC,
                    HDE = item.HDE,
                    FT = item.FT,
                    MBL = item.MBL,
                    CN = item.CN,
                    SF = item.SF,
                    T2 = item.T2,
                    SP = item.SP,
                    DSC = item.DSC,
                    STP = item.STP,
                    CC = item.CC,
                    BOC = item.BOC,
                    CR = item.CR,
                    UA = item.UA,
                    HSC = item.HSC,
                    
                    
                    FD = dc2,

                    FB = dc3

                });

            }



            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    F = dc
                }
            };



            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(rootmodel));

            xs.Serialize(sw, rModel);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sw.ToString());
            XmlNodeList nodes = doc.SelectNodes("//rootmodel");

            return doc.FirstChild.NextSibling.InnerXml;
        }
    }
}