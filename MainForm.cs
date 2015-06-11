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

        private SQLiteConnection sql_con;
        public Main()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            tbVersion tv = new tbVersion();
            if (tv.Version() == 0) {
                Tables tb = new Tables();
                tb.CreateTables();

            }
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure(new System.IO.FileInfo(@"log4net.xml"));
            log.Info("Application Start");
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
            Tables tb = new Tables();
            tb.CreateTables();
            //Database.Instance.CreateTables();
            toolStripStatusLabel1.Text = "Reset Done";
            log.Info("Reset Database");

            statusStrip1.Refresh();
        }

        private void SetupStockTab() {

            tbFranchise fr = new tbFranchise();
            fr.FillList(toolStripFranchise);

            tbOpea db = new tbOpea();
            db.FillTable(0, 1000, dataGridStock);
        }

        private void SetupSupplierTab() {

            tbSupplier fr = new tbSupplier();
            fr.FillTable(dataGridSuppliers);
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
            MainTabControl.Height = this.Height - 104;
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


    }
}
