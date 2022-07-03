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
using static ArmoonWebServiceSystem.Models.RecivePaymentdatamodel;

namespace ArmoonWebServiceSystem.Services
{
    public class RecivePaymentDataService
    {
        private readonly SqlConnection connection;

        public RecivePaymentDataService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            connection = new SqlConnection(connStr);
        }

        public List<returnmodel> runRecivePaymentsp(List<Recivepatmentdatamodel> Value,long Createuser, string Createdate, string Createtime )
        {
            var query = "sp_Insert_RecivePayment_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                Createuser = Createuser,
                Createdate = Createdate,
                Createtime = Createtime
                
            };
            var _res = connection.Query<returnmodel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }


        /// __________________________________________________




        public string getxml(List<Recivepatmentdatamodel> data)
        {

            var dc2 = new List<xmlRDmodel>();

            var dc = new List<xmlRmodel>();

            

            foreach (var item in data)
            {   
                int i = 0;
                while (i < item.RD.Count) 
                {
                    dc2.Add(new xmlRDmodel()
                    {
                        HID = item.RD[i].HID,
                        IID = item.RD[i].IID,
                        PRC = item.RD[i].PRC,
                        IDISC = item.RD[i].IDISC,
                        P = item.RD[i].P,
                        TAX = item.RD[i].TAX,
                        T2 = item.RD[i].T2,
                        PRC1 = item.RD[i].PRC1,
                        T21 = item.RD[i].T21

                    }); i++;
                }
            }

            foreach (var item in data)
            {
                dc.Add(new xmlRmodel()
                {
                    HID = item.HID,
                    PC = item.PC,
                    RPT = item.RPT,
                    RPC = item.RPC,
                    T2 = item.T2,
                    ET = item.ET,

                    RD = dc2

                }); ; 
            }



            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    R = dc
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