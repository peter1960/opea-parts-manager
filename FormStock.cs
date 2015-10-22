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
    public partial class FormStock : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FormStock));

        public FormStock() {
            log.Debug("Started");
            InitializeComponent();
        }
        public String PartName {
            get {
                return labelItemName.Text;
            }
            set {
                labelItemName.Text = value;
            }
        }
        public Decimal Qty {
            get {
                return Decimal.Parse(textBoxQty.Text);
            }
            set {
                textBoxQty.Text = value.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormStock_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }
    }
}
