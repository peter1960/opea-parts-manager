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

    public struct stOPEA
    {
        public long OPEA_id;
        public String mFranchise_id;
        public long mSupplier_id;
        public String mPart;
        public String mClean;
        public String mDescription;
        public Boolean Valid;
        public String mEffectiveDate;
        public Decimal mListPrice;
        public Decimal mRetailPrice;
        public String mDiscountCode;
        public String mSupercession;
        public String mSuperceeds;
        public String mStatus;
        public String mTaxCode;
        public String mStockingCode;
        public int mMinOrder;
        public String mClass;
        public String mFiller;
        public String mCode;
        public DateTime mCreated;
        public DateTime mUpdated;
        public stOPEATypes.Type mType;

    }
    public struct stOPEATypes
    {
        public enum Type{
            Fixed,
            Custom,
            Supplier
        }
    }
    public struct stVersion
    {
        public int Ver;
    }
}
