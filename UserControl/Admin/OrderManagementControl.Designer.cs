namespace MaterialOrderingApp.Forms.Admin
{
    partial class OrderManagementControl
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
            btnKembali = new Button();
            label2 = new Label();
            label1 = new Label();
            comboBoxTruk = new ComboBox();
            btnKonfirmasi = new Button();
            txtTanggal = new TextBox();
            txtCustomer = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvPesanan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btnKembali);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(comboBoxTruk);
            splitContainer1.Panel2.Controls.Add(btnKonfirmasi);
            splitContainer1.Panel2.Controls.Add(txtTanggal);
            splitContainer1.Panel2.Controls.Add(txtCustomer);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(dgvPesanan);
            splitContainer1.Size = new Size(914, 480);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.AllowDrop = true;
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.BackColor = Color.White;
            btnKembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnKembali.Cursor = Cursors.Hand;
            btnKembali.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(50, 290);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(188, 51);
            btnKembali.TabIndex = 13;
            btnKembali.Text = "Kembali";
            btnKembali.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.UseWaitCursor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 39F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 193);
            label2.Name = "label2";
            label2.Size = new Size(237, 118);
            label2.TabIndex = 11;
            label2.Text = "Pesanan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 39F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 112);
            label1.Name = "label1";
            label1.Size = new Size(316, 118);
            label1.TabIndex = 10;
            label1.Text = "Manajemen";
            // 
            // comboBoxTruk
            // 
            comboBoxTruk.Font = new Font("Segoe UI", 11F);
            comboBoxTruk.FormattingEnabled = true;
            comboBoxTruk.Location = new Point(200, 341);
            comboBoxTruk.Name = "comboBoxTruk";
            comboBoxTruk.Size = new Size(350, 28);
            comboBoxTruk.TabIndex = 30;
            comboBoxTruk.SelectedIndexChanged += comboBoxTruk_SelectedIndexChanged;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.AllowDrop = true;
            btnKonfirmasi.Anchor = AnchorStyles.None;
            btnKonfirmasi.BackColor = Color.White;
            btnKonfirmasi.BackgroundImageLayout = ImageLayout.Stretch;
            btnKonfirmasi.Cursor = Cursors.Hand;
            btnKonfirmasi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.Black;
            btnKonfirmasi.Location = new Point(54, 392);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(496, 38);
            btnKonfirmasi.TabIndex = 29;
            btnKonfirmasi.Text = "Konfirmasi Pengiriman";
            btnKonfirmasi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.UseWaitCursor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // txtTanggal
            // 
            txtTanggal.Anchor = AnchorStyles.None;
            txtTanggal.Font = new Font("Verdana", 11F);
            txtTanggal.Location = new Point(200, 303);
            txtTanggal.Multiline = true;
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(350, 32);
            txtTanggal.TabIndex = 26;
            txtTanggal.TextChanged += txtTanggal_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.Anchor = AnchorStyles.None;
            txtCustomer.Font = new Font("Verdana", 11F);
            txtCustomer.Location = new Point(200, 265);
            txtCustomer.Multiline = true;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(350, 32);
            txtCustomer.TabIndex = 25;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(54, 345);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 23;
            label5.Text = "Truk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(54, 309);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 22;
            label4.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 274);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 21;
            label3.Text = "Customer";
            // 
            // dgvPesanan
            // 
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(0, 0);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.Size = new Size(603, 223);
            dgvPesanan.TabIndex = 1;
            dgvPesanan.CellContentClick += dgvPesanan_CellContentClick;
            // 
            // OrderManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "OrderManagementControl";
            Size = new Size(914, 480);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private Button btnKembali;
        private DataGridView dgvPesanan;
        private Button btnKonfirmasi;
        private ComboBox comboBoxTruk;
        private TextBox txtTanggal;
        private TextBox txtCustomer;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
