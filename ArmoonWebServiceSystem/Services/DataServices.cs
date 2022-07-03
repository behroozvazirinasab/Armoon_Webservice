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
using static ArmoonWebServiceSystem.Models.Servicedatamodel;

namespace ArmoonWebServiceSystem.Services
{
    public class DataServices
    {
        private readonly SqlConnection connection;

        public DataServices()
        {
            var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            //برای encrypt کردن پسورد
            //var scb = new SqlConnectionStringBuilder(connStr);
            //scb.Password = scb.Password;

            connection = new SqlConnection(connStr);
        }

        public List<returnmodel> runiranhotelsp(string Custcode, string Custname, string Custprice, string Custdesc, Int16 Turnovercode, string Date, List<iranhoteldatamodel> supplier, List<iranhoteldatamodel> bank)
        {
            var query = "sp_Insert_IRHotelData_FromXml";
            var supplierxml = getxml(supplier);
            var bankxml = getxml(bank);

            var queryparams = new
            {
                CustomerCode = Custcode,
                CustomerName = Custname,
                CustomerPrice = Custprice,
                CustomerDescription = Custdesc,
                TurnOverCode = Turnovercode,
                xmlSupplierList = supplierxml,
                xmlBankList = bankxml,
                CreateDate = Date
            };
            var _res = connection.Query<returnmodel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

        public string returnpass(string value)
        {


            //int m, n, t;
            //int k, i, j;
            //string xstr, str, tmpstr;
            //value = convert(value);
            //str= "";
            //i= 0;
            //k= 1;
            //while(i<value.Length - 1)
            //{
            //    j = i;
            //    xstr = "";
            //    while (Convert.ToString(value[j]) != "-")
            //    {
            //        xstr += value[j];
            //        j += 1;
            //    }
            //    m = Convert.ToInt32(xstr) >> 13;
            //    //n = (Convert.ToInt32(xstr) << 3);
            //    n = m | (Convert.ToInt32(xstr) << 3);
            //    n = m || (Convert.ToInt32(xstr) << 3);
                //xstr = 
            //}

            return "1";
        }

        private string convert(string value)
        {
            int i;
            string str, tmpstr;
            i = 0;
            str = "";
            while (i < value.Length - 1)
            {
                tmpstr = "";
                tmpstr += value[i];
                if (Convert.ToInt16(tmpstr) > 0)
                {
                    if (Convert.ToInt16(tmpstr) > 1)
                    {
                        if (Convert.ToInt16(tmpstr) > 2)
                        {
                            if (Convert.ToInt16(tmpstr) > 3)
                            {
                                if (Convert.ToInt16(tmpstr) > 4)
                                {
                                    str +=  value[i + 1];
                                }
                                str += value[i + 2];
                            }
                            str += value[i + 4];
                        }
                        str += value[i + 5];
                    }
                    str += value[i + 6];
                }
                i += 7;
                str += "-";
            }
            return str;
        }
        private IEnumerable<int> GetData()
        {
            yield return 1 + 1;
        }

        public string getxml(List<iranhoteldatamodel> data)
        {
            var dc = new List<xmlModel>();
            foreach (var item in data)
            {
                dc.Add(new xmlModel() {
                    Code = item.code,
                    Name = item.name,
                    DE = item.desc,
                    Price = item.price,
                    Type = item.Type
                });
            }

            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    H = dc
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