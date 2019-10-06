using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;

namespace E_Angsuran
{
    public partial class ReportViewer : MetroFramework.Forms.MetroForm
    {
        public string path = "";
        public ReportViewer(string fileName,ConnectionInfo coninfo, TableLogOnInfo tableLogOnInfo)
        {
            InitializeComponent();
            ReportDocument rd = new ReportDocument();

            this.path = Directory.GetCurrentDirectory() + "\\report\\";
            rd.Load(path + fileName);

            Tables crTables;
            crTables = rd.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in crTables)
            {
                tableLogOnInfo = CrTable.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = coninfo;
                CrTable.ApplyLogOnInfo(tableLogOnInfo);
            }


            viewer.ReportSource = rd;
            viewer.Refresh();
        }
    }
}
