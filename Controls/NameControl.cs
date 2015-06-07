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
    public partial class NameControl : UserControl
    {
        public NameControl() {
            InitializeComponent();
            input1.SetLabel = "Name";
            input2.HasLabel = false;
        }
    }
}
