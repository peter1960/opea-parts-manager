using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;





namespace OPEAManager
{
    class opeaLine
    {
        private stOPEA oLine;
        private static readonly ILog log = LogManager.GetLogger(typeof(opeaLine));
#if DEBUG
        public opeaLine() {
            log.Debug("New Line");
        }
#endif
        public void ParseLine(String opeaText) {
            oLine.Valid = true;
            
            oLine.mType = stOPEATypes.Type.Fixed;
            oLine.mFranchise_id = opeaText.Substring(0, 4);
            oLine.mEffectiveDate = opeaText.Substring(4, 6);
            oLine.mPart = opeaText.Substring(10, 20);
            oLine.mClean = clean(oLine.mPart);
            oLine.mDescription = quotes(opeaText.Substring(30, 35));
            oLine.mListPrice = Decimal.Parse(addPoint(opeaText.Substring(65, 10)));
            oLine.mRetailPrice = Decimal.Parse(addPoint(opeaText.Substring(75, 10)));
            oLine.mDiscountCode = opeaText.Substring(85, 2);
            oLine.mSupercession = opeaText.Substring(87, 20);
            oLine.mStatus = opeaText.Substring(107, 1);
            oLine.mTaxCode = opeaText.Substring(108, 1);
            oLine.mStockingCode = opeaText.Substring(109, 1);
            oLine.mMinOrder = Int16.Parse(opeaText.Substring(110, 4));
            oLine.mClass = opeaText.Substring(114, 4);
            oLine.mFiller = "";// line.substring(118, 126);
              
        }
        public void StructureToLine(stOPEA opeaST) {
            log.Debug("Structure convert");
            oLine.mType = opeaST.mType;
            oLine.mPart = opeaST.mPart;
            oLine.mClean = clean(oLine.mPart);
            oLine.mFranchise_id = opeaST.mFranchise_id;
            oLine.mSupplier_id = opeaST.mSupplier_id;
            oLine.mDescription = quotes(opeaST.mDescription);
            oLine.OPEA_id = opeaST.OPEA_id;
            oLine.mListPrice = opeaST.mListPrice;
            oLine.mRetailPrice = opeaST.mRetailPrice;

        }

        public string PartNo {
            get { return oLine.mPart; }
        }

        public long OPEA_id {
            get { return oLine.OPEA_id; }
        }


        public string Franchise {
            get {
                return oLine.mFranchise_id;
            }
        }
        public long Supplier {
            get {
                return oLine.mSupplier_id;
            }
        }
        public string EffectiveDate {
            get {
                return oLine.mEffectiveDate;
            }
        }
        public string Clean {
            get {
                return oLine.mClean;
            }
        }
        public string Description {
            get {
                return oLine.mDescription;
            }
        }
        public Decimal ListPrice {
            get {
                return oLine.mListPrice;
            }
        }
        public Decimal RetailPrice {
            get {
                return oLine.mRetailPrice;
            }
        }
        public string DiscountCode {
            get {
                return oLine.mDiscountCode;
            }
        }
        public string Supercession {
            get {
                return oLine.mSupercession;
            }
        }
        public string Status {
            get {
                return oLine.mStatus;
            }
        }
        public string TaxCode {
            get {
                return oLine.mTaxCode;
            }
        }
        public string StockingCode {
            get {
                return oLine.mStockingCode;
            }
        }
        public int MinOrder {
            get {
                return oLine.mMinOrder;
            }
        }
        public string Class {
            get {
                return oLine.mClass;
            }
        }
        public stOPEATypes.Type Type {
            get {
                return oLine.mType;
            }
        }

        public stOPEA FullData {
            get {
                return oLine;
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
            return result.ToUpper();
        }
        private String quotes(String part) {
            String result = part.Replace("'", " ");
            return result;
        }
    }
}
