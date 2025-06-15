namespace MaterialOrderingApp.Forms.Customer
{
    partial class CustomerDashboardControl
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
            labelMenu = new Label();
            btnBuatPesanan = new Button();
            btnRiwayatTransaksi = new Button();
            btnLogOut = new Button();
            panelKanan = new TableLayoutPanel();
            lblGreeting = new Label();
            panelStatistik = new Panel();
            lblTotalPesanan = new Label();
            lblInfoPanduan = new Label();
            pictureBoxIlustrasi = new PictureBox();
            lblSimba = new Label();
            lblSub = new Label();
            lblCompany = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelKiri.SuspendLayout();
            panelKanan.SuspendLayout();
            panelStatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIlustrasi).BeginInit();
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
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(panelKanan);
            splitContainer1.Size = new Size(1300, 800);
            splitContainer1.SplitterDistance = 547;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.Transparent;
            panelKiri.ColumnCount = 1;
            panelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelKiri.Controls.Add(labelMenu, 0, 0);
            panelKiri.Controls.Add(btnBuatPesanan, 0, 1);
            panelKiri.Controls.Add(btnRiwayatTransaksi, 0, 2);
            panelKiri.Controls.Add(btnLogOut, 0, 3);
            panelKiri.Dock = DockStyle.Fill;
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Padding = new Padding(35, 70, 35, 70);
            panelKiri.RowCount = 5;
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelKiri.Size = new Size(547, 800);
            panelKiri.TabIndex = 0;
            // 
            // labelMenu
            // 
            labelMenu.Dock = DockStyle.Fill;
            labelMenu.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(38, 70);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(471, 110);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "MENU";
            labelMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.Anchor = AnchorStyles.Top;
            btnBuatPesanan.BackColor = Color.White;
            btnBuatPesanan.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnBuatPesanan.ForeColor = Color.Black;
            btnBuatPesanan.Location = new Point(113, 183);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(320, 45);
            btnBuatPesanan.TabIndex = 1;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Anchor = AnchorStyles.Top;
            btnRiwayatTransaksi.BackColor = Color.White;
            btnRiwayatTransaksi.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnRiwayatTransaksi.ForeColor = Color.Black;
            btnRiwayatTransaksi.Location = new Point(113, 238);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(320, 45);
            btnRiwayatTransaksi.TabIndex = 2;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top;
            btnLogOut.BackColor = Color.White;
            btnLogOut.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(113, 293);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(320, 45);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panelKanan
            // 
            panelKanan.BackColor = Color.Transparent;
            panelKanan.ColumnCount = 2;
            panelKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            panelKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelKanan.Controls.Add(lblGreeting, 0, 0);
            panelKanan.Controls.Add(panelStatistik, 0, 1);
            panelKanan.Controls.Add(lblInfoPanduan, 0, 2);
            panelKanan.Controls.Add(pictureBoxIlustrasi, 1, 0);
            panelKanan.Controls.Add(lblSimba, 0, 3);
            panelKanan.Controls.Add(lblSub, 0, 4);
            panelKanan.Controls.Add(lblCompany, 0, 5);
            panelKanan.Dock = DockStyle.Fill;
            panelKanan.Location = new Point(0, 0);
            panelKanan.Name = "panelKanan";
            panelKanan.Padding = new Padding(10, 40, 10, 30);
            panelKanan.RowCount = 6;
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panelKanan.Size = new Size(747, 800);
            panelKanan.TabIndex = 0;
            // 
            // lblGreeting
            // 
            lblGreeting.Dock = DockStyle.Fill;
            lblGreeting.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(13, 40);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(430, 60);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Selamat datang, [Nama Customer]!";
            lblGreeting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelStatistik
            // 
            panelStatistik.BackColor = Color.FromArgb(60, 60, 60);
            panelStatistik.Controls.Add(lblTotalPesanan);
            panelStatistik.Dock = DockStyle.Fill;
            panelStatistik.Location = new Point(15, 110);
            panelStatistik.Margin = new Padding(5, 10, 10, 10);
            panelStatistik.Name = "panelStatistik";
            panelStatistik.Padding = new Padding(15, 10, 10, 10);
            panelStatistik.Size = new Size(421, 50);
            panelStatistik.TabIndex = 1;
            // 
            // lblTotalPesanan
            // 
            lblTotalPesanan.Dock = DockStyle.Fill;
            lblTotalPesanan.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalPesanan.ForeColor = Color.White;
            lblTotalPesanan.Location = new Point(15, 10);
            lblTotalPesanan.Name = "lblTotalPesanan";
            lblTotalPesanan.Size = new Size(396, 30);
            lblTotalPesanan.TabIndex = 0;
            lblTotalPesanan.Text = "Total Pesanan: 0";
            // 
            // lblInfoPanduan
            // 
            lblInfoPanduan.Dock = DockStyle.Fill;
            lblInfoPanduan.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblInfoPanduan.ForeColor = Color.LightGray;
            lblInfoPanduan.Location = new Point(13, 170);
            lblInfoPanduan.Name = "lblInfoPanduan";
            lblInfoPanduan.Size = new Size(430, 60);
            lblInfoPanduan.TabIndex = 2;
            lblInfoPanduan.Text = "Tips: Gunakan tombol di kiri untuk mulai memesan material atau melihat riwayat transaksi.";
            lblInfoPanduan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIlustrasi
            // 
            pictureBoxIlustrasi.Dock = DockStyle.Fill;
            pictureBoxIlustrasi.Image = Properties.Resources.img;
            pictureBoxIlustrasi.Location = new Point(449, 43);
            pictureBoxIlustrasi.Name = "pictureBoxIlustrasi";
            panelKanan.SetRowSpan(pictureBoxIlustrasi, 3);
            pictureBoxIlustrasi.Size = new Size(285, 184);
            pictureBoxIlustrasi.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIlustrasi.TabIndex = 3;
            pictureBoxIlustrasi.TabStop = false;
            // 
            // lblSimba
            // 
            lblSimba.Dock = DockStyle.Fill;
            lblSimba.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSimba.ForeColor = Color.White;
            lblSimba.Location = new Point(13, 230);
            lblSimba.Name = "lblSimba";
            lblSimba.Size = new Size(430, 70);
            lblSimba.TabIndex = 4;
            lblSimba.Text = "SIMBA";
            lblSimba.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            lblSub.Dock = DockStyle.Fill;
            lblSub.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSub.ForeColor = Color.White;
            lblSub.Location = new Point(13, 300);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(430, 50);
            lblSub.TabIndex = 5;
            lblSub.Text = "Aplikasi Pemesanan Material";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            lblCompany.Dock = DockStyle.Fill;
            lblCompany.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCompany.ForeColor = Color.White;
            lblCompany.Location = new Point(13, 350);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(430, 420);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "CV Pradipta Jaya Abadi";
            lblCompany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerDashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "CustomerDashboardControl";
            Size = new Size(1300, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelKiri.ResumeLayout(false);
            panelKanan.ResumeLayout(false);
            panelStatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIlustrasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel panelKiri;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnBuatPesanan;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TableLayoutPanel panelKanan;
        private System.Windows.Forms.Label lblSimba;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Panel panelStatistik;
        private System.Windows.Forms.Label lblTotalPesanan;
        private System.Windows.Forms.Label lblInfoPanduan;
        private System.Windows.Forms.PictureBox pictureBoxIlustrasi;
    }
}
