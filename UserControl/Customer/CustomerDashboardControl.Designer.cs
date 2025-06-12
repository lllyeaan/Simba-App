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
            label1 = new Label();
            btnRiwayatTransaksi = new Button();
            btnBuatPesanan = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnRiwayatTransaksi);
            splitContainer1.Panel1.Controls.Add(btnBuatPesanan);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Size = new Size(914, 480);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.AllowDrop = true;
            btnLogOut.Anchor = AnchorStyles.None;
            btnLogOut.BackColor = Color.White;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(36, 325);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(216, 51);
            btnLogOut.TabIndex = 18;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(272, 91);
            label1.TabIndex = 9;
            label1.Text = "CUSTOMER";
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.AllowDrop = true;
            btnRiwayatTransaksi.Anchor = AnchorStyles.None;
            btnRiwayatTransaksi.BackColor = Color.White;
            btnRiwayatTransaksi.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatTransaksi.Cursor = Cursors.Hand;
            btnRiwayatTransaksi.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.Black;
            btnRiwayatTransaksi.Location = new Point(36, 257);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(216, 51);
            btnRiwayatTransaksi.TabIndex = 17;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.UseWaitCursor = true;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.AllowDrop = true;
            btnBuatPesanan.Anchor = AnchorStyles.None;
            btnBuatPesanan.BackColor = Color.White;
            btnBuatPesanan.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuatPesanan.Cursor = Cursors.Hand;
            btnBuatPesanan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuatPesanan.ForeColor = Color.Black;
            btnBuatPesanan.Location = new Point(36, 189);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(216, 51);
            btnBuatPesanan.TabIndex = 16;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuatPesanan.UseVisualStyleBackColor = false;
            btnBuatPesanan.UseWaitCursor = true;
            // 
            // CustomerDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "CustomerDashboardControl";
            Size = new Size(914, 480);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
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
    }
}
