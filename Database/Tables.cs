using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace OPEAManager
{
    class Tables
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Tables));
        public void CreateTables() {
            log.Debug("Start Create Tables");

            String sql = "PRAGMA  foreign_keys = 1";
            Database.Instance.ExecuteNonQuery(sql);
            CreateVersion();
            CreateLocations();
            CreateOpea();
            CreateSupplier();
            CreateFranchise();
            CreateOrderHeader();
            CreateOrderDetail();
            CreateStock();
            CreateCustomer();
            CreateAccount();
            CreateCompany();
            log.Debug("End Create Tables");
        }
        public void CreateVersion() {
            log.Info(" Adding version Table");
            String sql = "DROP TABLE if exists `version`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE `version` (`VER_ID` INTEGER PRIMARY KEY AUTOINCREMENT, `VER` INTEGER);";
            Database.Instance.ExecuteNonQuery(sql);

            log.Info(" Adding a version after reset");

            stVersion Record = new stVersion();
            Record.Ver = 1;
            tbVersion sp = new tbVersion();
            sp.Update(Record);

        }
        public void CreateLocations() {
            log.Info(" Adding Locations Table");
            String sql = "DROP TABLE if exists `locations`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE `locations` (`LOCATION_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`NAME` TEXT,`DESCR` TEXT,`QTY` INT,`UPPER_NAME` TEXT);";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "insert into `locations` (`NAME` ,`DESCR` ,`QTY` ,`UPPER_NAME` ) values ('Default','Default Location',0,'DEFAULT');";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateOpea() {
            log.Info(" Adding Opea Table");
            String sql = "DROP TABLE if exists `opea`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE opea (`OPEA_ID` INTEGER PRIMARY KEY AUTOINCREMENT,TYPE TEXT default 'C',COMPANYID TEXT default NULL,EFFECTIVEDATE TEXT default NULL,DIRTY BOOLEAN default NULL,PARTNO varchar(20) default NULL,DESCRIPTION varchar(35) default NULL,LISTPRICE double default NULL,RETAILPRICE double default NULL,DISCOUNTCODE varchar(2) default NULL,SUPERCESSION varchar(20) default NULL,STATUS varchar(1) default NULL,TAXCODE varchar(1) default NULL,STOCKINGCODE varchar(1) default NULL,MINORDER int default NULL,CLASS varchar(4) default NULL,CLEANPART varchar(20) default NULL);";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE UNIQUE INDEX opea_idx1 on opea (partno asc);";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateFranchise() {
            log.Info(" Adding Franchise Table");
            String sql = "DROP TABLE if exists `franchise`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE franchise (`FRANCHISE_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`PREFIX` TEXT,`CUSTOM` TEXT default 'C',`ACTIVE` TEXT, `DESCRIPTION` TEXT, `SUPPLIER_ID` INTEGER, FOREIGN KEY(SUPPLIER_ID) REFERENCES SUPPLIER(SUPPLIER_ID) );";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE UNIQUE INDEX franchise_idx1 on franchise (prefix asc);";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateSupplier() {
            log.Info(" Adding Supplier Table");
            String sql = "DROP TABLE if exists `supplier`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE supplier (`SUPPLIER_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`ACTIVE` TEXT, `ADDRESS1` TEXT ,`ADDRESS2` TEXT ,`NAME1` TEXT,`NAME2` TEXT,`PHONE1` TEXT, `PHONE2` TEXT, `URL` TEXT, `CONTACT` TEXT);";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateOrderHeader() {
            log.Info(" Adding Order Header Table");
            String sql = "DROP TABLE if exists `orderheader`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE orderheader (`HEADER_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`SUPPLIER_ID` INTEGER ,`ORDER_STATUS` TEXT ,`ORDER_DATE` TEXT,`ORDER_ETA` TEXT);";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateOrderDetail() {
            log.Info(" Adding Order Details Table");
            String sql = "DROP TABLE if exists `orderdetail`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE orderdetail (`DETAIL_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`HEADER_ID` INTEGER ,`OPEA_ID` INTEGER ,`CUSTOMER_ID` INTEGER ,`ORDER_STATUS` TEXT ,`ORDER_DATE` TEXT,`COST` REAL);";
            Database.Instance.ExecuteNonQuery(sql);
        }
        public void CreateStock() {
            log.Info(" Adding Stock Table");
            String sql = "DROP TABLE if exists `stock`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = "CREATE TABLE stock (`STOCK_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`LOCATION_ID` INTEGER ,`OPEA_ID` INTEGER ,`QTY` INTEGER ,`CHECKED_DATE` TEXT);";
            Database.Instance.ExecuteNonQuery(sql);

        }
        public void CreateCustomer() {
            log.Info(" Adding Customer Table");

        }
        public void CreateAccount() {
            log.Info(" Adding Account Table");

        }
        public void CreateCompany() {
            log.Info(" Adding Company Table");
            String sql = "DROP TABLE if exists `company`";
            Database.Instance.ExecuteNonQuery(sql);
            sql = @"CREATE TABLE company (`COMPANY_ID` INTEGER PRIMARY KEY AUTOINCREMENT,`ADDRESS1` TEXT ,
`ADDRESS2` TEXT ,`NAME1` TEXT ,`NAME2` TEXT ,`PHONE1` TEXT,`PHONE2` TEXT,`CITY` TEXT,`STATE` TEXT,`URL` TEXT);";
            Database.Instance.ExecuteNonQuery(sql);

#if DEBUG
            log.Debug(" Adding a Company record after reset");

            stCompany Record = new stCompany();
            Record.Address1 = "27 Master Street";
            Record.Name1 = "Johns Cycles";
            Record.City = "Drouin";
            Record.State = "Victoria";
            Record.Phone1 = "555-234588";
            Record.URL = "Http://myfastcsyles.com.au";
            tbCompany sp = new tbCompany();
            sp.Update(Record);
#endif
        }
    }
}
