using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEAManager
{
    public partial class FormOPEA : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FormOPEA));

        stOPEA st;

        private long Id;
        public FormOPEA(long opea_id) {
            Id = opea_id;
            InitializeComponent();
        }
        public FormOPEA() {
            Id = 0;
            InitializeComponent();
            st = new stOPEA();
        }

        private void FormOPEA_Load(object sender, EventArgs e) {
            FillDropLists();

            if (Id == 0) {
                log.Debug("Add Mode");
                comboSupplier.Enabled = true;
                comboFranchise.Enabled = false;
                radioButtonFranchise.Enabled = false;
                radioButtonSupplier.Enabled = true;
                radioButtonSupplier.Checked = true;
                // set value so check for changes is common function
                st.mPart = "";
                st.mDescription = "";
                textList.Text = st.mListPrice.ToString("$0.00");
                textRetail.Text = st.mRetailPrice.ToString("$0.00");

            }
            else {
                log.Debug("Edit Mode :" + Id.ToString());
                tbOpea op = new tbOpea();
                st = op.FetchRecord(Id);
                textPartNo.Text = st.mPart;
                textDescription.Text = st.mDescription;
                textList.Text = st.mListPrice.ToString("$0.00");
                textRetail.Text = st.mRetailPrice.ToString("$0.00");
                textBoxCreated.Text = st.mCreated.ToString("d/M/y HH:mm");
                textBoxUpdated.Text = st.mUpdated.ToString("d/M/y HH:mm");

                if (st.mType == stOPEATypes.Type.Fixed) {
                    comboSupplier.Enabled = false;
                    comboFranchise.Enabled = false;
                    comboFranchise.SelectedIndex = comboFranchise.FindString(st.mFranchise);
                    radioButtonFranchise.Checked = true;
                    radioButtonFranchise.Enabled = false;
                    radioButtonSupplier.Enabled = false;
                    textPartNo.ReadOnly = true;
                    textDescription.ReadOnly = true;
                }

            }
        }
        private void FillDropLists() {
            tbSupplier sp = new tbSupplier();
            sp.FillDrop(comboSupplier);
            tbFranchise fr = new tbFranchise();
            fr.FillDrop(comboFranchise);
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            if (Id == 0) {
                st.mPart = textPartNo.Text;
                st.mDescription = textDescription.Text;
                st.mType = stOPEATypes.Type.Supplier;
                st.mFranchise = "CUST";

                tbOpea op = new tbOpea();
                opeaLine ol = new opeaLine();
                ol.StructureToLine(st);
                op.InsertUpdate(ol);
                log.Debug("Add New");
            }
            else {
                st.mListPrice = 666;
                tbOpea op = new tbOpea();
                opeaLine ol = new opeaLine();
                ol.StructureToLine(st);
                op.InsertUpdate(ol);
                log.Debug("Update part");
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            if (OkToCancel()) {
                this.Close();
            }

        }

        private void FormOPEA_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                if (OkToCancel()) {
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.Return) {
                this.Close();
            }

        }
        private bool OkToCancel() {
            if (HasChanged()) {
                if (MessageBox.Show(this, "Loose your Changes", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    log.Debug("Change Cancelled");
                    return true;
                }
                return false;
            }
            return true;
        }

        /*****************************
         * see if any fields changed
         ****************************/
        private bool HasChanged() {
            if (!st.mPart.Equals(textPartNo.Text)) {
                return true;
            }
            if (!st.mDescription.Equals(textDescription.Text)) {
                return true;
            }

            if (!textList.Text.Equals(st.mListPrice.ToString("$0.00"))) {
                return true;
            }
            if (!textRetail.Text.Equals(st.mRetailPrice.ToString("$0.00"))) {
                return true;
            }
            return false;
        }
    }
}
