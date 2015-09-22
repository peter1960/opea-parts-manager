using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using log4net;
using log4net.Config;


namespace OPEAManager
{
    public partial class Main : Form
    {
        
        // Create a logger for use in this class
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));
        splash sp;
        private SQLiteConnection sql_con;
        public Main()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(@"log4net.xml"));
            log.Info("====================== Application Start ======================");

            sp = new splash();
            sp.Show();

            InitializeComponent();
            Main_Resize(null,null);

            this.Cursor = Cursors.WaitCursor;

            tbVersion tv = new tbVersion();
            //Dump the version to the logs
            tv.DBVersion();

            if (tv.Version() == 0) {
                log.Info("No Version so new system");
                Tables tb = new Tables();
                tb.CreateTables();

            }
            //BasicConfigurator.Configure();
            //tbVersion v = new tbVersion();
            //v.Version();
            SetupFranchiseTab();
            SetupSupplierTab();
            SetupCompanyTab();
            SetupStockTab();
            this.Cursor = Cursors.Default;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSystemReset_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Tables tb = new Tables();
            tb.CreateTables();
            //Database.Instance.CreateTables();
            toolStripStatusLabel1.Text = "Reset Done";
            log.Info("Reset Database");

            statusStrip1.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void SetupStockTab() {

            tbFranchise fr = new tbFranchise();
            fr.FillList(toolStripFranchise);

            tbOpea db = new tbOpea();
            db.FillTable(0, 1000, dataGridStock,false);
        }

        private void SetupSupplierTab() {

            tbSupplier fr = new tbSupplier();
            fr.FillTable(dataGridSuppliers);
        }

        private void SetupFranchiseTab() {

            tbFranchise fr = new tbFranchise();
            fr.FillTable(dataGridFranchise);
        }


        private void SetupCompanyTab() {
            tbCompany cm = new tbCompany();
            companyControl1.recValue = cm.Fetch();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e) {
            log.Debug("Selected Changed " + e.TabPage.ToString());

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            log.Debug("Index Changed " + e.ToString());

        }

        private void dataGridStock_NewRowNeeded(object sender, DataGridViewRowEventArgs e) {
            log.Debug("Row Needed " + e.ToString());

        }

        private void Main_Resize(object sender, EventArgs e) {
            MainTabControl.Width = this.Width - 12;
            MainTabControl.Height = this.Height - 80;
            dataGridStock.Height = this.Height - 148;
        }

        private void OPEA_Load_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            log.Debug("Load Started ");
            toolStripStatusLabel1.Text = "OPEA Load Started";
            statusStrip1.Refresh();
            opeaFile of = new opeaFile();
            of.LoadFile("c:\\data\\KAWAMC01.dat");
            toolStripStatusLabel1.Text = "OPEA Load Done";
            log.Debug("Load Complete ");
            statusStrip1.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void buttonComanySave_Click(object sender, EventArgs e) {
            log.Debug("Save Company");
            tbCompany cp = new tbCompany();
            cp.Update(companyControl1.recValue);
            
        }

        private void buttonTabSupplierAdd_Click(object sender, EventArgs e) {
            log.Debug("Add Supplier");
        }

        private void dataGridStock_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void checkBoxStocked_CheckedChanged(object sender, EventArgs e) {
            log.Debug("Stocked filter toggled");
            tbOpea db = new tbOpea();
            db.FillTable(0, 1000, dataGridStock, checkBoxStocked.Checked, textStockSearch.Text.Trim());

        }

        private void buttonStockSearch_Click(object sender, EventArgs e) {
            log.Debug("Stocked Search");
            tbOpea db = new tbOpea();
            db.FillTable(0, 1000, dataGridStock, checkBoxStocked.Checked, textStockSearch.Text.Trim());

        }


        private void toolStripButtonCart_Click(object sender, EventArgs e) {
            log.Debug("Cart Pressed");

        }

        private void toolStripButtonStock_Click(object sender, EventArgs e) {
            log.Debug("Stock Pressed");
            FormStock fs = new FormStock();
            DataGridViewSelectedRowCollection Row = dataGridStock.SelectedRows;
            String name = (String)Row[0].Cells[3].Value;
            decimal qty = 0;
            // with invalid cast then the value was null
            // and wil now be set to "0"
            try {
                qty = (decimal)Row[0].Cells[6].Value;
            }
            catch (InvalidCastException ex) {
                log.Debug("null qty");
            }
            fs.PartName = name;
            fs.Qty = qty;
            if (fs.ShowDialog(this) == DialogResult.OK) {
                log.Debug(Row[0].Cells[0].Value);
                Row[0].Cells[6].Value = fs.Qty;
                tbStock op = new tbStock();
                op.UpdateStock((String)Row[0].Cells[0].Value,fs.Qty);
            }
            fs.Dispose();
        }

        private void stockLevelsToolStripMenuItem_Click(object sender, EventArgs e) {
            StockDocument ps = new StockDocument();
            PrintDialog printdlg = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.Document = ps;
            printPrvDlg.Width = 300;
            printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below

            //printdlg.Document = ps;

            //if (printdlg.ShowDialog() == DialogResult.OK) {
               // ps.Print();
           // }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection Row = dataGridStock.SelectedRows;
            String sOPEA_ID = (String)Row[0].Cells[0].Value;
            FormOPEA fm = new FormOPEA(long.Parse (sOPEA_ID));
            fm.ShowDialog();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e) {
            FormOPEA fm = new FormOPEA();
            fm.ShowDialog();
        }




    }
}
