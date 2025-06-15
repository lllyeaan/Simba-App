namespace MaterialOrderingApp.Forms.Admin
{
    partial class OrderManagementControl
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
            labelTitle = new Label();
            btnKembali = new Button();
            tablePanelKanan = new TableLayoutPanel();
            dgvPesanan = new DataGridView();
            groupPanelForm = new TableLayoutPanel();
            labelCustomer = new Label();
            txtCustomer = new TextBox();
            labelTanggal = new Label();
            txtTanggal = new TextBox();
            labelTruk = new Label();
            comboBoxTruk = new ComboBox();
            btnKonfirmasi = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tablePanelKanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            groupPanelForm.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(tablePanelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(tablePanelKanan);
            splitContainer1.Size = new Size(1151, 561);
            splitContainer1.SplitterDistance = 329;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelTitle, 0, 1);
            tablePanelKiri.Controls.Add(btnKembali, 0, 3);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.RowCount = 5;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tablePanelKiri.Size = new Size(329, 561);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(3, 117);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(323, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MANAJEMEN\nPESANAN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(64, 260);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(200, 50);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // tablePanelKanan
            // 
            tablePanelKanan.BackColor = Color.Transparent;
            tablePanelKanan.ColumnCount = 1;
            tablePanelKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKanan.Controls.Add(dgvPesanan, 0, 0);
            tablePanelKanan.Controls.Add(groupPanelForm, 0, 1);
            tablePanelKanan.Dock = DockStyle.Fill;
            tablePanelKanan.Location = new Point(0, 0);
            tablePanelKanan.Name = "tablePanelKanan";
            tablePanelKanan.RowCount = 2;
            tablePanelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tablePanelKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanelKanan.Size = new Size(816, 561);
            tablePanelKanan.TabIndex = 0;
            // 
            // dgvPesanan
            // 
            dgvPesanan.BackgroundColor = Color.White;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Dock = DockStyle.Fill;
            dgvPesanan.GridColor = Color.Gray;
            dgvPesanan.Location = new Point(3, 3);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersWidth = 62;
            dgvPesanan.Size = new Size(810, 254);
            dgvPesanan.TabIndex = 0;
            // 
            // groupPanelForm
            // 
            groupPanelForm.BackColor = Color.Transparent;
            groupPanelForm.ColumnCount = 2;
            groupPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            groupPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            groupPanelForm.Controls.Add(labelCustomer, 0, 0);
            groupPanelForm.Controls.Add(txtCustomer, 0, 1);
            groupPanelForm.Controls.Add(labelTanggal, 0, 2);
            groupPanelForm.Controls.Add(txtTanggal, 0, 3);
            groupPanelForm.Controls.Add(labelTruk, 1, 0);
            groupPanelForm.Controls.Add(comboBoxTruk, 1, 1);
            groupPanelForm.Controls.Add(btnKonfirmasi, 1, 2);
            groupPanelForm.Dock = DockStyle.Top;
            groupPanelForm.Location = new Point(3, 263);
            groupPanelForm.Name = "groupPanelForm";
            groupPanelForm.Padding = new Padding(20);
            groupPanelForm.RowCount = 4;
            groupPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            groupPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            groupPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            groupPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            groupPanelForm.Size = new Size(810, 261);
            groupPanelForm.TabIndex = 1;
            // 
            // labelCustomer
            // 
            labelCustomer.Dock = DockStyle.Fill;
            labelCustomer.Font = new Font("Verdana", 12F, FontStyle.Bold);
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(23, 20);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(379, 40);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Customer";
            labelCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCustomer
            // 
            txtCustomer.Dock = DockStyle.Fill;
            txtCustomer.Font = new Font("Verdana", 11F);
            txtCustomer.Location = new Point(23, 63);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(379, 34);
            txtCustomer.TabIndex = 1;
            // 
            // labelTanggal
            // 
            labelTanggal.Dock = DockStyle.Fill;
            labelTanggal.Font = new Font("Verdana", 12F, FontStyle.Bold);
            labelTanggal.ForeColor = Color.White;
            labelTanggal.Location = new Point(23, 110);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(379, 58);
            labelTanggal.TabIndex = 2;
            labelTanggal.Text = "Tanggal";
            labelTanggal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTanggal
            // 
            txtTanggal.Dock = DockStyle.Fill;
            txtTanggal.Font = new Font("Verdana", 11F);
            txtTanggal.Location = new Point(23, 171);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.ReadOnly = true;
            txtTanggal.Size = new Size(379, 34);
            txtTanggal.TabIndex = 3;
            // 
            // labelTruk
            // 
            labelTruk.Dock = DockStyle.Fill;
            labelTruk.Font = new Font("Verdana", 12F, FontStyle.Bold);
            labelTruk.ForeColor = Color.White;
            labelTruk.Location = new Point(408, 20);
            labelTruk.Name = "labelTruk";
            labelTruk.Size = new Size(379, 40);
            labelTruk.TabIndex = 4;
            labelTruk.Text = "Truk";
            labelTruk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTruk
            // 
            comboBoxTruk.Dock = DockStyle.Fill;
            comboBoxTruk.DropDownHeight = 120;
            comboBoxTruk.Font = new Font("Segoe UI", 11F);
            comboBoxTruk.IntegralHeight = false;
            comboBoxTruk.Location = new Point(408, 63);
            comboBoxTruk.Name = "comboBoxTruk";
            comboBoxTruk.Size = new Size(379, 38);
            comboBoxTruk.TabIndex = 5;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.White;
            btnKonfirmasi.Dock = DockStyle.Fill;
            btnKonfirmasi.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnKonfirmasi.ForeColor = Color.Black;
            btnKonfirmasi.Location = new Point(415, 178);
            btnKonfirmasi.Margin = new Padding(10);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(365, 53);
            btnKonfirmasi.TabIndex = 6;
            btnKonfirmasi.Text = "Konfirmasi Pengiriman";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            // 
            // OrderManagementControl
            // 
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "OrderManagementControl";
            Size = new Size(1151, 561);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tablePanelKanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            groupPanelForm.ResumeLayout(false);
            groupPanelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tablePanelKiri;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TableLayoutPanel tablePanelKanan;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.TableLayoutPanel groupPanelForm;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Label labelTruk;
        private System.Windows.Forms.ComboBox comboBoxTruk;
        private System.Windows.Forms.Button btnKonfirmasi;
    }
}