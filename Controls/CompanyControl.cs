using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEAManager.Controls
{
    public partial class CompanyControl : UserControl
    {
        private stCompany Data;

        public CompanyControl() {
            InitializeComponent();
            inputURL.SetLabel = "URL";
        }

        public stCompany recValue {
            set {
                //Data = value;
                inputURL.txtValue = value.URL;
                addressControl1.Add1 = value.Address1;
                addressControl1.Add2 = value.Address2;
                addressControl1.City = value.City;
                addressControl1.State = value.State;
                nameControl1.Name1 = value.Name1;
                nameControl1.Name2 = value.Name2;
                phoneControl1.Phone1 = value.Phone1;
                phoneControl1.Phone2 = value.Phone2;

            }
            get {
                return Data;
            }
        }
    }
}
