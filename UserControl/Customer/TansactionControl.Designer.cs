namespace MaterialOrderingApp.Forms.Customer
{
    partial class TansactionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnbatal = new Button();
            lbltransaksi = new Label();
            btnbuatpesanan = new Button();
            cmbboxmethod = new ComboBox();
            lblmetode = new Label();
            txtboxtotal = new TextBox();
            txtboxharga = new TextBox();
            txtboxMaterial = new TextBox();
            lblringkasan4 = new Label();
            lblringkasan2 = new Label();
            lblringkasan1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnbatal);
            splitContainer1.Panel1.Controls.Add(lbltransaksi);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnbuatpesanan);
            splitContainer1.Panel2.Controls.Add(cmbboxmethod);
            splitContainer1.Panel2.Controls.Add(lblmetode);
            splitContainer1.Panel2.Controls.Add(txtboxtotal);
            splitContainer1.Panel2.Controls.Add(txtboxharga);
            splitContainer1.Panel2.Controls.Add(txtboxMaterial);
            splitContainer1.Panel2.Controls.Add(lblringkasan4);
            splitContainer1.Panel2.Controls.Add(lblringkasan2);
            splitContainer1.Panel2.Controls.Add(lblringkasan1);
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 435;
            splitContainer1.TabIndex = 0;
            // 
            // btnbatal
            // 
            btnbatal.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbatal.Location = new Point(139, 405);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(148, 41);
            btnbatal.TabIndex = 1;
            btnbatal.Text = "Kembali";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // lbltransaksi
            // 
            lbltransaksi.AutoSize = true;
            lbltransaksi.BackColor = Color.Transparent;
            lbltransaksi.Font = new Font("Javanese Text", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltransaksi.ForeColor = Color.White;
            lbltransaksi.Location = new Point(66, 294);
            lbltransaksi.Name = "lbltransaksi";
            lbltransaksi.Size = new Size(311, 136);
            lbltransaksi.TabIndex = 0;
            lbltransaksi.Text = "Transaksi";
            lbltransaksi.Click += lbltransaksi_Click;
            // 
            // btnbuatpesanan
            // 
            btnbuatpesanan.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuatpesanan.Location = new Point(630, 627);
            btnbuatpesanan.Name = "btnbuatpesanan";
            btnbuatpesanan.Size = new Size(174, 46);
            btnbuatpesanan.TabIndex = 10;
            btnbuatpesanan.Text = "Pesan";
            btnbuatpesanan.UseVisualStyleBackColor = true;
            btnbuatpesanan.Click += btnbuatpesanan_Click;
            // 
            // cmbboxmethod
            // 
            cmbboxmethod.FormattingEnabled = true;
            cmbboxmethod.Items.AddRange(new object[] { "COD", "Transfer" });
            cmbboxmethod.Location = new Point(485, 461);
            cmbboxmethod.Name = "cmbboxmethod";
            cmbboxmethod.Size = new Size(248, 33);
            cmbboxmethod.TabIndex = 9;
            cmbboxmethod.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblmetode
            // 
            lblmetode.AutoSize = true;
            lblmetode.BackColor = Color.Transparent;
            lblmetode.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmetode.ForeColor = Color.White;
            lblmetode.Location = new Point(61, 461);
            lblmetode.Name = "lblmetode";
            lblmetode.Size = new Size(297, 25);
            lblmetode.TabIndex = 8;
            lblmetode.Text = "Pilih Metode Pembayaran";
            // 
            // txtboxtotal
            // 
            txtboxtotal.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxtotal.Location = new Point(333, 339);
            txtboxtotal.Name = "txtboxtotal";
            txtboxtotal.Size = new Size(454, 32);
            txtboxtotal.TabIndex = 7;
            // 
            // txtboxharga
            // 
            txtboxharga.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxharga.Location = new Point(333, 271);
            txtboxharga.Name = "txtboxharga";
            txtboxharga.Size = new Size(454, 32);
            txtboxharga.TabIndex = 5;
            // 
            // txtboxMaterial
            // 
            txtboxMaterial.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxMaterial.Location = new Point(333, 216);
            txtboxMaterial.Name = "txtboxMaterial";
            txtboxMaterial.Size = new Size(454, 32);
            txtboxMaterial.TabIndex = 4;
            // 
            // lblringkasan4
            // 
            lblringkasan4.AutoSize = true;
            lblringkasan4.BackColor = Color.Transparent;
            lblringkasan4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblringkasan4.ForeColor = Color.White;
            lblringkasan4.Location = new Point(61, 339);
            lblringkasan4.Name = "lblringkasan4";
            lblringkasan4.Size = new Size(69, 25);
            lblringkasan4.TabIndex = 3;
            lblringkasan4.Text = "Total";
            lblringkasan4.Click += label2_Click;
            // 
            // lblringkasan2
            // 
            lblringkasan2.AutoSize = true;
            lblringkasan2.BackColor = Color.Transparent;
            lblringkasan2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblringkasan2.ForeColor = Color.White;
            lblringkasan2.Location = new Point(61, 274);
            lblringkasan2.Name = "lblringkasan2";
            lblringkasan2.Size = new Size(79, 25);
            lblringkasan2.TabIndex = 1;
            lblringkasan2.Text = "Harga";
            // 
            // lblringkasan1
            // 
            lblringkasan1.AutoSize = true;
            lblringkasan1.BackColor = Color.Transparent;
            lblringkasan1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblringkasan1.ForeColor = Color.White;
            lblringkasan1.Location = new Point(61, 216);
            lblringkasan1.Name = "lblringkasan1";
            lblringkasan1.Size = new Size(174, 25);
            lblringkasan1.TabIndex = 0;
            lblringkasan1.Text = "Nama Material";
            // 
            // TansactionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "TansactionControl";
            Size = new Size(1306, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lbltransaksi;
        private Button btnbatal;
        private Label lblringkasan2;
        private Label lblringkasan1;
        private Label lblringkasan4;
        private TextBox txtboxharga;
        private TextBox txtboxMaterial;
        private ComboBox cmbboxmethod;
        private Label lblmetode;
        private TextBox txtboxtotal;
        private Button btnbuatpesanan;
    }
}
