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
    public partial class PhoneControl : UserControl
    {
        public PhoneControl() {
            InitializeComponent();
            input1.SetLabel = "Phone";
            input2.HasLabel = false;
        }

        public string Phone1 {
            set {
                input1.txtValue = value;
            }
            get {
                return input1.txtValue;
            }
        }
        public string Phone2 {
            set {
                input2.txtValue = value;
            }
            get {
                return input2.txtValue;
            }
        }

    }
}
