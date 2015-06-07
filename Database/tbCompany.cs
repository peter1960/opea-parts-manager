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

        private static readonly ILog log = LogManager.GetLogger(typeof(dbOpea));

        public void Update(String Address1,
            String Address2,
            String Name1,
            String Name2,
            String Phone1,
            String Phone2,
            String City,
            String State,
            String URL) {
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

    }
}
