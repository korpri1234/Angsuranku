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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }


        private void RibbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RibbonKredit_Click(object sender, EventArgs e)
        {
            Kredit kr = new Kredit();
            kr.Show();
        }

        private void RibbonBayar_Click(object sender, EventArgs e)
        {
            Bayar by = new Bayar();
            by.Show();
        }

        private void RibbonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RibbonOptions_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }
    }
}
