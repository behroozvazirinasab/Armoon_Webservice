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
using static ArmoonWebServiceSystem.Models.AccTransactiondatamodel;

namespace ArmoonWebServiceSystem.Services
{
    public class AccTransactionService
    {
        private readonly SqlConnection connection;

        public AccTransactionService()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;


            connection = new SqlConnection(connStr);
        }

        public List<returnmodel> runAccTransactionsp(List<AccTransactionmodel> Value,long Createuser, string Createdate, string Createtime  )
        {
            var query = "sp_Insert_AccTransaction_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = Createuser,
                CreateDate = Createdate,
                CreateTime = Createtime
                
            };
            var _res = connection.Query<returnmodel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

        //______________

        public string getxml(List<AccTransactionmodel> data )
        {

            var dc2 = new List<xmlADmodel>();    

            var dc = new List<xmlAmodel>();



            foreach (var item in data)
            {
                int i = 0;
                while (i < item.AD.Count)
                {
                    dc2.Add(new xmlADmodel()
                    {
                        HID = item.AD[i].HID,
                        IID = item.AD[i].IID,
                        ROW = item.AD[i].ROW,
                        KL = item.AD[i].KL,
                        MN = item.AD[i].MN,
                        TC = item.AD[i].TC,
                        IDE = item.AD[i].IDE,
                        D = item.AD[i].D,
                        C = item.AD[i].C,
                        T2 = item.AD[i].T2

                    }); i++;
                }
            }

            foreach (var item in data)
            {
                dc.Add(new xmlAmodel()
                {
                    HID = item.HID,
                    ANO = item.ANO,
                    HDEC = item.HDEC,


                    AD = dc2

                });

            }



            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    A = dc
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