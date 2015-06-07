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
            inputAddress1.SetLabel = "Address";
            inputAddress2.HasLabel = false;
            inputCity.SetLabel = "City";
            inputState.SetLabel = "State";
        }
    }
}
