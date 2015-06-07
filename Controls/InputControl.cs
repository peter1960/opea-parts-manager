using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEAManager
{
    public partial class InputControl : UserControl
    {
        public InputControl() {
            InitializeComponent();
            
        }
        public bool HasLabel {
            set {
                txtLabel.Visible = value;
            }
        }
        public String SetLabel {
            set {
                txtLabel.Text  = value;
            }
        }
        public String txtValue {
            set {
                textInput.Text = value;
            }
            get {
                return textInput.Text;
            }
        }
    }
}
