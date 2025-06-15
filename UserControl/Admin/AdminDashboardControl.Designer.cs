namespace MaterialOrderingApp.Forms.Admin
{
    partial class AdminDashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tablePanelKiri = new TableLayoutPanel();
            labelAdmin = new Label();
            btnManajemenMaterial = new Button();
            btnManajemenPesanan = new Button();
            btnLogOut = new Button();
            tableLayoutPanelDashboard = new TableLayoutPanel();
            panelPesanan = new Panel();
            innerPanelPesanan = new TableLayoutPanel();
            labelPesanan = new Label();
            lblJumlahPesanan = new Label();
            panelTruk = new Panel();
            innerPanelTruk = new TableLayoutPanel();
            labelTruk = new Label();
            lblJumlahTruk = new Label();
            panelMaterial = new Panel();
            innerPanelMaterial = new TableLayoutPanel();
            labelMaterial = new Label();
            lblMaterialHabis = new Label();
            panelCustomer = new Panel();
            innerPanelCustomer = new TableLayoutPanel();
            labelCustomer = new Label();
            lblTotalCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tableLayoutPanelDashboard.SuspendLayout();
            panelPesanan.SuspendLayout();
            innerPanelPesanan.SuspendLayout();
            panelTruk.SuspendLayout();
            innerPanelTruk.SuspendLayout();
            panelMaterial.SuspendLayout();
            innerPanelMaterial.SuspendLayout();
            panelCustomer.SuspendLayout();
            innerPanelCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(tablePanelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanelDashboard);
            splitContainer1.Size = new Size(1151, 561);
            splitContainer1.SplitterDistance = 452;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelAdmin, 0, 0);
            tablePanelKiri.Controls.Add(btnManajemenMaterial, 0, 1);
            tablePanelKiri.Controls.Add(btnManajemenPesanan, 0, 2);
            tablePanelKiri.Controls.Add(btnLogOut, 0, 3);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.Padding = new Padding(30, 45, 30, 45);
            tablePanelKiri.RowCount = 5;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanelKiri.Size = new Size(452, 561);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelAdmin
            // 
            labelAdmin.Dock = DockStyle.Fill;
            labelAdmin.Font = new Font("Verdana", 38F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelAdmin.ForeColor = Color.White;
            labelAdmin.Location = new Point(33, 45);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(386, 100);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "ADMIN";
            labelAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManajemenMaterial
            // 
            btnManajemenMaterial.Anchor = AnchorStyles.Top;
            btnManajemenMaterial.BackColor = Color.White;
            btnManajemenMaterial.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnManajemenMaterial.ForeColor = Color.Black;
            btnManajemenMaterial.Location = new Point(33, 148);
            btnManajemenMaterial.Name = "btnManajemenMaterial";
            btnManajemenMaterial.Size = new Size(386, 45);
            btnManajemenMaterial.TabIndex = 1;
            btnManajemenMaterial.Text = "Manajemen Material";
            btnManajemenMaterial.UseVisualStyleBackColor = false;
            // 
            // btnManajemenPesanan
            // 
            btnManajemenPesanan.Anchor = AnchorStyles.Top;
            btnManajemenPesanan.BackColor = Color.White;
            btnManajemenPesanan.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnManajemenPesanan.ForeColor = Color.Black;
            btnManajemenPesanan.Location = new Point(33, 208);
            btnManajemenPesanan.Name = "btnManajemenPesanan";
            btnManajemenPesanan.Size = new Size(386, 45);
            btnManajemenPesanan.TabIndex = 2;
            btnManajemenPesanan.Text = "Manajemen Pesanan";
            btnManajemenPesanan.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top;
            btnLogOut.BackColor = Color.White;
            btnLogOut.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(33, 268);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(386, 45);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelDashboard
            // 
            tableLayoutPanelDashboard.BackColor = Color.Transparent;
            tableLayoutPanelDashboard.ColumnCount = 2;
            tableLayoutPanelDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDashboard.Controls.Add(panelPesanan, 0, 0);
            tableLayoutPanelDashboard.Controls.Add(panelTruk, 1, 0);
            tableLayoutPanelDashboard.Controls.Add(panelMaterial, 0, 1);
            tableLayoutPanelDashboard.Controls.Add(panelCustomer, 1, 1);
            tableLayoutPanelDashboard.Dock = DockStyle.Fill;
            tableLayoutPanelDashboard.Location = new Point(0, 0);
            tableLayoutPanelDashboard.Margin = new Padding(30);
            tableLayoutPanelDashboard.Name = "tableLayoutPanelDashboard";
            tableLayoutPanelDashboard.RowCount = 2;
            tableLayoutPanelDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDashboard.Size = new Size(693, 561);
            tableLayoutPanelDashboard.TabIndex = 0;
            // 
            // panelPesanan
            // 
            panelPesanan.BackColor = Color.FromArgb(81, 86, 90);
            panelPesanan.Controls.Add(innerPanelPesanan);
            panelPesanan.Dock = DockStyle.Fill;
            panelPesanan.Location = new Point(20, 20);
            panelPesanan.Margin = new Padding(20, 20, 10, 10);
            panelPesanan.Name = "panelPesanan";
            panelPesanan.Size = new Size(316, 250);
            panelPesanan.TabIndex = 0;
            // 
            // innerPanelPesanan
            // 
            innerPanelPesanan.ColumnCount = 1;
            innerPanelPesanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerPanelPesanan.Controls.Add(labelPesanan, 0, 0);
            innerPanelPesanan.Controls.Add(lblJumlahPesanan, 0, 2);
            innerPanelPesanan.Dock = DockStyle.Fill;
            innerPanelPesanan.Location = new Point(0, 0);
            innerPanelPesanan.Name = "innerPanelPesanan";
            innerPanelPesanan.RowCount = 3;
            innerPanelPesanan.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            innerPanelPesanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            innerPanelPesanan.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            innerPanelPesanan.Size = new Size(316, 250);
            innerPanelPesanan.TabIndex = 0;
            // 
            // labelPesanan
            // 
            labelPesanan.Dock = DockStyle.Fill;
            labelPesanan.Font = new Font("Verdana", 16F, FontStyle.Bold);
            labelPesanan.ForeColor = Color.White;
            labelPesanan.Location = new Point(3, 0);
            labelPesanan.Name = "labelPesanan";
            labelPesanan.Size = new Size(310, 109);
            labelPesanan.TabIndex = 0;
            labelPesanan.Text = "Pesanan Baru";
            labelPesanan.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblJumlahPesanan
            // 
            lblJumlahPesanan.Dock = DockStyle.Fill;
            lblJumlahPesanan.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblJumlahPesanan.ForeColor = Color.White;
            lblJumlahPesanan.Location = new Point(3, 115);
            lblJumlahPesanan.Name = "lblJumlahPesanan";
            lblJumlahPesanan.Size = new Size(310, 135);
            lblJumlahPesanan.TabIndex = 1;
            lblJumlahPesanan.Text = "-";
            lblJumlahPesanan.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTruk
            // 
            panelTruk.BackColor = Color.FromArgb(95, 125, 117);
            panelTruk.Controls.Add(innerPanelTruk);
            panelTruk.Dock = DockStyle.Fill;
            panelTruk.Location = new Point(356, 20);
            panelTruk.Margin = new Padding(10, 20, 20, 10);
            panelTruk.Name = "panelTruk";
            panelTruk.Size = new Size(317, 250);
            panelTruk.TabIndex = 1;
            // 
            // innerPanelTruk
            // 
            innerPanelTruk.ColumnCount = 1;
            innerPanelTruk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerPanelTruk.Controls.Add(labelTruk, 0, 0);
            innerPanelTruk.Controls.Add(lblJumlahTruk, 0, 2);
            innerPanelTruk.Dock = DockStyle.Fill;
            innerPanelTruk.Location = new Point(0, 0);
            innerPanelTruk.Name = "innerPanelTruk";
            innerPanelTruk.RowCount = 3;
            innerPanelTruk.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            innerPanelTruk.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            innerPanelTruk.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            innerPanelTruk.Size = new Size(317, 250);
            innerPanelTruk.TabIndex = 0;
            // 
            // labelTruk
            // 
            labelTruk.Dock = DockStyle.Fill;
            labelTruk.Font = new Font("Verdana", 16F, FontStyle.Bold);
            labelTruk.ForeColor = Color.White;
            labelTruk.Location = new Point(3, 0);
            labelTruk.Name = "labelTruk";
            labelTruk.Size = new Size(311, 109);
            labelTruk.TabIndex = 0;
            labelTruk.Text = "Truk Tersedia";
            labelTruk.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblJumlahTruk
            // 
            lblJumlahTruk.Dock = DockStyle.Fill;
            lblJumlahTruk.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblJumlahTruk.ForeColor = Color.White;
            lblJumlahTruk.Location = new Point(3, 115);
            lblJumlahTruk.Name = "lblJumlahTruk";
            lblJumlahTruk.Size = new Size(311, 135);
            lblJumlahTruk.TabIndex = 1;
            lblJumlahTruk.Text = "-";
            lblJumlahTruk.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMaterial
            // 
            panelMaterial.BackColor = Color.FromArgb(173, 74, 63);
            panelMaterial.Controls.Add(innerPanelMaterial);
            panelMaterial.Dock = DockStyle.Fill;
            panelMaterial.Location = new Point(20, 290);
            panelMaterial.Margin = new Padding(20, 10, 10, 20);
            panelMaterial.Name = "panelMaterial";
            panelMaterial.Size = new Size(316, 251);
            panelMaterial.TabIndex = 2;
            // 
            // innerPanelMaterial
            // 
            innerPanelMaterial.ColumnCount = 1;
            innerPanelMaterial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerPanelMaterial.Controls.Add(labelMaterial, 0, 0);
            innerPanelMaterial.Controls.Add(lblMaterialHabis, 0, 2);
            innerPanelMaterial.Dock = DockStyle.Fill;
            innerPanelMaterial.Location = new Point(0, 0);
            innerPanelMaterial.Name = "innerPanelMaterial";
            innerPanelMaterial.RowCount = 3;
            innerPanelMaterial.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            innerPanelMaterial.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            innerPanelMaterial.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            innerPanelMaterial.Size = new Size(316, 251);
            innerPanelMaterial.TabIndex = 0;
            // 
            // labelMaterial
            // 
            labelMaterial.Dock = DockStyle.Fill;
            labelMaterial.Font = new Font("Verdana", 16F, FontStyle.Bold);
            labelMaterial.ForeColor = Color.White;
            labelMaterial.Location = new Point(3, 0);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(310, 110);
            labelMaterial.TabIndex = 0;
            labelMaterial.Text = "Material Habis";
            labelMaterial.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblMaterialHabis
            // 
            lblMaterialHabis.Dock = DockStyle.Fill;
            lblMaterialHabis.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMaterialHabis.ForeColor = Color.White;
            lblMaterialHabis.Location = new Point(3, 116);
            lblMaterialHabis.Name = "lblMaterialHabis";
            lblMaterialHabis.Size = new Size(310, 135);
            lblMaterialHabis.TabIndex = 1;
            lblMaterialHabis.Text = "-";
            lblMaterialHabis.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCustomer
            // 
            panelCustomer.BackColor = Color.FromArgb(246, 156, 35);
            panelCustomer.Controls.Add(innerPanelCustomer);
            panelCustomer.Dock = DockStyle.Fill;
            panelCustomer.Location = new Point(356, 290);
            panelCustomer.Margin = new Padding(10, 10, 20, 20);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(317, 251);
            panelCustomer.TabIndex = 3;
            // 
            // innerPanelCustomer
            // 
            innerPanelCustomer.ColumnCount = 1;
            innerPanelCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerPanelCustomer.Controls.Add(labelCustomer, 0, 0);
            innerPanelCustomer.Controls.Add(lblTotalCustomer, 0, 2);
            innerPanelCustomer.Dock = DockStyle.Fill;
            innerPanelCustomer.Location = new Point(0, 0);
            innerPanelCustomer.Name = "innerPanelCustomer";
            innerPanelCustomer.RowCount = 3;
            innerPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            innerPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            innerPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            innerPanelCustomer.Size = new Size(317, 251);
            innerPanelCustomer.TabIndex = 0;
            // 
            // labelCustomer
            // 
            labelCustomer.Dock = DockStyle.Fill;
            labelCustomer.Font = new Font("Verdana", 16F, FontStyle.Bold);
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(3, 0);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(311, 110);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Total Customer";
            labelCustomer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.Dock = DockStyle.Fill;
            lblTotalCustomer.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalCustomer.ForeColor = Color.White;
            lblTotalCustomer.Location = new Point(3, 116);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(311, 135);
            lblTotalCustomer.TabIndex = 1;
            lblTotalCustomer.Text = "-";
            lblTotalCustomer.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "AdminDashboardControl";
            Size = new Size(1151, 561);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tableLayoutPanelDashboard.ResumeLayout(false);
            panelPesanan.ResumeLayout(false);
            innerPanelPesanan.ResumeLayout(false);
            panelTruk.ResumeLayout(false);
            innerPanelTruk.ResumeLayout(false);
            panelMaterial.ResumeLayout(false);
            innerPanelMaterial.ResumeLayout(false);
            panelCustomer.ResumeLayout(false);
            innerPanelCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tablePanelKiri;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button btnManajemenMaterial;
        private System.Windows.Forms.Button btnManajemenPesanan;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDashboard;
        private System.Windows.Forms.Panel panelPesanan;
        private System.Windows.Forms.TableLayoutPanel innerPanelPesanan;
        private System.Windows.Forms.Label labelPesanan;
        private System.Windows.Forms.Label lblJumlahPesanan;
        private System.Windows.Forms.Panel panelTruk;
        private System.Windows.Forms.TableLayoutPanel innerPanelTruk;
        private System.Windows.Forms.Label labelTruk;
        private System.Windows.Forms.Label lblJumlahTruk;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.TableLayoutPanel innerPanelMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label lblMaterialHabis;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.TableLayoutPanel innerPanelCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label lblTotalCustomer;
    }
}
