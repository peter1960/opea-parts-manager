using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Collections;
using System.ComponentModel;


namespace OPEAManager
{
    class tbOpea
    {
        const string PartNo = "Part#";
        const string Descr = "Description";
        const string Retail = "Retail";
        const string List = "List";
        const string Stock = "Stock";
        const string Franchise = "F";
        const string Qty = "Avail";

        private static readonly ILog log = LogManager.GetLogger(typeof(tbOpea));

        public void Insert(opeaLine data, int Company_ID) {
            String sql = "insert or replace into `opea` (" +
       "TYPE," +
       "FRANCHISE_ID," +
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
       "'" + data.Franchise + "'," +
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

            Database.Instance.ExecuteNonQuery(sql,false);
        }


  
        private DataTable EmptyTable(int RowsToHold) {
            log.Debug("Create empty DS");

            DataTable t = new DataTable();
            DataColumn dC;
            dC = new DataColumn();
            dC.ColumnName = "id";
            t.Columns.Add(dC);


            dC = new DataColumn();
            dC.ColumnName = Franchise;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = PartNo;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Descr;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = List;
            dC.DataType = typeof(decimal);
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Retail;
            dC.DataType = typeof(decimal);
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Qty;
            dC.DataType = typeof(decimal);
            t.Columns.Add(dC);

            for (int x = 0; x < RowsToHold; x++) {
                t.Rows.Add();
            }
            return t;
        }

        public void FillTable(int Start, int Rows, DataGridView grid, bool bStocked) {
            log.Debug("Fill Table from " + Start + " with " + Rows + " rows");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable(Rows);
            }

            String sQuery = "select opea.opea_id, franchise_id,partno ,description, listprice,retailprice,qty from opea ";
            if (bStocked) {
                sQuery += ", stock where ";
            }
            else {
                sQuery += " LEFT JOIN stock on ";
            }
            sQuery += "opea.OPEA_ID = stock.OPEA_ID order by partno limit " + Rows + " offset " + Start;

            DataTable tmp = Database.Instance.FillDataSet(sQuery);
            for (int x = 0; x < Rows; x++) {
                if (x < tmp.Rows.Count) {
                    t.Rows[x]["Id"] = tmp.Rows[x][0];
                    t.Rows[x][Franchise] = tmp.Rows[x][1];
                    t.Rows[x][PartNo] = tmp.Rows[x][2];
                    t.Rows[x][Descr] = tmp.Rows[x][3];
                    t.Rows[x][List] = tmp.Rows[x][4];
                    t.Rows[x][Retail] = tmp.Rows[x][5];
                    t.Rows[x][Qty] = tmp.Rows[x][6];

                }
                else {
                    t.Rows[x][PartNo] = "";
                    t.Rows[x][Descr] = "";
                    t.Rows[x][List] = DBNull.Value;
                    t.Rows[x][Retail] = DBNull.Value;
                    t.Rows[x][Qty] = DBNull.Value;
                }
            }

            log.Debug("Rows Found " + tmp.Rows.Count);

            grid.DataSource = t;
            grid.Columns[Franchise].Width = 30;
            grid.Columns[0].Visible = false;
            grid.Columns[PartNo].Width = 30;
            grid.Columns[PartNo].Width = 100;
            grid.Columns[Descr].Width = 400;
            grid.Columns[List].Width = 50;
            grid.Columns[List].DefaultCellStyle.Format = "C";
            grid.Columns[List].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[Retail].Width = 50;
            grid.Columns[Retail].DefaultCellStyle.Format = "C";
            grid.Columns[Retail].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[Qty].Width = 40;
            grid.Columns[Qty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
