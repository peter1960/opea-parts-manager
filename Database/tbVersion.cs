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
            log.Debug("Check DB Version");

            try {
                sql_res = Database.Instance.FillDataSet("Select ver from version");
            }
            catch (System.Data.SQLite.SQLiteException ex) {
                log.Error(ex);
                return 0;
            }
            return 1;
        }
    }
}
