using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace OPEAManager
{
    class StockDocument : System.Drawing.Printing.PrintDocument

    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StockDocument));

    }
}
