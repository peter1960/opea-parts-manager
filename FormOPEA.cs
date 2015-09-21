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

        private long Id;
        public FormOPEA(long opea_id) {
            Id = opea_id;
            InitializeComponent();
        }
        public FormOPEA() {
            Id = 0;
            InitializeComponent();
        }

        private void FormOPEA_Load(object sender, EventArgs e) {
            FillDropLists();

            if (Id == 0) {
                log.Debug("Add Mode");
            }
            else {
                log.Debug("Edit Mode :" + Id.ToString());
                tbOpea op = new tbOpea();
                stOPEA st = op.FetchRecord(Id);
                textPartNo.Text = st.mPart;
                textDescription.Text = st.mDescription;
                textList.Text = st.mListPrice.ToString("$0.00");
                textRetail.Text = st.mRetailPrice.ToString("$0.00");
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
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
