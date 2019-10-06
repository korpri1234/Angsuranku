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
    public partial class Bayar : MetroFramework.Forms.MetroForm
    {
        YLib lib;

        public Bayar()
        {
            InitializeComponent();
            lib = new YLib();
        }


        private void clearAll()
        {
            //lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable("SELECT dbo.genId('bayar')");


                txtIDBayar.Value = dt.Rows[0][0].ToString();
                txtIDBayar.ReadOnly = true; 
                txtIDBayar.BackColor = System.Drawing.Color.LightGray;

                txtNama.Value = "";
                lblSisaBulan.Text = "";
                lblSisaTagihan.Text = "";
                txtNoKontrak.Value = "";
                txtTgl.Text = DateTime.Now.ToString();
                txtBayarKe.Value = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            lib.conn_open();

            try
            {
                lib.begintransaction();

                NameValueCollection nvc = new NameValueCollection();
                NameValueCollection key = new NameValueCollection();

                lib.addToNVC(key,"bayarid",txtIDBayar.Value);
                lib.addToNVC(nvc, "nama", txtNama.Value);
                lib.addToNVC(nvc, "kontrakid", txtNoKontrak.Value);
                lib.addToNVC(nvc, "tgl", txtTgl.Text + DateTime.Now.ToString(" HH:mm:ss.fff"));
                lib.addToNVC(nvc, "bayarke", txtBayarKe.Value);
                lib.addToNVC(nvc, "sisaangsuranbln", lblSisaBulan.Text.Replace(" bulan",""));
                lib.addToNVC(nvc, "sisaangsurannominal", lblSisaTagihan.Text.Replace(".","").Replace("Rp","").Replace(" ",""));
                lib.addToNVC(nvc, "bayarke", txtBayarKe.Value);

                if (lib.saveNVC(key, nvc, "pembayaran") > 0) {
                    MessageBox.Show("Pembayaran berhasil!","Perhatian");

                    lib.executeNonQuery("exec sp_updateidinc 'bayar'");
                }
                clearAll();
                lib.committransaction();
            }
            catch(Exception ex)
            {
                lib.rollbackTransaction();
                MessageBox.Show(ex.Message,"Perhatian",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            lib.conn_close();
        }

        private void Bayar_Load(object sender, EventArgs e)
        {
            txtIDBayar.ReadOnly = true;
            txtIDBayar.BackColor = System.Drawing.Color.LightGray;

            //txtTgl.Format = DateTimePickerFormat.Custom;
            //txtTgl.CustomFormat = "yyyy-MM-dd HH:mm:ss.fff";
            lib.conn_open();

            try
            {
                DataTable dt = lib.getDataTable("SELECT dbo.genId('BAYAR')");

                txtIDBayar.Value = dt.Rows[0][0].ToString();
                txtIDBayar.ReadOnly = true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lib.conn_close();
        }
        

        private void txtNoKontrak_btnClick(object sender, EventArgs e)
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
                        txtNama.Value = dt.Rows[0]["nama"].ToString();
                        DataTable dtNextPembayaran = lib.getDataTable(@"select *from 
                                dbo.getDataNextPembayaran(@1)", new object[] { txtNoKontrak.Value });

                        if (dtNextPembayaran.Rows.Count > 0)
                        {
                            txtBayarKe.Value = dtNextPembayaran.Rows[0]["bayarke"].ToString();
                            lblSisaBulan.Text = dtNextPembayaran.Rows[0]["sisa_angsuran_bulan"].ToString();
                            lblSisaTagihan.Text = dtNextPembayaran.Rows[0]["sisa_angsuran_nominal"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lib.conn_close();
            }

        }
    }
}
