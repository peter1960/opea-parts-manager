using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace OPEAManager
{
    class opeaLine
    {
        private String mFranchise;
        private String mPart;
        private String mClean;
        private String mDescription;
        private Boolean Valid = true;
        private String mEffectiveDate;
        private String mListPrice;
        private String mRetailPrice;
        private String mDiscountCode;
        private String mSupercession;
        private String mStatus;
        private String mTaxCode;
        private String mStockingCode;
        private int mMinOrder;
        private String mClass;
        private String mFiller;
        private String mCode;
        private String mType = "F";

        public void ParseLine(String opeaText) {
            mFranchise = opeaText.Substring(0, 4);
            mEffectiveDate = opeaText.Substring(4, 6);
            mPart = opeaText.Substring(10, 20);
            mClean = clean(mPart);
            mDescription = quotes(opeaText.Substring(30, 35));
            mListPrice = addPoint(opeaText.Substring(65, 10));
            mRetailPrice = addPoint(opeaText.Substring(75, 10));
            mDiscountCode = opeaText.Substring(85, 2);
            mSupercession = opeaText.Substring(87, 20);
            mStatus = opeaText.Substring(107, 1);
            mTaxCode = opeaText.Substring(108, 1);
            mStockingCode = opeaText.Substring(109, 1);
            mMinOrder = Int16.Parse(opeaText.Substring(110, 4));
            mClass = opeaText.Substring(114, 4);
            mFiller = "";// line.substring(118, 126);

        }
        public string PartNo {
            get { return mPart; }
        }

        public string Franchise {
            get {
                return mFranchise;
            }
        }
        public string EffectiveDate {
            get {
                return mEffectiveDate;
            }
        }
        public string Clean {
            get {
                return mClean;
            }
        }
        public string Description {
            get {
                return mDescription;
            }
        }
        public string ListPrice {
            get {
                return mListPrice;
            }
        }
        public string RetailPrice {
            get {
                return mRetailPrice;
            }
        }
        public string DiscountCode {
            get {
                return mDiscountCode;
            }
        }
        public string Supercession {
            get {
                return mSupercession;
            }
        }
        public string Status {
            get {
                return mStatus;
            }
        }
        public string TaxCode {
            get {
                return mTaxCode;
            }
        }
        public string StockingCode {
            get {
                return mStockingCode;
            }
        }
        public int MinOrder {
            get {
                return mMinOrder;
            }
        }
        public string Class {
            get {
                return mClass;
            }
        }
        public string Type {
            get {
                return mType;
            }
        }

        /**
         * The price does not contain the decimal so it's
         * added at the correct place
         **/
        private String addPoint(String cost) {
            int len = cost.Length;
            return cost.Substring(0, len - 2) + "." + cost.Substring((len - 2), 2);

        }
        /**
         * Remove any non alpa characters in the part for
         * searching
         **/
        private String clean(String part) {
            String result = part.Replace(" ", "");
            result = result.Replace("`", "");
            result = result.Replace("-", "");
            return result;
        }
        private String quotes(String part) {
            String result = part.Replace("'", " ");
            return result;
        }
    }
}
