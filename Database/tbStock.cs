using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace OPEAManager
{
    class tbStock
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbStock));

        public void UpdateStock(String Id, Decimal Qty) {
            log.Debug("Update Stock");
            String sql = "insert or replace into `stock` (LOCATION_ID,QTY,OPEA_ID) values (0," + Qty.ToString() + "," + Id + ")"; ;
            Database.Instance.ExecuteNonQuery(sql);
        }

    }
}
