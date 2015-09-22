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
        const double maxSplash = 10.0;
        private static readonly ILog log = LogManager.GetLogger(typeof(splash));
        int count = 0;
        public splash() {
            log.Debug("Splash Create");
            InitializeComponent();
            this.Show();
            this.Refresh();
            Thread.Sleep(1000);
            splashtimer.Start();

        }

        private void splashtimer_Tick(object sender, EventArgs e) {
            if (count > maxSplash) {
                log.Debug("Splash Done");
                splashtimer.Stop();
                this.Close();
            }
            double t = count / maxSplash;
            this.Opacity = 1.0 - t;
            count++;
        }
    }
}
