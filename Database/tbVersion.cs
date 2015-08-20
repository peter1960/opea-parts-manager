using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Data;
using System.Data.SQLite;

namespace OPEAManager
{
    class tbVersion
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbOpea));
        public int Version() {
            DataTable sql_res;
            log.Info("Check DB Version");
            int ver = 0;
            try {
                sql_res = Database.Instance.FillDataSet("Select ver from version");
            }
            catch (System.Data.SQLite.SQLiteException ex) {
                log.Error(ex);
                return 0;
            }
            if (sql_res.Rows.Count == 0) {
                log.Error("Database version is missing");
            }

            ver = (int)sql_res.Rows[0].Field<long>("ver");
            log.Info("Database Version: " + ver.ToString());
            return ver;
        }
        public void DBVersion() {
            DataTable sql_res;
            log.Info("Check SQLite");

            try {
                sql_res = Database.Instance.FillDataSet("Select sqlite_version()");
            }
            catch (System.Data.SQLite.SQLiteException ex) {
                log.Error(ex);
                return;
            }
            log.Info("       Version: " + sql_res.Rows[0].Field<string>(0).ToString());
        }

        public void Update(stVersion Record) {
            Update(Record.Ver);
        }
        public void Update(int Ver) {
            log.Debug("Update Version");

            String sql = "insert or replace into `version` (VER_ID,VER) values (1," + Ver.ToString() + ");";

            Database.Instance.ExecuteNonQuery(sql);
        }
    }
}
