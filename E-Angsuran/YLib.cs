using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.IO;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace E_Angsuran
{
    class YLib
    {
        //private static string connstr = @"Server=DESKTOP-CILQ20R\SQLSERVER;Database=Angsuran;Uid=sa;Password=smkn8smg;Trusted_Connection=true;";
        string[] arrayConsstr = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "/ConnectionSettings.txt").Split(';');

        SqlConnection conn;
        SqlCommand cmd;
        SqlTransaction trans;

        public YLib()
        {
            string connstr = @"Server=" + this.arrayConsstr[0] +
                ";Uid=" + this.arrayConsstr[1] +
                ";Password=" + this.arrayConsstr[2] +
                ";Database=" + this.arrayConsstr[3] +
                ";Trusted_Connection=" + this.arrayConsstr[4] + ";";
            conn = new SqlConnection(connstr);
        }

        public void conn_open()
        {
            conn.Open();
        }

        public void conn_close()
        {
            conn.Close();
        }

        public string cekState()
        {
            return conn.State.ToString();
        }

        public void begintransaction()
        {
            trans = conn.BeginTransaction();
        }

        public void committransaction()
        {
            trans.Commit();
        }

        public void rollbackTransaction()
        {
            trans.Rollback();
        }

        public DataTable getDataTable(string query, object[] param = null)
        {

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    query = query.Replace("@" + (i + 1), "'" + param[i].ToString() + "'");                    
                }
            }

            cmd = new SqlCommand(query, conn, trans);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public int executeNonQuery(string query, object[] param = null)
        {
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    query = query.Replace("@" + (i + 1), "'" + param[i].ToString() + "'");
                }
            }

            cmd = new SqlCommand(query, conn, trans);

            return cmd.ExecuteNonQuery();
        }

        public void addToNVC(NameValueCollection nvc, string name, string value)
        {
            nvc.Set(name, value);
        }

        public int saveNVC(NameValueCollection pk, NameValueCollection nvc, string table)
        {
            string allKey = "";
            string allValue = "";
            string wherePk = "";
            string updateField = "";

            int i = 1;


            for (int j = 0; j < pk.Count; j++)
            {

                allKey += pk.GetKey(j) + ",";
                allValue += "'" + pk.Get(j) + "',";

                if (j + 1 == pk.Count)
                {
                    wherePk += pk.GetKey(j) + "='" + pk.Get(j) + "'";
                }
                else
                {
                    wherePk += pk.GetKey(j) + "='" + pk.Get(j) + "' AND ";
                }
            }

            foreach (var key in nvc.AllKeys)
            {
                //paramcol.AddWithValue(key, nvc.Get(key));
                if (i == nvc.Count)
                {
                    allKey += key;
                    allValue += "'" + nvc.Get(key) + "'";
                    updateField += key + "='" + nvc.Get(key) + "'";
                }
                else
                {
                    allKey += key + ",";
                    allValue += "'" + nvc.Get(key) + "',";
                    updateField += key + "='" + nvc.Get(key) + "',";
                }

                i += 1;
            }

            string query = @"IF NOT EXISTS (SELECT 1 FROM " + table + " WHERE " + wherePk + ") INSERT INTO " + table + " (" + allKey + ") VALUES(" + allValue + ")ELSE UPDATE " + table + " SET " + updateField + " WHERE " + wherePk;

            cmd = new SqlCommand(query, conn, trans);

            return cmd.ExecuteNonQuery();

        }

        public void printReport(string fileName="")
        {
            ConnectionInfo coninfo = new ConnectionInfo();
            TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            
            coninfo.ServerName = this.arrayConsstr[0];
            coninfo.UserID = this.arrayConsstr[1];
            coninfo.Password = this.arrayConsstr[2];
            coninfo.DatabaseName = this.arrayConsstr[3];

            ReportViewer rv = new ReportViewer(fileName,coninfo,tableLogOnInfo);

            rv.Show();
        }
    }
}
