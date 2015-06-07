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
    public partial class AddressControl : UserControl
    {
        public AddressControl() {
            InitializeComponent();
            input1.SetLabel = "Address";
            input2.HasLabel = false;
        }
    }
}
