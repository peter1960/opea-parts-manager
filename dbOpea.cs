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
    class dbOpea
    {
        const string PartNo = "Part#";
        const string Descr = "Description";

        private static readonly ILog log = LogManager.GetLogger(typeof(dbOpea));

        public void Insert(opeaLine data, int Company_ID) {
            String sql = "insert or replace into `opea` (" +
       "TYPE," +
       "COMPANYID," +
       "EFFECTIVEDATE," +
       "DIRTY," +
       "PARTNO," +
       "DESCRIPTION," +
       "LISTPRICE," +
       "RETAILPRICE," +
       "DISCOUNTCODE," +
       "SUPERCESSION," +
       "STATUS," +
       "TAXCODE," +
       "STOCKINGCODE," +
       "MINORDER," +
       "CLASS," +
       "CLEANPART" +
       " ) values (" +
       "'" + data.Type + "'," +
       "'" + 1 + "'," +
       "'" + data.EffectiveDate + "'," +
       "'F'," +
       "'" + data.PartNo + "'," +
       "'" + data.Description + "'," +
       "'" + data.ListPrice + "'," +
       "'" + data.RetailPrice + "'," +
       "'" + data.DiscountCode + "'," +
       "'" + data.Supercession + "'," +
       "'" + data.Status + "'," +
       "'" + data.TaxCode + "'," +
       "'" + data.StockingCode + "'," +
       "'" + data.MinOrder + "'," +
       "'" + data.Class + "'," +
       "'" + data.Clean + "'" +
       ");";

            Database.Instance.ExecuteNonQuery(sql);
        }
        private DataTable EmptyTable(int RowsToHold) {
            log.Debug("Create empty DS");

            DataTable t = new DataTable();
            DataColumn dC;
            dC = new DataColumn();
            dC.ColumnName = "id";
            t.Columns.Add(dC);

            
            dC = new DataColumn();
            dC.ColumnName = "Fr";
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = PartNo;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Descr;
            t.Columns.Add(dC);
            
            for (int x = 0; x < RowsToHold; x++) {
                t.Rows.Add();
            }
            return t;
        }

        public void FillTable(int Start, int Rows, DataGridView grid) {
            log.Debug("Fill Table from " + Start + " with " + Rows + " rows");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable(Rows);
            }

            String sQuery = "select opea_id, companyid,partno ,description, listprice from opea limit " + Rows + " offset " + Start;

            DataTable tmp = Database.Instance.FillDataSet(sQuery);
            for (int x = 0; x < Rows; x++) {
                if (x < tmp.Rows.Count) {
                    t.Rows[x]["Id"] = tmp.Rows[x][0];
                    t.Rows[x][PartNo] = tmp.Rows[x][2];
                    t.Rows[x][Descr] = tmp.Rows[x][3];
                }
                else {
                    t.Rows[x][PartNo] = "";
                    t.Rows[x][Descr] = "";
                }
            }
            log.Debug("Rows Found " + grid.RowCount);

            grid.DataSource = t;
            grid.Columns["Fr"].Width = 30;
            grid.Columns[0].Visible = false;
            grid.Columns[PartNo].Width = 30;
            grid.Columns[PartNo].Width = 100;
            grid.Columns[Descr].Width = 400;
        }
    }
}
