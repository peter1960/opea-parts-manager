using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPEAManager
{
    public struct stCompany
    {
        public String Address1;
        public String Address2;
        public String Name1;
        public String Name2;
        public String Phone1;
        public String Phone2;
        public String City;
        public String State;
        public String URL;

    }
    public struct stSupplier
    {
        public int Supplier_id;
        public String Active;
        public String Address1;
        public String Address2;
        public String Name1;
        public String Name2;
        public String Phone1;
        public String Phone2;
        public String City;
        public String State;
        public String URL;
    
    }
    public struct stFranchise
    {
        public int Franschise_id;
        public String Prefix;
        public String Custom;
        public String Active;
        public int Supplier_id;
    }

    public struct stVersion
    {
        public int Ver;
    }
}
