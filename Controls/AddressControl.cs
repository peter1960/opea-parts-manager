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
        public string Add1 {
            set {
                inputAddress1.txtValue  = value;
            }
            get {
                return inputAddress1.txtValue;
            }
        }
        public string Add2 {
            set {
                inputAddress2.txtValue = value;
            }
            get {
                return inputAddress2.txtValue;
            }
        }
        public string City {
            set {
                inputCity.txtValue = value;
            }
            get {
                return inputCity.txtValue;
            }
        }
        public string State {
            set {
                inputState.txtValue = value;
            }
            get {
                return inputState.txtValue;
            }
        }
    }
}
