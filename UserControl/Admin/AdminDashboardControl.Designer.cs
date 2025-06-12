namespace MaterialOrderingApp.Forms.Admin
{
    partial class AdminDashboardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) //eror
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); //eror
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardControl));
            splitContainer1 = new SplitContainer();
            btnLogOut = new Button();
            label1 = new Label();
            btnManajemenPesanan = new Button();
            btnManajemenMaterial = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblJumlahPesanan = new Label();
            lblJumlahTruk = new Label();
            lblMaterialHabis = new Label();
            lblTotalCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout(); //eror
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
            splitContainer1.Panel1.Controls.Add(btnManajemenPesanan);
            splitContainer1.Panel1.Controls.Add(btnManajemenMaterial);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint; //eror
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel1);
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
            btnLogOut.Location = new Point(52, 317);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(188, 51);
            btnLogOut.TabIndex = 11;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.UseWaitCursor = true;
            btnLogOut.Click += btnLogOut_Click; //eror
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 39F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 72);
            label1.Name = "label1";
            label1.Size = new Size(231, 118);
            label1.TabIndex = 8;
            label1.Text = "ADMIN";
            // 
            // btnManajemenPesanan
            // 
            btnManajemenPesanan.AllowDrop = true;
            btnManajemenPesanan.Anchor = AnchorStyles.None;
            btnManajemenPesanan.BackColor = Color.White;
            btnManajemenPesanan.BackgroundImageLayout = ImageLayout.Stretch;
            btnManajemenPesanan.Cursor = Cursors.Hand;
            btnManajemenPesanan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManajemenPesanan.ForeColor = Color.Black;
            btnManajemenPesanan.Location = new Point(52, 243);
            btnManajemenPesanan.Name = "btnManajemenPesanan";
            btnManajemenPesanan.Size = new Size(188, 51);
            btnManajemenPesanan.TabIndex = 13;
            btnManajemenPesanan.Text = "Manajemen Pesanan";
            btnManajemenPesanan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManajemenPesanan.UseVisualStyleBackColor = false;
            btnManajemenPesanan.UseWaitCursor = true;
            btnManajemenPesanan.Click += btnManajemenPesanan_Click; //eror
            // 
            // btnManajemenMaterial
            // 
            btnManajemenMaterial.AllowDrop = true;
            btnManajemenMaterial.Anchor = AnchorStyles.None;
            btnManajemenMaterial.BackColor = Color.White;
            btnManajemenMaterial.BackgroundImageLayout = ImageLayout.Stretch;
            btnManajemenMaterial.Cursor = Cursors.Hand;
            btnManajemenMaterial.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManajemenMaterial.ForeColor = Color.Black;
            btnManajemenMaterial.Location = new Point(52, 162);
            btnManajemenMaterial.Name = "btnManajemenMaterial";
            btnManajemenMaterial.Size = new Size(188, 51);
            btnManajemenMaterial.TabIndex = 14;
            btnManajemenMaterial.Text = "Manajemen Material";
            btnManajemenMaterial.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManajemenMaterial.UseVisualStyleBackColor = false;
            btnManajemenMaterial.UseWaitCursor = true;
            btnManajemenMaterial.Click += btnManajemenMaterial_Click; //eror
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 125, 127);
            panel1.Controls.Add(lblJumlahPesanan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(63, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 153);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(236, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 153);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(81, 86, 90);
            panel3.Controls.Add(lblJumlahTruk);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(311, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 153);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(236, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 153);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(81, 86, 90);
            panel5.Controls.Add(lblMaterialHabis);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(63, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(217, 153);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Location = new Point(236, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(217, 153);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(123, 125, 127);
            panel7.Controls.Add(lblTotalCustomer);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(311, 253);
            panel7.Name = "panel7";
            panel7.Size = new Size(217, 153);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Location = new Point(236, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(217, 153);
            panel8.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 11);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 2;
            label2.Text = "Pesanan Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 10);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 3;
            label3.Text = "Truk Tersedia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 9);
            label4.Name = "label4";
            label4.Size = new Size(132, 18);
            label4.TabIndex = 3;
            label4.Text = "Material Habis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(38, 8);
            label5.Name = "label5";
            label5.Size = new Size(143, 18);
            label5.TabIndex = 4;
            label5.Text = "Total Customer";
            // 
            // lblJumlahPesanan
            // 
            lblJumlahPesanan.AutoSize = true;
            lblJumlahPesanan.Font = new Font("Verdana", 40F, FontStyle.Bold);
            lblJumlahPesanan.Location = new Point(78, 51);
            lblJumlahPesanan.Name = "lblJumlahPesanan";
            lblJumlahPesanan.Size = new Size(54, 65);
            lblJumlahPesanan.TabIndex = 3;
            lblJumlahPesanan.Text = "-";
            lblJumlahPesanan.Click += lblJumlahPesanan_Click; //eror
            // 
            // lblJumlahTruk
            // 
            lblJumlahTruk.AutoSize = true;
            lblJumlahTruk.Font = new Font("Verdana", 40F, FontStyle.Bold);
            lblJumlahTruk.Location = new Point(86, 49);
            lblJumlahTruk.Name = "lblJumlahTruk";
            lblJumlahTruk.Size = new Size(54, 65);
            lblJumlahTruk.TabIndex = 4;
            lblJumlahTruk.Text = "-";
            lblJumlahTruk.Click += lblJumlahTruk_Click; //eror
            // 
            // lblMaterialHabis
            // 
            lblMaterialHabis.AutoSize = true;
            lblMaterialHabis.Font = new Font("Verdana", 40F, FontStyle.Bold);
            lblMaterialHabis.Location = new Point(78, 50);
            lblMaterialHabis.Name = "lblMaterialHabis";
            lblMaterialHabis.Size = new Size(54, 65);
            lblMaterialHabis.TabIndex = 6;
            lblMaterialHabis.Text = "-";
            lblMaterialHabis.Click += lblMaterialHabis_Click; //eror
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.Font = new Font("Verdana", 40F, FontStyle.Bold);
            lblTotalCustomer.Location = new Point(86, 50);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(54, 65);
            lblTotalCustomer.TabIndex = 7;
            lblTotalCustomer.Text = "-";
            lblTotalCustomer.Click += lblTotalCustomer_Click; //eror
            // 
            // AdminDashboardControl
            // 
            AllowDrop = true; //eror
            AutoScaleDimensions = new SizeF(7F, 15F); //eror
            AutoScaleMode = AutoScaleMode.Font; //eror
            BackColor = Color.FromArgb(33, 33, 33); //eror
            Controls.Add(splitContainer1); //eror
            ForeColor = SystemColors.ControlLightLight; //eror
            Name = "AdminDashboardControl"; //eror
            Size = new Size(914, 480); //eror
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false); //eror
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManajemenMaterial;
        private System.Windows.Forms.Button btnManajemenPesanan;

        // Panels statistik
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;

        // Labels judul statistik
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        // Labels nilai statistik
        private System.Windows.Forms.Label lblJumlahPesanan;
        private System.Windows.Forms.Label lblJumlahTruk;
        private System.Windows.Forms.Label lblMaterialHabis;
        private System.Windows.Forms.Label lblTotalCustomer;
    }
}
