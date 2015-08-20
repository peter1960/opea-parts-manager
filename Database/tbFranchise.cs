﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;


namespace OPEAManager
{
    class tbFranchise
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbFranchise));

        public void FillList(ToolStripComboBox cb) {
            cb.Items.Clear();
            cb.Items.Add("All");
            cb.SelectedIndex = 0;
        }

        private DataTable EmptyTable(int RowsToHold) {
            log.Debug("Create empty DS");

            DataTable t = new DataTable();
            DataColumn dC;
            dC = new DataColumn();
            dC.ColumnName = "Fr";
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = "Part";
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = "Description";
            t.Columns.Add(dC);

            for (int x = 0; x < RowsToHold; x++) {
                t.Rows.Add();
            }
            return t;
        }


        public void FillTable(int Start, int Rows, DataGridView grid) {
            log.Debug("Fill Table from ");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable(Rows);
            }
            DataTable tmp = Database.Instance.FillDataSet("select companyid,partno ,description, listprice from franchise");
            for (int x = 0; x < Rows; x++) {
                if (x < tmp.Rows.Count) {
                    t.Rows[x]["Part"] = tmp.Rows[x][1];
                    t.Rows[x]["Description"] = tmp.Rows[x][2];
                }
                else {
                    t.Rows[x]["Part"] = "";
                    t.Rows[x]["Description"] = "";
                }
            }
            log.Debug("Rows Found " + grid.RowCount);

            grid.DataSource = t;
            grid.Columns[0].Width = 30;
            grid.Columns[1].Width = 100;
            grid.Columns[2].Width = 400;
        }

        public void Update(stFranchise Record) {
            Update(Record.Franschise_id, Record.Active, Record.Custom, Record.Prefix, Record.Supplier_id);
        }
        public void Update(int Franchise_id, String Active, String Custom, String Prefix, int Supplier_id) {
            log.Debug("Update Franchise");

            String sql = "";
            sql += "insert or replace into `Franchise` (ACTIVE,CUSTOM,PREFIX,SUPPLIER_ID)";
            sql += " values (";
            sql += "'" + Active + "','" + Custom + "','" + Prefix + "'," + Supplier_id.ToString() + ");";

            Database.Instance.ExecuteNonQuery(sql);
        }


    }
}
