namespace MaterialOrderingApp.Forms.Customer
{
    partial class CustomerDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardControl));
            splitContainer1 = new SplitContainer();
            btnLogOut = new Button();
            btnRiwayatTransaksi = new Button();
            btnBuatPesanan = new Button();
            label1 = new Label();
            lblwelcome3 = new Label();
            lblwelcome2 = new Label();
            lblwelcome = new Label();
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
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            splitContainer1.Panel1.Controls.Add(btnRiwayatTransaksi);
            splitContainer1.Panel1.Controls.Add(btnBuatPesanan);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblwelcome3);
            splitContainer1.Panel2.Controls.Add(lblwelcome2);
            splitContainer1.Panel2.Controls.Add(lblwelcome);
            splitContainer1.Panel2.Font = new Font("Javanese Text", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            splitContainer1.Panel2.ForeColor = Color.White;
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 435;
            splitContainer1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.AllowDrop = true;
            btnLogOut.Anchor = AnchorStyles.None;
            btnLogOut.BackColor = Color.White;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(85, 484);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(267, 49);
            btnLogOut.TabIndex = 26;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.UseWaitCursor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.AllowDrop = true;
            btnRiwayatTransaksi.Anchor = AnchorStyles.None;
            btnRiwayatTransaksi.BackColor = Color.White;
            btnRiwayatTransaksi.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatTransaksi.Cursor = Cursors.Hand;
            btnRiwayatTransaksi.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnRiwayatTransaksi.ForeColor = Color.Black;
            btnRiwayatTransaksi.Location = new Point(85, 414);
            btnRiwayatTransaksi.Margin = new Padding(4, 5, 4, 5);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(267, 51);
            btnRiwayatTransaksi.TabIndex = 25;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.UseWaitCursor = true;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.AllowDrop = true;
            btnBuatPesanan.Anchor = AnchorStyles.None;
            btnBuatPesanan.BackColor = Color.White;
            btnBuatPesanan.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuatPesanan.Cursor = Cursors.Hand;
            btnBuatPesanan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnBuatPesanan.ForeColor = Color.Black;
            btnBuatPesanan.Location = new Point(85, 336);
            btnBuatPesanan.Margin = new Padding(4, 5, 4, 5);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(267, 53);
            btnBuatPesanan.TabIndex = 24;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuatPesanan.UseVisualStyleBackColor = false;
            btnBuatPesanan.Click += btnBuatPesanan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 231);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 136);
            label1.TabIndex = 27;
            label1.Text = "MENU";
            // 
            // lblwelcome3
            // 
            lblwelcome3.AutoSize = true;
            lblwelcome3.Font = new Font("Javanese Text", 28F, FontStyle.Bold);
            lblwelcome3.Location = new Point(161, 378);
            lblwelcome3.Name = "lblwelcome3";
            lblwelcome3.Size = new Size(639, 127);
            lblwelcome3.TabIndex = 25;
            lblwelcome3.Text = "CV Pradipta Jaya Abadi";
            // 
            // lblwelcome2
            // 
            lblwelcome2.AutoSize = true;
            lblwelcome2.Location = new Point(69, 281);
            lblwelcome2.Name = "lblwelcome2";
            lblwelcome2.Size = new Size(841, 136);
            lblwelcome2.TabIndex = 24;
            lblwelcome2.Text = "Aplikasi Pemesanan Material ";
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.BackColor = Color.Transparent;
            lblwelcome.Font = new Font("Javanese Text", 36F, FontStyle.Bold);
            lblwelcome.ForeColor = Color.White;
            lblwelcome.Location = new Point(316, 163);
            lblwelcome.Margin = new Padding(4, 0, 4, 0);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(301, 163);
            lblwelcome.TabIndex = 23;
            lblwelcome.Text = "SIMBA";
            // 
            // CustomerDashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomerDashboardControl";
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
        private Label label1;
        private Button btnLogOut;
        private Button btnRiwayatTransaksi;
        private Button btnBuatPesanan;
        private Label lblwelcome;
        private Label lblwelcome2;
        private Label lblwelcome3;
    }
}
