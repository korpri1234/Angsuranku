using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace E_Angsuran
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = @""+ txtServer.Text + ";" + txtUser.Text + ";" + txtPass.Text + ";" + txtDatabase.Text + ";true;";
                File.WriteAllText(Directory.GetCurrentDirectory() + "/ConnectionSettings.txt", connstr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string[] connstr = File.ReadAllText(Directory.GetCurrentDirectory() + "/ConnectionSettings.txt").Split(';');
            txtServer.Text = connstr[0];
            txtUser.Text = connstr[1];
            txtPass.Text = connstr[2];
            txtDatabase.Text = connstr[3];

        }
    }
}
