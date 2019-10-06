namespace E_Angsuran
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOptions = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonBayar = new System.Windows.Forms.RibbonButton();
            this.ribbonKredit = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(20, 60);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOptions);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Menu";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(760, 136);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonOptions
            // 
            this.ribbonOptions.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOptions.Image")));
            this.ribbonOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOptions.SmallImage")));
            this.ribbonOptions.Text = "Pengaturan";
            this.ribbonOptions.Click += new System.EventHandler(this.RibbonOptions_Click);
            // 
            // ribbonExit
            // 
            this.ribbonExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonExit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonExit.Image")));
            this.ribbonExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonExit.SmallImage")));
            this.ribbonExit.Text = "Keluar";
            this.ribbonExit.Click += new System.EventHandler(this.RibbonExit_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "Transaksi";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Left;
            this.ribbonPanel1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanel1.Image")));
            this.ribbonPanel1.Items.Add(this.ribbonBayar);
            this.ribbonPanel1.Items.Add(this.ribbonKredit);
            this.ribbonPanel1.Text = "Transaksi Angsuran";
            // 
            // ribbonBayar
            // 
            this.ribbonBayar.Image = ((System.Drawing.Image)(resources.GetObject("ribbonBayar.Image")));
            this.ribbonBayar.MaximumSize = new System.Drawing.Size(90, 90);
            this.ribbonBayar.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonBayar.SmallImage")));
            this.ribbonBayar.Text = "Bayar";
            this.ribbonBayar.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ribbonBayar.Value = "Bayar";
            this.ribbonBayar.Click += new System.EventHandler(this.RibbonBayar_Click);
            // 
            // ribbonKredit
            // 
            this.ribbonKredit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonKredit.Image")));
            this.ribbonKredit.MaximumSize = new System.Drawing.Size(90, 90);
            this.ribbonKredit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonKredit.SmallImage")));
            this.ribbonKredit.Text = "Kredit";
            this.ribbonKredit.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ribbonKredit.Click += new System.EventHandler(this.RibbonKredit_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "Keluar";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbon1);
            this.Name = "Main";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonButton ribbonBayar;
        private System.Windows.Forms.RibbonButton ribbonKredit;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonExit;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOptions;
    }
}