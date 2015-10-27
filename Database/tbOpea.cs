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
using System.Diagnostics;


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
        const string Id = "Id";
        const string Status = "Status";

        private static readonly ILog log = LogManager.GetLogger(typeof(tbOpea));
        public void InsertUpdate(opeaLine data) {
            //if update failed then this is a new 
            //record and then insert it.
            //relies on the part/franshise index
            if (!Update(data, false)) {
                Insert(data);
            }
        }
        public void UpdateById(opeaLine data) {
            //if update failed then this is a new 
            //record and then insert it.
            //relies on the part/franshise index
            if (!Update(data, true)) {
                log.Debug("Update Failed, inserting");
            }
        }
        public bool Update(opeaLine data, bool byId) {

            String sql = "update opea set " +
               "TYPE = '" + data.Type + "'," +
               "EFFECTIVEDATE = '" + data.EffectiveDate + "'," +
               "DIRTY = 'F'," +
            "DESCRIPTION = '" + data.Description + "'," +
            "LISTPRICE = '" + data.ListPrice + "'," +
            "RETAILPRICE = '" + data.RetailPrice + "'," +
            "DISCOUNTCODE = '" + data.DiscountCode + "'," +
            "SUPERCESSION = '" + data.Supercession + "'," +
            "SUPERCEEDS = '" + data.Superceeds + "'," +
            "STATUS = '" + data.Status + "'," +
            "TAXCODE = '" + data.TaxCode + "'," +
            "STOCKINGCODE = '" + data.StockingCode + "'," +
            "MINORDER ='" + data.MinOrder + "'," +
            "CLASS = '" + data.Class + "'," +
            "CLEANPART = '" + data.Clean + "', " +
            "UPDATED = (datetime('now','localtime')) ";
            if (byId) {
                log.Debug("Update ID: " + data.OPEA_id.ToString());
                sql += ", SUPPLIER_ID = "+data.Supplier.ToString()+" ";
                sql += " where OPEA_ID = " + data.OPEA_id.ToString() + ";";
            }
            else {
                sql += " where PARTNO = '" + data.PartNo + "' and FRANCHISE_ID = '" + data.Franchise + "';";
            }

            //log.Debug(Database.Instance.ExecuteNonQuery(sql, false));

            // if updating by id then this is a single update and not a bulk load
            // so the execute can be logged
            return Database.Instance.ExecuteNonQuery(sql, byId) == 1;
        }
        public void Insert(opeaLine data) {
            String sql = "insert into `opea` (" +
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

            Database.Instance.ExecuteNonQuery(sql, false);
        }

        public stOPEA FetchRecord(long oped_id) {
            log.Debug("Fetch OPEA Record");
            stOPEA st = new stOPEA();
            String sQuery = "select opea_id, type, franchise_id,supplier_id,partno ,description, listprice,retailprice,created,updated,supercession,superceeds from opea where opea_id = " + oped_id.ToString();
            DataTable tmp = Database.Instance.FillDataSet(sQuery);
            st.OPEA_id = (long)tmp.Rows[0]["opea_id"];
            //StatusEnum MyStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Active", true);
            st.mType = (stOPEATypes.Type)Enum.Parse(typeof(stOPEATypes.Type), (String)tmp.Rows[0]["type"]);
            st.mPart = (String)tmp.Rows[0]["partno"];
            st.mDescription = (String)tmp.Rows[0]["description"];
            st.mListPrice = (Decimal)(Double)tmp.Rows[0]["listprice"];
            st.mRetailPrice = (Decimal)(Double)tmp.Rows[0]["retailprice"];
            st.mFranchise_id = (String)tmp.Rows[0]["franchise_id"];
            st.mSupplier_id = (long)tmp.Rows[0]["supplier_id"];
            st.mCreated = (DateTime)tmp.Rows[0]["created"];
            st.mUpdated = (DateTime)tmp.Rows[0]["updated"];
            st.mSupercession = (String)tmp.Rows[0]["supercession"];
            st.mSuperceeds = (String)tmp.Rows[0]["superceeds"];
            return st;
        }

        public void UpdateSuperceeded(String Franchise, Dictionary<String, String> sList) {
            PerformanceCounter ramCounter;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

            log.Info(Franchise + " Total Parts Superceeded: " + sList.Count);
            Database.Instance.BeginTrans();
            int nCount = 0;
            int nTotal = 0;

            foreach (KeyValuePair<string, string> entry in sList) {
                String sql = "update opea set " +
                "SUPERCEEDS = '" + entry.Key + "' where PARTNO = '" + entry.Value + "' and FRANCHISE_ID = '" + Franchise + "';";
                Database.Instance.ExecuteNonQuery(sql, false);
                nCount++;
                nTotal++;

                if (nCount >= Properties.Settings.Default.CommitSize) {
                    Database.Instance.CommitTrans();
                    Database.Instance.BeginTrans();
                    nCount = 0;
                    log.Debug("     Committed :" + nTotal + "   " + Convert.ToInt32(ramCounter.NextValue()).ToString() + "Mb");
                }

            }
            Database.Instance.CommitTrans();



        }
        private DataTable EmptyTable(int RowsToHold) {
            log.Debug("Create empty DS");

            DataTable t = new DataTable();
            DataColumn dC;
            dC = new DataColumn();
            dC.ColumnName = Id;
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
            FillTable(Start, Rows, grid, bStocked, "");
        }

        public void FillTable(int Start, int Rows, DataGridView grid, bool bStocked, String Pattern) {
            log.Debug("Fill Table from " + Start + " with " + Rows + " rows");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable(Rows);
            }

            String sQuery = "select opea.opea_id, franchise_id,partno ,description, listprice,retailprice,qty,status from opea ";
            if (bStocked) {
                sQuery += ", stock where ";
                if (Pattern.Length > 0) {
                    sQuery += " (cleanpart like '%" + Pattern + "%' or description like '%" + Pattern + "%'  ) AND ";
                }
            }
            else {
                sQuery += " LEFT JOIN stock on ";
            }
            sQuery += "opea.OPEA_ID = stock.OPEA_ID ";

            if (!bStocked) {
                sQuery += " where (cleanpart like '%" + Pattern + "%' or description like '%" + Pattern + "%') ";

            }

            sQuery += "order by partno limit " + Rows + " offset " + Start;

            DataTable tmp = Database.Instance.FillDataSet(sQuery);
            for (int x = 0; x < Rows; x++) {
                if (x < tmp.Rows.Count) {
                    t.Rows[x][Id] = tmp.Rows[x]["opea_id"];
                    t.Rows[x][Franchise] = tmp.Rows[x]["franchise_id"];
                    t.Rows[x][PartNo] = tmp.Rows[x]["partno"];
                    if (tmp.Rows[x]["status"].ToString().Equals("N")) {
                        t.Rows[x][PartNo] = "NA:" + t.Rows[x][PartNo];
                    }
                    t.Rows[x][Descr] = tmp.Rows[x]["description"];
                    t.Rows[x][List] = tmp.Rows[x]["listprice"];
                    t.Rows[x][Retail] = tmp.Rows[x]["retailprice"];
                    t.Rows[x][Qty] = tmp.Rows[x]["qty"];

                }
                else {
                    t.Rows[x][Id] = DBNull.Value;
                    t.Rows[x][Franchise] = DBNull.Value;
                    t.Rows[x][PartNo] = "";
                    t.Rows[x][Descr] = "";
                    t.Rows[x][List] = DBNull.Value;
                    t.Rows[x][Retail] = DBNull.Value;
                    t.Rows[x][Qty] = DBNull.Value;
                }
            }

            log.Debug("Rows Found " + tmp.Rows.Count);

            grid.DataSource = t;
            grid.Columns[Franchise].Width = 45;
            grid.Columns[Id].Visible = false;
            grid.Columns[PartNo].Width = 110;
            grid.Columns[Descr].Width = 400;
            grid.Columns[List].Width = 60;
            grid.Columns[List].DefaultCellStyle.Format = "C";
            grid.Columns[List].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[Retail].Width = 60;
            grid.Columns[Retail].DefaultCellStyle.Format = "C";
            grid.Columns[Retail].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[Qty].Width = 40;
            grid.Columns[Qty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
