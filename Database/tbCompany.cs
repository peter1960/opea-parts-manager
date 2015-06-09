using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Data;
using System.Data.SQLite;



namespace OPEAManager
{
    class tbCompany
    {
        const string PartNo = "Part#";
        const string Descr = "Description";

        private static readonly ILog log = LogManager.GetLogger(typeof(tbOpea));

        public void Update(stCompany Record) {
            Update(Record.Address1, Record.Address2, Record.Name1, Record.Name2, Record.Phone1, Record.Phone2, Record.City, Record.State, Record.URL);
        }
        public void Update(String Address1,
            String Address2,
            String Name1,
            String Name2,
            String Phone1,
            String Phone2,
            String City,
            String State,
            String URL) {
                log.Debug("Update Company");

            String sql = "insert or replace into `company` (COMPANY_ID," +
                "ADDRESS1," +
       "ADDRESS2," +
       "NAME1," +
       "NAME2," +
       "PHONE1," +
       "PHONE2," +
       "CITY," +
       "STATE," +
       "URL" +
            ") values (" +
       "1," +
       "'" + Address1 + "'," +
       "'" + Address2 + "'," +
       "'" + Name1 + "'," +
       "'" + Name2 + "'," +
       "'" + Phone1 + "'," +
       "'" + Phone2 + "'," +
       "'" + City + "'," +
       "'" + State + "'," +
       "'" + URL + "'" +
       ");";

            Database.Instance.ExecuteNonQuery(sql);
        }
        public stCompany Fetch() {
            DataTable sql_res;
            stCompany data = new stCompany();
            sql_res = Database.Instance.FillDataSet("Select * from company");
            if (sql_res.Rows.Count == 0) {
                log.Debug("No Rows in Company");

            }
            else {
                log.Debug("Company Found");
                data.Address1 = sql_res.Rows[0].Field<String>("address1");
                data.Address2 = sql_res.Rows[0].Field<String>("address2");
                data.Name1 = sql_res.Rows[0].Field<String>("name1");
                data.Name2 = sql_res.Rows[0].Field<String>("name2");
                data.Phone1 = sql_res.Rows[0].Field<String>("phone1");
                data.Phone2 = sql_res.Rows[0].Field<String>("phone2");
                data.City = sql_res.Rows[0].Field<String>("City");
                data.State = sql_res.Rows[0].Field<String>("State");
                data.URL = sql_res.Rows[0].Field<String>("URL");
            }
            return data;
        }
    }
}
