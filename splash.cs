using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using log4net;
using log4net.Config;

namespace OPEAManager
{
    public partial class splash : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(splash));
        int count = 0;
        public splash() {
            //XmlConfigurator.Configure(new System.IO.FileInfo(@"log4net.xml"));
            log.Debug("Splash Create");
            InitializeComponent();
            Thread.Sleep(1000);
            splashtimer.Start();

        }

        private void splashtimer_Tick(object sender, EventArgs e) {
            if (count > 30) {
                log.Debug("Splash Done");
                splashtimer.Stop();
                this.Close();
            }
            if (count > 15) {
                double t = ((15.0 / (count-15)) );
                this.Opacity = t;
                this.Refresh();
                log.Debug(t);
            }
            count++;
        }
    }
}
