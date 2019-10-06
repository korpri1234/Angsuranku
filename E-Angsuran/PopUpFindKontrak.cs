using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Angsuran
{
    public partial class PopUpFindKontrak : MetroFramework.Forms.MetroForm
    {
        YLib lib;
        public string Response;
        public PopUpFindKontrak()
        {
            InitializeComponent();
            lib = new YLib();
        }

        private void PopUpFindKontrak_Load(object sender, EventArgs e)
        {
            lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable(@"
                        SELECT a.* FROM VW_KREDIT a join kredit b on a.[No.Kontrak] = b.kontrakid
                        WHERE VOID_DATE IS null");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lib.conn_close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("No. Kontrak LIKE '%{0}%' OR Nama LIKE '%{0}%' OR No. Ktp LIKE '%{0}%'", txtSearch.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowselect = 0;
            string nokontrak = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                rowselect = row.Index;
                nokontrak = row.Cells[0].Value.ToString();
            }


            if (!string.IsNullOrEmpty(nokontrak))
            {
                //Bayar byr = new Bayar();
                //byr.nokontrak = nokontrak;
                this.Response = nokontrak;
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
