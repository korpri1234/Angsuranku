using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace E_Angsuran
{
    public partial class Kredit : MetroFramework.Forms.MetroForm
    {
        YLib lib;

        public Kredit()
        {
            InitializeComponent();
            lib = new YLib();

            txtKtp.MaxLength = 16;
        }

        private void clearAll()
        {
            //lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable("SELECT dbo.genId('kredit')");

                txtNoKontrak.Value = dt.Rows[0][0].ToString();
                txtNoKontrak.ReadOnly = true;
                txtNoKontrak.BackColor = System.Drawing.Color.LightGray;

                txtNama.Text = "";
                txtAlamat.Text = "";
                txtKtp.Value = "";
                txtLimit.Value = "";
                txtTenor.Value = "";
                txtAngsuran.Value = "";
                txtBunga.Value = "";
                txtStatusPernikahan.SelectedIndex = -1;
                txtStatusPernikahan.Focus();
                txtNama.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            lib.conn_open();
            lib.begintransaction();

            try
            {

                NameValueCollection nvc = new NameValueCollection();
                NameValueCollection key = new NameValueCollection();

                lib.addToNVC(key, "kontrakid", txtNoKontrak.Value);
                lib.addToNVC(nvc, "nama", txtNama.Text);
                lib.addToNVC(nvc, "ktp", txtKtp.Value);
                lib.addToNVC(nvc, "status_pernikahan", txtStatusPernikahan.Text);
                lib.addToNVC(nvc, "limit", txtLimit.Value);
                lib.addToNVC(nvc, "tenor", txtTenor.Value);
                lib.addToNVC(nvc, "bunga", txtBunga.Value);
                lib.addToNVC(nvc, "angsuran", txtAngsuran.Value);
                lib.addToNVC(nvc, "alamat", txtAlamat.Text);
                lib.addToNVC(nvc, "created_date", DateTime.Now.ToString("yyyy-MM-dd dd:mm:ss.fff"));
                lib.addToNVC(nvc, "created_by", "yusron");

                DataTable dtExisting = lib.getDataTable("SELECT *FROM kredit where kontrakid=@1", new object[] { txtNoKontrak.Value });

                if (lib.saveNVC(key, nvc, "kredit") > 0)
                {
                    MessageBox.Show("Data disimpan!");

                    if (dtExisting.Rows.Count == 0)
                    {
                        lib.executeNonQuery("exec sp_updateidinc 'kredit'");
                    }
                    clearAll();
                }

                lib.committransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lib.rollbackTransaction();
            }

            lib.conn_close();
        }

        private void Kredit_Load(object sender, EventArgs e)
        {
            txtAngsuran.BackColor = System.Drawing.Color.LightGray;
            lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable("SELECT dbo.genId('kredit')");

                txtNoKontrak.Value = dt.Rows[0][0].ToString();
                txtNoKontrak.ReadOnly = true;
                txtNoKontrak.BackColor = System.Drawing.Color.LightGray;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lib.conn_close();

        }

        private void TxtNoKontrak_btnClick(object sender, EventArgs e)
        {
            PopUpFindKontrak pfk = new PopUpFindKontrak();

            if (pfk.ShowDialog() == DialogResult.OK)
            {
                txtNoKontrak.Value = pfk.Response;
                lib.conn_open();
                try
                {
                    DataTable dt = lib.getDataTable("SELECT *FROM kredit WHERE kontrakid=@1", new object[] { txtNoKontrak.Value });

                    if (dt.Rows.Count > 0)
                    {
                        txtNama.Text = dt.Rows[0]["nama"].ToString();
                        txtAlamat.Text = dt.Rows[0]["alamat"].ToString();
                        txtAngsuran.Value = dt.Rows[0]["angsuran"].ToString();
                        txtBunga.Value = dt.Rows[0]["bunga"].ToString();
                        txtKtp.Value = dt.Rows[0]["ktp"].ToString();
                        txtLimit.Value = dt.Rows[0]["limit"].ToString();
                        txtStatusPernikahan.SelectedItem = dt.Rows[0]["status_pernikahan"].ToString();
                        txtTenor.Value = dt.Rows[0]["tenor"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lib.conn_close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lib.conn_open();
            clearAll();
            lib.conn_close();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoKontrak.Value))
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus data " + txtNoKontrak.Value, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        lib.conn_open();
                        NameValueCollection nvc = new NameValueCollection();
                        NameValueCollection key = new NameValueCollection();

                        lib.addToNVC(nvc, "void_date", DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                        lib.addToNVC(nvc, "void_by", "yusron");
                        lib.addToNVC(key, "kontrakid", txtNoKontrak.Value);

                        if (lib.saveNVC(key, nvc, "kredit") > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus", "Perhatian");

                            clearAll();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data tidak ditemukan", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lib.conn_close();
                }
            }
        }

        private long HitungAngsuran()
        {
            long angsuran = 0;
            long bunga = 0;

            if (!string.IsNullOrEmpty(txtLimit.Value) && !string.IsNullOrEmpty(txtBunga.Value) && !string.IsNullOrEmpty(txtTenor.Value))
            {
                bunga = (Convert.ToInt64(txtBunga.Value) * Convert.ToInt64(txtLimit.Value)) / 100;
                angsuran = (Convert.ToInt64(txtLimit.Value) + bunga) / Convert.ToInt64(txtTenor.Value);
            }

            return angsuran;
        }

        private void TxtLimit_Leave(object sender, EventArgs e)
        {
            //txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void TxtTenor_Leave(object sender, EventArgs e)
        {
            //txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void TxtBunga_Leave(object sender, EventArgs e)
        {
            txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void TxtLimit_Number_Change(object sender, EventArgs e)
        {
            txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void TxtTenor_Number_Change(object sender, EventArgs e)
        {
            txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void TxtBunga_Number_Change(object sender, EventArgs e)
        {
            txtAngsuran.Value = HitungAngsuran().ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lib.printReport("rpt_kredit.rpt");
        }
    }
}
