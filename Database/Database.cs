using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using log4net;

namespace OPEAManager
{

    public sealed class Database
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Database));

        private static Database instance = null;
        private static readonly object padlock = new object();
        private static SQLiteConnection sql_con;
        private static SQLiteCommand sql_cmd;
        private static SQLiteDataAdapter DB;
        private static SQLiteTransaction Trans;
        private static Boolean TransOpen;
        private Database() {
            sql_con = new SQLiteConnection("Data Source=c:\\data\\opea.db;Version=3;New=True;Compress=True;");
            sql_con.Open();
            TransOpen = false;

        }
        static SQLiteConnection GetCon() {
            return sql_con;
        }
        static Database() {
            instance = new Database();
        }
        ~Database() {
            //sql_con.Close();
        }

        //public void DumpEvents() {
        //    long totLast = 0;
        //    long val;
        //    sql_cmd = sql_con.CreateCommand();


        //    sql_cmd.CommandText = "select * from log order by event,date";
        //    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\data\events.txt")) {
        //        SQLiteDataReader r = sql_cmd.ExecuteReader();
        //        while (r.Read()) {
        //            //val = Max(totLast,(Int64)r["val"]);
        //            //Only write the max lines
        //            //if (val == (Int64)r["val"]) {
        //            val = (Int64)r["val"];
        //            file.WriteLine((string)r["event"] + " " + (string)r["date"] + "," + val+ "," + (val-totLast));
        //            totLast = val;

        //        }
        //    }

        //}
        //public void DumpSummary() {
        //    sql_cmd = sql_con.CreateCommand();


        //    sql_cmd.CommandText = "select count(*), event from log where type = 'G' group by event";
        //    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\data\summary.txt")) {
        //        file.WriteLine("Grid events");
        //        SQLiteDataReader r = sql_cmd.ExecuteReader();
        //        while (r.Read()) {
        //                file.WriteLine((string)r["event"] + " " + (Int64)r[0] );
        //            }

        //        }
        //            }
        private long Max(long val1, long val2) {
            if (val1 > val2) {
                return val1;
            }
            return val2;
        }
        public void BeginTrans() {
            Trans = sql_con.BeginTransaction();
            TransOpen = true;
        }
        public void CommitTrans() {
            if (TransOpen) {
                Trans.Commit();
                TransOpen = false;
            }
        }
        public void ExecuteNonQuery(string txtQuery) {
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
        }

        public DataTable FillDataSet(string txtQuery) {
            log.Debug("Execute " + txtQuery);
            DataSet DS = new DataSet();
            //            sql_cmd = sql_con.CreateCommand();
            DB = new SQLiteDataAdapter(txtQuery, sql_con);
            DS.Reset();
            try {
                DB.Fill(DS);
            }
            catch (System.Data.SQLite.SQLiteException ex) {
                throw ex;
            }
            return DS.Tables[0];

        }

        public static Database Instance {
            get {
                return instance;
            }

        }
    }

}
