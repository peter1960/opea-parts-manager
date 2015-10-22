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
using System.IO;
using System.Media;

namespace OPEAManager
{
    public partial class Main : Form
    {

        // Create a logger for use in this class
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));
        splash sp;
        private SQLiteConnection sql_con;
        public Main() {
            XmlConfigurator.Configure(new System.IO.FileInfo(@"log4net.xml"));
            log.Info("====================== Application Start ======================");
#if !DEBUG
            sp = new splash();
            sp.Show();
#endif
            InitializeComponent();
            Main_Resize(null, null);

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {

        }

        private void buttonSystemReset_Click(object sender, EventArgs e) {
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
            fr.FillFilterList(toolStripFranchise);

            tbOpea db = new tbOpea();
            db.FillTable(0, 1000, dataGridStock, false);
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.FileName = Properties.Settings.Default.OPEAPath;
            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == System.Windows.Forms.DialogResult.OK) {
                Properties.Settings.Default.OPEAPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                this.Cursor = Cursors.WaitCursor;

                log.Info("Load Started ");

                toolStripStatusLabel1.Text = "OPEA Load Started";
                statusStrip1.Refresh();
                opeaFile of = new opeaFile();
                stErr res = of.LoadFile(openFileDialog1.FileName);
                switch (res) {
                    case stErr.OK: {
                            toolStripStatusLabel1.Text = "OPEA Load Done";
                            log.Info("Load Complete ");
                            break;
                        }
                    case stErr.FRANCHISE1: {
                            toolStripStatusLabel1.Text = "Bad OPEA file or Franchise undefined, cancelled";
                            log.Error("Load Cancelled ");
                            break;
                        }
                }
                statusStrip1.Refresh();
                this.Cursor = Cursors.Default;
                SetupStockTab();
            }
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
            Search();
        }

        private void buttonStockSearch_Click(object sender, EventArgs e) {
            log.Debug("Stocked Search");
            Search();
        }

        private void buttonStockReset_Click(object sender, EventArgs e) {
            log.Debug("Reset Search");
            textStockSearch.Text = "";
            checkBoxStocked.Checked = false;
            Search();
        }

        private void Search() {
            tbOpea db = new tbOpea();
            db.FillTable(0, Properties.Settings.Default.StockRows, dataGridStock, checkBoxStocked.Checked, textStockSearch.Text.Trim());
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
                op.UpdateStock((String)Row[0].Cells[0].Value, fs.Qty);
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
            log.Debug("Edit Row: " + Row[0].Index);
            String sOPEA_ID = (String)Row[0].Cells[0].Value;
            FormOPEA fm = new FormOPEA(long.Parse(sOPEA_ID));
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Search();
                //dataGridStock.Rows[Row[0].Index].Selected = true;
                //dataGridStock.Rows[Row[0].Index].Visible = true;
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e) {
            FormOPEA fm = new FormOPEA();
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Search();
            }

        }

        private void buttonBackup_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            log.Debug("Backup Started");
            toolStripStatusLabel1.Text = "Backup Started";
            statusStrip1.Refresh();
            DateTime dt = DateTime.Now; // Or whatever
            string s = dt.ToString("yyyyMMddHHmm");
            string dbPath = Properties.Settings.Default.DatabasePath;
            string cFile = dbPath + "\\opea.db";
            File.Copy(cFile, dbPath + "\\backup\\opea.db." + s);
            toolStripStatusLabel1.Text = "Backup Ended";
            log.Debug("Backup Ended");
            statusStrip1.Refresh();
            this.Cursor = Cursors.Default;

        }

        private void Main_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5) {
                log.Debug("Pressed F5");
            }
            if (e.KeyCode == Keys.F6) {
                log.Debug("Pressed F6");
            }
            if (e.KeyCode == Keys.F7) {
                log.Debug("Pressed F7");
                toolStripButtonEdit_Click(null, null);
            }
            if (e.KeyCode == Keys.F8) {
                log.Debug("Pressed F8");
                toolStripButtonAdd_Click(null, null);
            }
            if (e.KeyCode == Keys.Down) {
                log.Debug("Pressed Down");
                DataGridViewSelectedRowCollection Row = dataGridStock.SelectedRows;
                int nRow = Row[0].Index;
                if (nRow < (Properties.Settings.Default.StockRows - 1)) {
                    dataGridStock.Rows[nRow].Selected = false;
                    dataGridStock.Rows[++nRow].Selected = true;
                    dataGridStock.FirstDisplayedScrollingRowIndex = nRow;
                }
                else {
                    SystemSounds.Beep.Play();
                }

                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up) {
                log.Debug("Pressed Up");
                DataGridViewSelectedRowCollection Row = dataGridStock.SelectedRows;
                int nRow = Row[0].Index;
                if (nRow > 0) {
                    dataGridStock.Rows[nRow].Selected = false;
                    dataGridStock.Rows[--nRow].Selected = true;
                }
                else {
                    SystemSounds.Beep.Play();
                }
                e.SuppressKeyPress = true;
            }
        }

    }
}
