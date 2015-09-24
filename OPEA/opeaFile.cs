using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;


namespace OPEAManager
{
    class opeaFile
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(opeaFile));

        public stErr LoadFile(String fileName) {
            log.Info("Loading: " + fileName);
            opeaLine ol = new opeaLine();
            using (TextReader sr = File.OpenText(fileName)) {
                String line;

                // first line is just a dummy
                // but will be used to verify the franchise before 
                // the entire file is loaded

                line = sr.ReadLine();

                String Franchise = line.Substring(0, 4);
                tbFranchise tbf = new tbFranchise();
                if (!tbf.Valid(Franchise)) {
                    log.Error("Franchise is not setup, load cancelled");
                    sr.Close();
                    return stErr.FRANCHISE1;

                }

                tbOpea dbs = new tbOpea();
                int nCount = 0;
                int nTotal = 0;
                Database.Instance.BeginTrans();
                while ((line = sr.ReadLine()) != null ) {
                    ol.ParseLine(line);
                    dbs.InsertUpdate(ol);
                    nCount++;
                    nTotal++;
                    if (nCount >= 1000) {
                        Database.Instance.CommitTrans();
                        Database.Instance.BeginTrans();
                        nCount = 0;
                        log.Debug("     Committed :" + nTotal);
                    }

                }
                Database.Instance.CommitTrans();
                log.Debug("Committed :" + nTotal);
                Database.Instance.ExecuteNonQuery("vacuum;");
                return stErr.OK;
            }
        }


    }
}

