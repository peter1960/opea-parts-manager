using log4net;
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
    class tbSupplier
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbSupplier));

        const string Id = "Id";
        const string Active = "A";
        const string Name = "Name";
        const string Phone = "Phone";


        private DataTable EmptyTable() {
            log.Debug("Create empty DS");

            DataTable t = new DataTable();
            DataColumn dC;
            dC = new DataColumn();
            dC.ColumnName = Id;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Active;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Name;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Phone;
            t.Columns.Add(dC);

            return t;
        }


        public void FillTable(DataGridView grid) {
            log.Debug("Fill Table from ");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable();
            }
            DataTable tmp = Database.Instance.FillDataSet("select SUPPLIER_ID, Active , Name1,Phone1 from supplier");
            for (int x = 0; x < tmp.Rows.Count; x++) {
                t.Rows.Add();
                t.Rows[x][Id] = tmp.Rows[x][0];
                t.Rows[x][Active] = tmp.Rows[x][1];
                t.Rows[x][Name] = tmp.Rows[x][2];
                t.Rows[x][Phone] = tmp.Rows[x][3];
            }
            log.Debug("Rows Found " + grid.RowCount);

            grid.DataSource = t;
            grid.Columns[Id].Visible = false;
            grid.Columns[Active].Width = 40;
            grid.Columns[Name].Width = 400;
            grid.Columns[Phone].Width = 100;
        }


    }
}
