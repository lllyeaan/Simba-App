namespace MaterialOrderingApp.Forms.Customer
{
    partial class TansactionControl
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
            btnbatal = new Button();
            lbltransaksi = new Label();
            tablePanelRingkasan = new TableLayoutPanel();
            lblringkasan1 = new Label();
            txtboxMaterial = new TextBox();
            lblringkasan2 = new Label();
            txtboxharga = new TextBox();
            lblringkasan4 = new Label();
            txtboxtotal = new TextBox();
            lblmetode = new Label();
            cmbboxmethod = new ComboBox();
            btnbuatpesanan = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelRingkasan.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnbatal);
            splitContainer1.Panel1.Controls.Add(lbltransaksi);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(tablePanelRingkasan);
            splitContainer1.Size = new Size(920, 448);
            splitContainer1.SplitterDistance = 312;
            splitContainer1.TabIndex = 0;
            // 
            // btnbatal
            // 
            btnbatal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnbatal.BackColor = Color.White;
            btnbatal.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnbatal.ForeColor = Color.Black;
            btnbatal.Location = new Point(56, 215);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(200, 45);
            btnbatal.TabIndex = 1;
            btnbatal.Text = "Kembali";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // lbltransaksi
            // 
            lbltransaksi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbltransaksi.BackColor = Color.Transparent;
            lbltransaksi.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbltransaksi.ForeColor = Color.White;
            lbltransaksi.Location = new Point(0, 108);
            lbltransaksi.Name = "lbltransaksi";
            lbltransaksi.Size = new Size(300, 100);
            lbltransaksi.TabIndex = 2;
            lbltransaksi.Text = "TRANSAKSI";
            lbltransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tablePanelRingkasan
            // 
            tablePanelRingkasan.BackColor = Color.Transparent;
            tablePanelRingkasan.ColumnCount = 2;
            tablePanelRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tablePanelRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelRingkasan.Controls.Add(lblringkasan1, 0, 0);
            tablePanelRingkasan.Controls.Add(txtboxMaterial, 1, 0);
            tablePanelRingkasan.Controls.Add(lblringkasan2, 0, 1);
            tablePanelRingkasan.Controls.Add(txtboxharga, 1, 1);
            tablePanelRingkasan.Controls.Add(lblringkasan4, 0, 2);
            tablePanelRingkasan.Controls.Add(txtboxtotal, 1, 2);
            tablePanelRingkasan.Controls.Add(lblmetode, 0, 3);
            tablePanelRingkasan.Controls.Add(cmbboxmethod, 1, 3);
            tablePanelRingkasan.Controls.Add(btnbuatpesanan, 1, 4);
            tablePanelRingkasan.Dock = DockStyle.Fill;
            tablePanelRingkasan.Location = new Point(0, 0);
            tablePanelRingkasan.Name = "tablePanelRingkasan";
            tablePanelRingkasan.Padding = new Padding(50, 80, 50, 20);
            tablePanelRingkasan.RowCount = 5;
            tablePanelRingkasan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelRingkasan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelRingkasan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelRingkasan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanelRingkasan.Size = new Size(604, 448);
            tablePanelRingkasan.TabIndex = 0;
            // 
            // lblringkasan1
            // 
            lblringkasan1.Dock = DockStyle.Fill;
            lblringkasan1.Font = new Font("Verdana", 13F, FontStyle.Bold);
            lblringkasan1.ForeColor = Color.White;
            lblringkasan1.Location = new Point(53, 80);
            lblringkasan1.Name = "lblringkasan1";
            lblringkasan1.Size = new Size(174, 60);
            lblringkasan1.TabIndex = 0;
            lblringkasan1.Text = "Nama Material";
            // 
            // txtboxMaterial
            // 
            txtboxMaterial.Dock = DockStyle.Fill;
            txtboxMaterial.Font = new Font("Verdana", 13F);
            txtboxMaterial.Location = new Point(233, 83);
            txtboxMaterial.Name = "txtboxMaterial";
            txtboxMaterial.ReadOnly = true;
            txtboxMaterial.Size = new Size(318, 39);
            txtboxMaterial.TabIndex = 1;
            // 
            // lblringkasan2
            // 
            lblringkasan2.Dock = DockStyle.Fill;
            lblringkasan2.Font = new Font("Verdana", 13F, FontStyle.Bold);
            lblringkasan2.ForeColor = Color.White;
            lblringkasan2.Location = new Point(53, 140);
            lblringkasan2.Name = "lblringkasan2";
            lblringkasan2.Size = new Size(174, 60);
            lblringkasan2.TabIndex = 2;
            lblringkasan2.Text = "Harga";
            // 
            // txtboxharga
            // 
            txtboxharga.Dock = DockStyle.Fill;
            txtboxharga.Font = new Font("Verdana", 13F);
            txtboxharga.Location = new Point(233, 143);
            txtboxharga.Name = "txtboxharga";
            txtboxharga.ReadOnly = true;
            txtboxharga.Size = new Size(318, 39);
            txtboxharga.TabIndex = 3;
            // 
            // lblringkasan4
            // 
            lblringkasan4.Dock = DockStyle.Fill;
            lblringkasan4.Font = new Font("Verdana", 13F, FontStyle.Bold);
            lblringkasan4.ForeColor = Color.White;
            lblringkasan4.Location = new Point(53, 200);
            lblringkasan4.Name = "lblringkasan4";
            lblringkasan4.Size = new Size(174, 60);
            lblringkasan4.TabIndex = 4;
            lblringkasan4.Text = "Total";
            // 
            // txtboxtotal
            // 
            txtboxtotal.Dock = DockStyle.Fill;
            txtboxtotal.Font = new Font("Verdana", 13F);
            txtboxtotal.Location = new Point(233, 203);
            txtboxtotal.Name = "txtboxtotal";
            txtboxtotal.ReadOnly = true;
            txtboxtotal.Size = new Size(318, 39);
            txtboxtotal.TabIndex = 5;
            // 
            // lblmetode
            // 
            lblmetode.Dock = DockStyle.Fill;
            lblmetode.Font = new Font("Verdana", 13F, FontStyle.Bold);
            lblmetode.ForeColor = Color.White;
            lblmetode.Location = new Point(53, 260);
            lblmetode.Name = "lblmetode";
            lblmetode.Size = new Size(174, 60);
            lblmetode.TabIndex = 6;
            lblmetode.Text = "Metode Pembayaran";
            // 
            // cmbboxmethod
            // 
            cmbboxmethod.Dock = DockStyle.Left;
            cmbboxmethod.Font = new Font("Verdana", 13F);
            cmbboxmethod.Items.AddRange(new object[] { "COD", "Transfer" });
            cmbboxmethod.Location = new Point(233, 263);
            cmbboxmethod.Name = "cmbboxmethod";
            cmbboxmethod.Size = new Size(250, 40);
            cmbboxmethod.TabIndex = 7;
            // 
            // btnbuatpesanan
            // 
            btnbuatpesanan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnbuatpesanan.BackColor = Color.White;
            btnbuatpesanan.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnbuatpesanan.ForeColor = Color.Black;
            btnbuatpesanan.Location = new Point(371, 377);
            btnbuatpesanan.Name = "btnbuatpesanan";
            btnbuatpesanan.Size = new Size(180, 48);
            btnbuatpesanan.TabIndex = 8;
            btnbuatpesanan.Text = "Pesan";
            btnbuatpesanan.UseVisualStyleBackColor = false;
            btnbuatpesanan.Click += btnbuatpesanan_Click;
            // 
            // TansactionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "TansactionControl";
            Size = new Size(920, 448);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelRingkasan.ResumeLayout(false);
            tablePanelRingkasan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnbatal;
        private Label lbltransaksi;
        private TableLayoutPanel tablePanelRingkasan;
        private Label lblringkasan1;
        private TextBox txtboxMaterial;
        private Label lblringkasan2;
        private TextBox txtboxharga;
        private Label lblringkasan4;
        private TextBox txtboxtotal;
        private Label lblmetode;
        private ComboBox cmbboxmethod;
        private Button btnbuatpesanan;
    }
}
