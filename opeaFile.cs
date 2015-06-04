using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEAManager
{
    class opeaFile
    {
        public void LoadFile(String fileName) {
            opeaLine ol = new opeaLine();
            using (TextReader sr = File.OpenText(fileName)) {
                String line;
                line = sr.ReadLine();
                //			Franshise = str.substring(0, 4);
                //Mode = str.substring(107, 108);
                //logger.debug("Franchise: " + Franshise);
                //if (!IsFranchiseOk(Franshise)) {
                //    in.close();
                //    fireXXX(new eventProgress(this, "ERR1:"));
                //    return;
                //}

                //// mark all records dirty if this is a "R" replace file
                //if (Mode.equals("R")) {
                //    logger.debug("Replace Mode");
                //    MarkDirty(Franshise);
                //} else {
                //    logger.debug("Update Mode");

                //}

                //try {
                dbOpea dbs = new dbOpea();
                int nCount = 0;
                Database.Instance.BeginTrans();
                while ((line = sr.ReadLine()) != null ) {
                    ol.ParseLine(line);
                    dbs.Insert(ol,1);
                    nCount++;
                    if (nCount > 1000) {
                        Database.Instance.CommitTrans();
                        Database.Instance.BeginTrans();
                        nCount = 0;
                    }

                }
                Database.Instance.CommitTrans();
                Database.Instance.ExecuteNonQuery("vacuum;");
                //Console.WriteLine(line);
            }
            //}
            //catch (Exception e) {
            //    MessageBox.Show(e.Message, "LogScanner", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //}
        }


    }
}

