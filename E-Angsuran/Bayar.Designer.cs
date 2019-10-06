namespace E_Angsuran
{
    partial class Bayar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bayar));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtIDBayar = new CustomControl.AlphaDigit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoKontrak = new CustomControl.TextBoxPopUp();
            this.txtTgl = new System.Windows.Forms.DateTimePicker();
            this.lblSisaTagihan = new System.Windows.Forms.Label();
            this.lblSisaBulan = new System.Windows.Forms.Label();
            this.txtBayarKe = new CustomControl.Number();
            this.txtNama = new CustomControl.AlphaDigit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtIDBayar);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.txtNoKontrak);
            this.metroPanel1.Controls.Add(this.txtTgl);
            this.metroPanel1.Controls.Add(this.lblSisaTagihan);
            this.metroPanel1.Controls.Add(this.lblSisaBulan);
            this.metroPanel1.Controls.Add(this.txtBayarKe);
            this.metroPanel1.Controls.Add(this.txtNama);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(395, 232);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtIDBayar
            // 
            this.txtIDBayar.Location = new System.Drawing.Point(129, 18);
            this.txtIDBayar.MaxLength = 32767;
            this.txtIDBayar.Name = "txtIDBayar";
            this.txtIDBayar.ReadOnly = true;
            this.txtIDBayar.Size = new System.Drawing.Size(256, 21);
            this.txtIDBayar.TabIndex = 13;
            this.txtIDBayar.Value = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. Pembayaran";
            // 
            // txtNoKontrak
            // 
            this.txtNoKontrak.Location = new System.Drawing.Point(129, 45);
            this.txtNoKontrak.Name = "txtNoKontrak";
            this.txtNoKontrak.ReadOnly = false;
            this.txtNoKontrak.Size = new System.Drawing.Size(256, 21);
            this.txtNoKontrak.TabIndex = 1;
            this.txtNoKontrak.Value = "";
            this.txtNoKontrak.btnClick += new System.EventHandler(this.txtNoKontrak_btnClick);
            // 
            // txtTgl
            // 
            this.txtTgl.Location = new System.Drawing.Point(129, 104);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.Size = new System.Drawing.Size(129, 20);
            this.txtTgl.TabIndex = 3;
            // 
            // lblSisaTagihan
            // 
            this.lblSisaTagihan.AutoSize = true;
            this.lblSisaTagihan.Location = new System.Drawing.Point(126, 187);
            this.lblSisaTagihan.Name = "lblSisaTagihan";
            this.lblSisaTagihan.Size = new System.Drawing.Size(0, 13);
            this.lblSisaTagihan.TabIndex = 11;
            // 
            // lblSisaBulan
            // 
            this.lblSisaBulan.AutoSize = true;
            this.lblSisaBulan.Location = new System.Drawing.Point(126, 164);
            this.lblSisaBulan.Name = "lblSisaBulan";
            this.lblSisaBulan.Size = new System.Drawing.Size(0, 13);
            this.lblSisaBulan.TabIndex = 10;
            this.lblSisaBulan.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBayarKe
            // 
            this.txtBayarKe.Location = new System.Drawing.Point(129, 130);
            this.txtBayarKe.MaxLength = 32767;
            this.txtBayarKe.Name = "txtBayarKe";
            this.txtBayarKe.ReadOnly = false;
            this.txtBayarKe.Size = new System.Drawing.Size(129, 22);
            this.txtBayarKe.TabIndex = 4;
            this.txtBayarKe.Value = "";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(129, 73);
            this.txtNama.MaxLength = 32767;
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = false;
            this.txtNama.Size = new System.Drawing.Size(256, 25);
            this.txtNama.TabIndex = 2;
            this.txtNama.Value = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sisa Angsuran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pembayaran Ke-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tgl. Bayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Kontrak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSimpan);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 232);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(395, 51);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.Location = new System.Drawing.Point(304, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(91, 51);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Bayar";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.metroPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 283);
            this.panel1.TabIndex = 2;
            // 
            // Bayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Bayar";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Pembayaran Kredit";
            this.Load += new System.EventHandler(this.Bayar_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private CustomControl.Number txtBayarKe;
        private CustomControl.AlphaDigit txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtTgl;
        private System.Windows.Forms.Label lblSisaTagihan;
        private System.Windows.Forms.Label lblSisaBulan;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button btnSimpan;
        private CustomControl.TextBoxPopUp txtNoKontrak;
        private CustomControl.AlphaDigit txtIDBayar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}