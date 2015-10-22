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
    class tbFranchise
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbFranchise));

        const string Id = "Id";
        const string Active = "Active";
        const string Prefix = "Prefix";
        const string Supplier = "Supplier";


        public void FillFilterList(ToolStripComboBox cb) {
            cb.Items.Clear();
            cb.Items.Add("All");
            // add the Franshise
            DataTable tmp = Database.Instance.FillDataSet("select Prefix from Franchise where active = 'Y' order by prefix");
            for (int x = 0; x < tmp.Rows.Count; x++) {
                cb.Items.Add(new tbFranchiseItem((String)tmp.Rows[x][0]));
            }

            tmp = Database.Instance.FillDataSet("select supplier_id,name1 from supplier where active = 'Y' order by name1");
            for (int x = 0; x < tmp.Rows.Count; x++) {
                cb.Items.Add(new tbSupplierItem((long)tmp.Rows[x][0],"Cust:"+(String)tmp.Rows[x][1]));
            }
            


            cb.SelectedIndex = 0;
        }

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
            dC.ColumnName = Prefix;
            t.Columns.Add(dC);

            dC = new DataColumn();
            dC.ColumnName = Supplier;
            t.Columns.Add(dC);

            return t;
        }


        public void FillTable(DataGridView grid) {

            log.Debug("Fill Table Franchise");
            DataTable t = (DataTable)grid.DataSource;
            if (t == null) {
                t = EmptyTable();
            }
            DataTable tmp = Database.Instance.FillDataSet("select FRANCHISE_ID, franchise.Active , PREFIX, trim(name1) || ' ' ||name2 from franchise,supplier where franchise.supplier_id = supplier.supplier_id");
            for (int x = 0; x < tmp.Rows.Count; x++) {
                t.Rows.Add();
                t.Rows[x][Id] = tmp.Rows[x][0];
                t.Rows[x][Active] = tmp.Rows[x][1];
                t.Rows[x][Prefix] = tmp.Rows[x][2];
                t.Rows[x][Supplier] = tmp.Rows[x][3];
            }
            log.Debug("Rows Found " + grid.RowCount);

            grid.DataSource = t;
            grid.Columns[Id].Visible = false;
            grid.Columns[Active].Width = 50;
            grid.Columns[Active].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[Prefix].Width = 60;
            grid.Columns[Supplier].Width = 500;
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

        public bool Valid(String Franchise) {

            DataTable tmp = Database.Instance.FillDataSet("select FRANCHISE_ID  from franchise where prefix = '" + Franchise + "'");
            log.Debug("Verify Franchise: " + Franchise);

            return (tmp.Rows.Count == 1);
        }


        public void FillDrop(ComboBox cb) {
            DataTable tmp = Database.Instance.FillDataSet("select Prefix from Franchise where active = 'Y' order by prefix");
            for (int x = 0; x < tmp.Rows.Count; x++) {
                cb.Items.Add(new tbFranchiseItem((String)tmp.Rows[x][0]));
            }

        }
    }


    class tbFranchiseFilterItem
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(tbFranchiseFilterItem));

        String m_Prefix_Id = "";
        String m_Name1;
        tbSupplierItem m_supRecord;

        public tbFranchiseFilterItem(String Prefix_Id) {
            log.Debug("Franchise : " + Prefix_Id);
            m_Prefix_Id = Prefix_Id;
        }

        public tbFranchiseFilterItem(tbSupplierItem supRecord) {
            log.Debug("Supplier : " + supRecord.Id + " " + supRecord.ToString());
            m_supRecord = supRecord;
        }

        public override String ToString() {

            if (m_Prefix_Id == "") {
                return m_supRecord.ToString();
            }
            else {
                return m_Prefix_Id;
            }
        }

    }


    class tbFranchiseItem
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(tbFranchiseItem));

        String m_Prefix_Id;
        String m_Name1;

        public tbFranchiseItem(String Prefix_Id) {
            log.Debug("Franchise : " + Prefix_Id);
            m_Prefix_Id = Prefix_Id;
        }

        public override String ToString() {
            return m_Prefix_Id;
        }

    }

}
