namespace MaterialOrderingApp.Forms.Admin
{
    partial class MaterialManagementControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panelKiri = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btnKembali = new Button();
            tablePanelKanan = new TableLayoutPanel();
            dgvMaterial = new DataGridView();
            inputTablePanel = new TableLayoutPanel();
            label3 = new Label();
            txtNamaMaterial = new TextBox();
            label4 = new Label();
            txtHarga = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtSatuan = new TextBox();
            label7 = new Label();
            chkTersedia = new CheckBox();
            pictureBoxKetersediaan = new PictureBox();
            buttonPanel = new FlowLayoutPanel();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnClear = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelKiri.SuspendLayout();
            tablePanelKanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            inputTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKetersediaan).BeginInit();
            buttonPanel.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tablePanelKanan);
            splitContainer1.Size = new Size(1300, 600);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.Transparent;
            panelKiri.ColumnCount = 1;
            panelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelKiri.Controls.Add(label1, 0, 1);
            panelKiri.Controls.Add(label2, 0, 2);
            panelKiri.Controls.Add(btnKembali, 0, 3);
            panelKiri.Dock = DockStyle.Fill;
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.RowCount = 4;
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            panelKiri.Size = new Size(400, 600);
            panelKiri.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Javanese Text", 32F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 132);
            label1.Name = "label1";
            label1.Size = new Size(394, 80);
            label1.TabIndex = 1;
            label1.Text = "Manajemen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Javanese Text", 32F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 212);
            label2.Name = "label2";
            label2.Size = new Size(394, 80);
            label2.TabIndex = 2;
            label2.Text = "Material";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.Top;
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(121, 302);
            btnKembali.Margin = new Padding(80, 10, 80, 10);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(158, 50);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tablePanelKanan
            // 
            tablePanelKanan.BackColor = Color.Transparent;
            tablePanelKanan.ColumnCount = 1;
            tablePanelKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePanelKanan.Controls.Add(dgvMaterial, 0, 0);
            tablePanelKanan.Controls.Add(inputTablePanel, 0, 1);
            tablePanelKanan.Controls.Add(buttonPanel, 0, 2);
            tablePanelKanan.Dock = DockStyle.Fill;
            tablePanelKanan.Location = new Point(0, 0);
            tablePanelKanan.Name = "tablePanelKanan";
            tablePanelKanan.RowCount = 3;
            tablePanelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tablePanelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tablePanelKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanelKanan.Size = new Size(896, 600);
            tablePanelKanan.TabIndex = 0;
            // 
            // dgvMaterial
            // 
            dgvMaterial.BackgroundColor = Color.White;
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Dock = DockStyle.Fill;
            dgvMaterial.Location = new Point(3, 3);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.RowHeadersWidth = 62;
            dgvMaterial.ScrollBars = ScrollBars.Vertical;
            dgvMaterial.Size = new Size(890, 234);
            dgvMaterial.TabIndex = 0;
            dgvMaterial.CellClick += dgvMaterial_CellClick;
            dgvMaterial.CellContentClick += dgvMaterial_CellContentClick;
            // 
            // inputTablePanel
            // 
            inputTablePanel.ColumnCount = 4;
            inputTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            inputTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            inputTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTablePanel.Controls.Add(label3, 0, 0);
            inputTablePanel.Controls.Add(txtNamaMaterial, 1, 0);
            inputTablePanel.Controls.Add(label4, 2, 0);
            inputTablePanel.Controls.Add(txtHarga, 3, 0);
            inputTablePanel.Controls.Add(label5, 0, 1);
            inputTablePanel.Controls.Add(txtStock, 1, 1);
            inputTablePanel.Controls.Add(label6, 2, 1);
            inputTablePanel.Controls.Add(txtSatuan, 3, 1);
            inputTablePanel.Controls.Add(label7, 0, 2);
            inputTablePanel.Controls.Add(chkTersedia, 1, 2);
            inputTablePanel.Controls.Add(pictureBoxKetersediaan, 2, 2);
            inputTablePanel.Dock = DockStyle.Fill;
            inputTablePanel.Location = new Point(3, 243);
            inputTablePanel.Name = "inputTablePanel";
            inputTablePanel.Padding = new Padding(30, 15, 30, 0);
            inputTablePanel.RowCount = 3;
            inputTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            inputTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            inputTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTablePanel.Size = new Size(890, 139);
            inputTablePanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 15);
            label3.Name = "label3";
            label3.Size = new Size(134, 40);
            label3.TabIndex = 0;
            label3.Text = "Nama Material";
            // 
            // txtNamaMaterial
            // 
            txtNamaMaterial.Dock = DockStyle.Fill;
            txtNamaMaterial.Font = new Font("Verdana", 11F);
            txtNamaMaterial.Location = new Point(173, 18);
            txtNamaMaterial.Name = "txtNamaMaterial";
            txtNamaMaterial.Size = new Size(269, 34);
            txtNamaMaterial.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(448, 15);
            label4.Name = "label4";
            label4.Size = new Size(134, 40);
            label4.TabIndex = 2;
            label4.Text = "Harga";
            // 
            // txtHarga
            // 
            txtHarga.Dock = DockStyle.Fill;
            txtHarga.Font = new Font("Verdana", 11F);
            txtHarga.Location = new Point(588, 18);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(269, 34);
            txtHarga.TabIndex = 3;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 55);
            label5.Name = "label5";
            label5.Size = new Size(134, 40);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            // 
            // txtStock
            // 
            txtStock.Dock = DockStyle.Fill;
            txtStock.Font = new Font("Verdana", 11F);
            txtStock.Location = new Point(173, 58);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(269, 34);
            txtStock.TabIndex = 5;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(448, 55);
            label6.Name = "label6";
            label6.Size = new Size(134, 40);
            label6.TabIndex = 6;
            label6.Text = "Satuan";
            // 
            // txtSatuan
            // 
            txtSatuan.Dock = DockStyle.Fill;
            txtSatuan.Font = new Font("Verdana", 11F);
            txtSatuan.Location = new Point(588, 58);
            txtSatuan.Name = "txtSatuan";
            txtSatuan.Size = new Size(269, 34);
            txtSatuan.TabIndex = 7;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 95);
            label7.Name = "label7";
            label7.Size = new Size(134, 45);
            label7.TabIndex = 8;
            label7.Text = "Ketersediaan";
            // 
            // chkTersedia
            // 
            chkTersedia.Dock = DockStyle.Left;
            chkTersedia.Font = new Font("Segoe UI", 13F);
            chkTersedia.Location = new Point(173, 98);
            chkTersedia.Name = "chkTersedia";
            chkTersedia.Size = new Size(104, 39);
            chkTersedia.TabIndex = 9;
            chkTersedia.CheckedChanged += chkTersedia_CheckedChanged;
            // 
            // pictureBoxKetersediaan
            // 
            pictureBoxKetersediaan.BackColor = Color.Transparent;
            pictureBoxKetersediaan.Dock = DockStyle.Left;
            pictureBoxKetersediaan.Location = new Point(448, 98);
            pictureBoxKetersediaan.Name = "pictureBoxKetersediaan";
            pictureBoxKetersediaan.Size = new Size(42, 39);
            pictureBoxKetersediaan.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKetersediaan.TabIndex = 10;
            pictureBoxKetersediaan.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.None;
            buttonPanel.AutoSize = true;
            buttonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPanel.Controls.Add(btnTambah);
            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnHapus);
            buttonPanel.Controls.Add(btnClear);
            buttonPanel.Location = new Point(108, 464);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 15, 0, 0);
            buttonPanel.Size = new Size(680, 57);
            buttonPanel.TabIndex = 2;
            buttonPanel.WrapContents = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.Font = new Font("Verdana", 11F, FontStyle.Bold);
            btnTambah.Location = new Point(20, 15);
            btnTambah.Margin = new Padding(20, 0, 20, 0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(130, 42);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Font = new Font("Verdana", 11F, FontStyle.Bold);
            btnEdit.Location = new Point(190, 15);
            btnEdit.Margin = new Padding(20, 0, 20, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.White;
            btnHapus.Font = new Font("Verdana", 11F, FontStyle.Bold);
            btnHapus.Location = new Point(360, 15);
            btnHapus.Margin = new Padding(20, 0, 20, 0);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(130, 42);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Verdana", 11F, FontStyle.Bold);
            btnClear.Location = new Point(530, 15);
            btnClear.Margin = new Padding(20, 0, 20, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 42);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // MaterialManagementControl
            // 
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "MaterialManagementControl";
            Size = new Size(1300, 600);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelKiri.ResumeLayout(false);
            tablePanelKanan.ResumeLayout(false);
            tablePanelKanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            inputTablePanel.ResumeLayout(false);
            inputTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKetersediaan).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel panelKiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKembali;

        private System.Windows.Forms.TableLayoutPanel tablePanelKanan;
        private System.Windows.Forms.DataGridView dgvMaterial;

        private System.Windows.Forms.TableLayoutPanel inputTablePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTersedia;
        private System.Windows.Forms.PictureBox pictureBoxKetersediaan;

        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
