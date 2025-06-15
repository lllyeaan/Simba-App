namespace MaterialOrderingApp.Forms.Customer
{
    partial class MaterialSelectionControl
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
            panelKiri = new TableLayoutPanel();
            labelTitle = new Label();
            labelSubtitle = new Label();
            btnKembali = new Button();
            panelKanan = new TableLayoutPanel();
            lblInstruksi = new Label();
            dgvMaterialSelection = new DataGridView();
            panelDetail = new TableLayoutPanel();
            lblNamaMaterial = new Label();
            txtNamaMaterial = new TextBox();
            lblHarga = new Label();
            txtHarga = new TextBox();
            lblSatuan = new Label();
            txtSatuan = new TextBox();
            btnPesan = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelKiri.SuspendLayout();
            panelKanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialSelection).BeginInit();
            panelDetail.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelKanan);
            splitContainer1.Size = new Size(1300, 800);
            splitContainer1.SplitterDistance = 451;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.Transparent;
            panelKiri.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            panelKiri.BackgroundImageLayout = ImageLayout.Stretch;
            panelKiri.ColumnCount = 1;
            panelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelKiri.Controls.Add(labelTitle, 0, 0);
            panelKiri.Controls.Add(labelSubtitle, 0, 1);
            panelKiri.Controls.Add(btnKembali, 0, 2);
            panelKiri.Dock = DockStyle.Fill;
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Padding = new Padding(35, 80, 35, 80);
            panelKiri.RowCount = 4;
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelKiri.Size = new Size(451, 800);
            panelKiri.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Verdana", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(38, 80);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(375, 120);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ORDER MATERIAL";
            labelTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelSubtitle
            // 
            labelSubtitle.Dock = DockStyle.Fill;
            labelSubtitle.Font = new Font("Verdana", 17F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSubtitle.ForeColor = Color.White;
            labelSubtitle.Location = new Point(38, 200);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(375, 60);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Pilih material yang ingin kamu pesan dari daftar berikut.";
            labelSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.Top;
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(145, 270);
            btnKembali.Margin = new Padding(110, 10, 110, 10);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(161, 40);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // panelKanan
            // 
            panelKanan.BackColor = Color.Transparent;
            panelKanan.ColumnCount = 1;
            panelKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelKanan.Controls.Add(lblInstruksi, 0, 0);
            panelKanan.Controls.Add(dgvMaterialSelection, 0, 1);
            panelKanan.Controls.Add(panelDetail, 0, 2);
            panelKanan.Dock = DockStyle.Fill;
            panelKanan.Location = new Point(0, 0);
            panelKanan.Name = "panelKanan";
            panelKanan.Padding = new Padding(20, 30, 20, 30);
            panelKanan.RowCount = 3;
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            panelKanan.Size = new Size(844, 800);
            panelKanan.TabIndex = 1;
            // 
            // lblInstruksi
            // 
            lblInstruksi.Dock = DockStyle.Fill;
            lblInstruksi.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(23, 30);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(798, 60);
            lblInstruksi.TabIndex = 0;
            lblInstruksi.Text = "Daftar Material Tersedia";
            lblInstruksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMaterialSelection
            // 
            dgvMaterialSelection.BackgroundColor = Color.White;
            dgvMaterialSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialSelection.Dock = DockStyle.Fill;
            dgvMaterialSelection.GridColor = Color.Gray;
            dgvMaterialSelection.Location = new Point(23, 93);
            dgvMaterialSelection.MultiSelect = false;
            dgvMaterialSelection.Name = "dgvMaterialSelection";
            dgvMaterialSelection.RowHeadersWidth = 62;
            dgvMaterialSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialSelection.Size = new Size(798, 402);
            dgvMaterialSelection.TabIndex = 0;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.FromArgb(44, 44, 44);
            panelDetail.ColumnCount = 2;
            panelDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            panelDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelDetail.Controls.Add(lblNamaMaterial, 0, 0);
            panelDetail.Controls.Add(txtNamaMaterial, 1, 0);
            panelDetail.Controls.Add(lblHarga, 0, 1);
            panelDetail.Controls.Add(txtHarga, 1, 1);
            panelDetail.Controls.Add(lblSatuan, 0, 2);
            panelDetail.Controls.Add(txtSatuan, 1, 2);
            panelDetail.Controls.Add(btnPesan, 1, 3);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(23, 501);
            panelDetail.Name = "panelDetail";
            panelDetail.Padding = new Padding(10, 30, 10, 30);
            panelDetail.RowCount = 4;
            panelDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            panelDetail.Size = new Size(798, 266);
            panelDetail.TabIndex = 1;
            // 
            // lblNamaMaterial
            // 
            lblNamaMaterial.Dock = DockStyle.Fill;
            lblNamaMaterial.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblNamaMaterial.ForeColor = Color.White;
            lblNamaMaterial.Location = new Point(13, 30);
            lblNamaMaterial.Name = "lblNamaMaterial";
            lblNamaMaterial.Size = new Size(154, 50);
            lblNamaMaterial.TabIndex = 0;
            lblNamaMaterial.Text = "Nama Material:";
            lblNamaMaterial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNamaMaterial
            // 
            txtNamaMaterial.Dock = DockStyle.Fill;
            txtNamaMaterial.Font = new Font("Verdana", 11F);
            txtNamaMaterial.Location = new Point(173, 33);
            txtNamaMaterial.Name = "txtNamaMaterial";
            txtNamaMaterial.ReadOnly = true;
            txtNamaMaterial.Size = new Size(612, 34);
            txtNamaMaterial.TabIndex = 1;
            // 
            // lblHarga
            // 
            lblHarga.Dock = DockStyle.Fill;
            lblHarga.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblHarga.ForeColor = Color.White;
            lblHarga.Location = new Point(13, 80);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(154, 50);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga:";
            lblHarga.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHarga
            // 
            txtHarga.Dock = DockStyle.Fill;
            txtHarga.Font = new Font("Verdana", 11F);
            txtHarga.Location = new Point(173, 83);
            txtHarga.Name = "txtHarga";
            txtHarga.ReadOnly = true;
            txtHarga.Size = new Size(612, 34);
            txtHarga.TabIndex = 3;
            // 
            // lblSatuan
            // 
            lblSatuan.Dock = DockStyle.Fill;
            lblSatuan.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblSatuan.ForeColor = Color.White;
            lblSatuan.Location = new Point(13, 130);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(154, 50);
            lblSatuan.TabIndex = 4;
            lblSatuan.Text = "Satuan:";
            lblSatuan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSatuan
            // 
            txtSatuan.Dock = DockStyle.Fill;
            txtSatuan.Font = new Font("Verdana", 11F);
            txtSatuan.Location = new Point(173, 133);
            txtSatuan.Name = "txtSatuan";
            txtSatuan.ReadOnly = true;
            txtSatuan.Size = new Size(612, 34);
            txtSatuan.TabIndex = 5;
            // 
            // btnPesan
            // 
            btnPesan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPesan.BackColor = Color.White;
            btnPesan.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnPesan.ForeColor = Color.Black;
            btnPesan.Location = new Point(635, 202);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(150, 45);
            btnPesan.TabIndex = 4;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = false;
            // 
            // MaterialSelectionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "MaterialSelectionControl";
            Size = new Size(1300, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelKiri.ResumeLayout(false);
            panelKanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialSelection).EndInit();
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel panelKiri;
        private Label labelTitle;
        private Label labelSubtitle;
        private Button btnKembali;

        private TableLayoutPanel panelKanan;
        private Label lblInstruksi;
        private DataGridView dgvMaterialSelection;
        private TableLayoutPanel panelDetail;
        private Label lblNamaMaterial;
        private TextBox txtNamaMaterial;
        private Label lblHarga;
        private TextBox txtHarga;
        private Label lblSatuan;
        private TextBox txtSatuan;
        private Button btnPesan;
    }
}
